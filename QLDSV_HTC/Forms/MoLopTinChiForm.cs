using DevExpress.XtraEditors;
using QLDSV_HTC.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class MoLopTinChiForm : DevExpress.XtraEditors.XtraForm
    {
        private int position = -1;
        private string state;

        private LopTinChiClass LopTinChiData = null;

        Stack<string> undoStack = new Stack<string>();
        public MoLopTinChiForm()
        {
            InitializeComponent();
        }

        private void SetButtonState(bool value)
        {
            if (state == "edit")
            {
                barButtonAdd.Enabled
                    = barButtonEdit.Enabled
                    = barButtonDelete.Enabled
                    = barButtonRenew.Enabled
                    = gcLOPTINCHI.Enabled
                    = panelControl2.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = panelControl1.Enabled
                    = value;

                barButtonUndo.Enabled = undoStack.Count > 0;
            }
            else if (state == "add")
            {
                barButtonAdd.Enabled
                    = barButtonEdit.Enabled
                    = barButtonDelete.Enabled
                    = barButtonRenew.Enabled
                    = gcLOPTINCHI.Enabled
                    = panelControl2.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = panelControl1.Enabled
                    = value;
            }
        }

        private bool ValidateForm()
        {
            if (txtNienKhoa.Text.Trim() == "")
            {
                XtraMessageBox.Show("Niên khóa không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtHocKy.Value > 4 || txtHocKy.Value < 1)
            {
                XtraMessageBox.Show("Học kỳ phải trong khoảng 1-4!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtNhom.Value < 1)
            {
                XtraMessageBox.Show("Nhóm phải lớn hơn 0!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtSoSVTT.Value < 1)
            {
                XtraMessageBox.Show("Số sinh viên tối thiểu phải lớn hơn 0!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMaMonHoc.EditValue == null)
            {
                XtraMessageBox.Show("Mã môn học không được bỏ trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (bdsMONHOC.Find("MAMH", txtMaMonHoc.EditValue.ToString()) == -1)
            {
                XtraMessageBox.Show("Mã môn học không tồn tại!", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMaGV.EditValue == null)
            {
                XtraMessageBox.Show("Mã giảng viên không được bỏ trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (bdsGIANGVIEN.Find("MAGV", txtMaGV.EditValue.ToString()) == -1)
            {
                XtraMessageBox.Show("Mã giảng viên không tồn tại!", "Lỗi",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            if (txtMaKhoa.EditValue == null)
            {
                XtraMessageBox.Show("Mã khoa không được bỏ trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsLOPTINCHI.Position;
            state = "add";
            SetButtonState(true);
            if (txtMaKhoa.DataBindings.Count > 0)
            {
                this.DS.LOPTINCHI.MAKHOAColumn.DefaultValue = Program.MaKhoa;
                this.DS.LOPTINCHI.HUYLOPColumn.DefaultValue = 0;
                txtMaKhoa.DataBindings[0].DataSourceNullValue = Program.MaKhoa;
            }
            bdsLOPTINCHI.AddNew();
        }

        private void barButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsLOPTINCHI.Position;
            state = "edit";
            SetButtonState(true);
        }

        private void barButtonRenew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = 0;
            LoadData();
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barButtonCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.panelControl1.Enabled)
            {
                string message = "Lớp tín chỉ đang thêm chưa lưu vào Database. \n Bạn có chắc muốn thoát !";
                if (state == "edit") message = "Lớp tín chỉ đang hiệu chỉnh chưa lưu vào Database. \n Bạn có chắc muốn thoát !";
                DialogResult dr = XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
        }

        private bool checkLTC()
        {
            string query = string.Format(" EXEC sp_KiemTraLTC @NIENKHOA = N'{0}', @HOCKY = {1}, @MAMH = N'{2}', @NHOM = {3}", txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text), txtMaMonHoc.Text.Trim(), Convert.ToInt32(txtNhom.Text));

            var check = Program.ExecSqlNonQuery(query);
            if (check == 0) return true;
            return false;
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateForm()) return;
            if (state == "add" && !checkLTC()) return;
            try
            {
                if(state =="edit")
                    if (LopTinChiData.SoSVToiThieu > Convert.ToInt32(txtSoSVTT.Text) && bdsDANGKY.Count > 0)
                    {
                        XtraMessageBox.Show("Số SV tối thiểu sau khi sửa phải lớn hơn SV tối thiểu trước đó", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                this.bdsLOPTINCHI.EndEdit();
                this.bdsLOPTINCHI.ResetCurrentItem();
                this.LOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);

                if (state == "edit")
                {
                    undoStack.Push(string.Format("UPDATE LOPTINCHI SET NIENKHOA = N'{0}', HOCKY = {1}, MAMH = N'{2}', NHOM = {3}, MAGV = N'{4}', MAKHOA = N'{5}', SOSVTOITHIEU = {6}, HUYLOP = {7} WHERE MALTC = '{8}'", LopTinChiData.NienKhoa, LopTinChiData.HocKy, LopTinChiData.MaMonHoc, LopTinChiData.Nhom, LopTinChiData.MaGiangVien, LopTinChiData.MaKhoa, LopTinChiData.SoSVToiThieu, Convert.ToInt32(LopTinChiData.HuyLop), LopTinChiData.MaLTC));
                }
            }
            catch (Exception ex)
            {
                bdsLOPTINCHI.RemoveCurrent();
                XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetButtonState(false);
        }

        private void barButtonUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command = undoStack.Pop();
            Program.ExecSqlNonQuery(command);

            LoadData();
            barButtonUndo.Enabled = undoStack.Count > 0;
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsDANGKY.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa lớp tín chỉ này vì đã có sinh viên đăng ký.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa lớp tín chỉ này?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    position = bdsLOPTINCHI.Position;
                    bdsLOPTINCHI.RemoveCurrent();
                    this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.ConnStr;
                    this.LOPTINCHITableAdapter.Update(this.DS.LOPTINCHI);
                    this.bdsLOPTINCHI.ResetCurrentItem();

                    undoStack.Push(string.Format("INSERT LOPTINCHI (NIENKHOA, HOCKY, MAMH, NHOM, MAGV, MAKHOA, SOSVTOITHIEU, HUYLOP) VALUES (N'{0}', {1}, N'{2}', {3}, N'{4}', N'{5}', {6}, {7})", LopTinChiData.NienKhoa, LopTinChiData.HocKy, LopTinChiData.MaMonHoc, LopTinChiData.Nhom, LopTinChiData.MaGiangVien, LopTinChiData.MaKhoa, LopTinChiData.SoSVToiThieu, Convert.ToInt32(LopTinChiData.HuyLop)));
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa lớp tín chỉ.\nMã lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
                    bdsLOPTINCHI.Position = position;
                }
            }
            barButtonDelete.Enabled = bdsLOPTINCHI.Count > 0;
            barButtonUndo.Enabled = undoStack.Count > 0;
        }

        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOPTINCHI.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void LoadData()
        {
            DS.EnforceConstraints = false;

            this.GIANGVIENTableAdapter.Connection.ConnectionString = Program.ConnStr;
            // TODO: This line of code loads data into the 'DS.GIANGVIEN' table. You can move, or remove it, as needed.
            this.GIANGVIENTableAdapter.Fill(this.DS.GIANGVIEN);

            this.MONHOCTableAdapter.Connection.ConnectionString = Program.ConnStr;
            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);


            this.DANGKYTableAdapter.Connection.ConnectionString = Program.ConnStr;
            // TODO: This line of code loads data into the 'DS.DANGKY' table. You can move, or remove it, as needed.
            this.DANGKYTableAdapter.Fill(this.DS.DANGKY);

            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.ConnStr;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            if (position > -1)
            {
                bdsLOPTINCHI.Position = position;
            }

            barButtonEdit.Enabled = barButtonDelete.Enabled = bdsLOPTINCHI.Count > 0;
        }

        private void MoLopTinChiForm_Load(object sender, EventArgs e)
        {

            if (Program.AuthGroup == "PGV")
            {
                Program.Bds_Dspm.Filter = "TENKHOA <> 'Phòng Kế Toán'";
            }
            else if (Program.AuthGroup == "KHOA")
            {
                Program.Bds_Dspm.Filter = string.Format("TENSERVER = '{0}'", Program.ServerName);
            }

            Utils.LoadComboBox(cmbKhoa, Program.Bds_Dspm.DataSource);

            if (Utils.ChangeServer(cmbKhoa))
            {
                LoadData();
            }

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Utils.ChangeServer(cmbKhoa))
            {
                LoadData();
            }
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOPTINCHI.CancelEdit();
            SetButtonState(false);
            MoLopTinChiForm_Load(sender, e);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                LopTinChiData = new LopTinChiClass(Convert.ToInt32(txtMaLTC.Text), txtNienKhoa.Text.Trim(), txtMaMonHoc.EditValue.ToString().Trim(), txtMaGV.Text.Trim(), txtMaKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text), Convert.ToInt32(txtNhom.Text), Convert.ToInt32(txtSoSVTT.Text), hUYLOPCheckBox.Checked);
            }
            catch { }
        }
    }
}