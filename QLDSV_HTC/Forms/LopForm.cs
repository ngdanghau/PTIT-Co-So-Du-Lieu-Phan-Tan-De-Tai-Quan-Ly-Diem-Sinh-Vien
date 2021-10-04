using DevExpress.XtraEditors;
using QLDSV_HTC.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class LopForm : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private string state;
        private LopClass LopData = null;

        Stack<string> undoStack = new Stack<string>();
        public LopForm()
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
                    = gcLOP.Enabled
                    = panelControl1.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = panelControl4.Enabled
                    = txtMaLop.Properties.ReadOnly
                    = value;

                barButtonUndo.Enabled = undoStack.Count > 0;
            }
            else if (state == "add")
            {
                barButtonAdd.Enabled
                    = barButtonEdit.Enabled
                    = barButtonDelete.Enabled
                    = barButtonRenew.Enabled
                    = gcLOP.Enabled
                    = txtMaLop.Properties.ReadOnly
                    = panelControl1.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = panelControl4.Enabled
                    = value;
            }
        }

        private bool ValidateForm()
        {
            if (txtMaLop.Text.Trim() == "")
            {
                XtraMessageBox.Show("Mã lớp học không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTenLop.Text.Trim() == "")
            {
                XtraMessageBox.Show("Tên lớp học không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtKhoaHoc.Text.Trim() == "")
            {
                XtraMessageBox.Show("Khóa học không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtMaKhoa.Text.Trim() == "")
            {
                XtraMessageBox.Show("Mã khoa không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void LoadData()
        {
            DS.EnforceConstraints = false;
            this.SINHVIENTableAdapter.Connection.ConnectionString = Program.ConnStr;
            // TODO: This line of code loads data into the 'DS.SINHVIEN' table. You can move, or remove it, as needed.
            this.SINHVIENTableAdapter.Fill(this.DS.SINHVIEN);
            // TODO: This line of code loads data into the 'DS.LOP' table. You can move, or remove it, as needed.
            this.LOPTableAdapter.Connection.ConnectionString = Program.ConnStr;
            this.LOPTableAdapter.Fill(this.DS.LOP);
            if (position > 0)
            {
                bdsLOP.Position = position;
            }
            barButtonDelete.Enabled = barButtonEdit.Enabled = bdsLOP.Count > 0;
        }

        private void LopForm_Load(object sender, EventArgs e)
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

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsLOP.Position;
            state = "add";
            SetButtonState(true);
            txtMaLop.Focus();
            if (txtMaKhoa.DataBindings.Count > 0)
            {
                this.DS.LOP.MAKHOAColumn.DefaultValue = Program.MaKhoa;
                txtMaKhoa.DataBindings[0].DataSourceNullValue = Program.MaKhoa;
            }
            bdsLOP.AddNew();
        }

        private void barButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsLOP.Position;
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
                string message = "Lớp học đang thêm chưa lưu vào Database. \n Bạn có chắc muốn thoát !";
                if (state == "edit") message = "Lớp học đang hiệu chỉnh chưa lưu vào Database. \n Bạn có chắc muốn thoát !";
                DialogResult dr = XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
        }

        private bool checkMaLop()
        {
            string query = string.Format(" EXEC sp_KiemTraMaLop N'{0}' ", txtMaLop.Text.Trim());

            var check = Program.ExecSqlNonQuery(query);
            if (check == 0) return true;
            return false;
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateForm()) return;
            if (state == "add" && !checkMaLop()) return;
            try
            {
                this.bdsLOP.EndEdit();
                this.bdsLOP.ResetCurrentItem();
                this.LOPTableAdapter.Update(this.DS.LOP);

                if (state == "edit")
                {
                    undoStack.Push(string.Format("UPDATE LOP SET TENLOP = N'{0}', KHOAHOC = N'{1}', MAKHOA = N'{2}' WHERE MALOP = N'{3}'", LopData.TenLop, LopData.KhoaHoc, LopData.MaKhoa, LopData.MaLop));
                }
            }
            catch (Exception ex)
            {
                bdsLOP.RemoveCurrent();
                XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetButtonState(false);
        }

        private void mAMHTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            txtMaLop.Properties.CharacterCasing = CharacterCasing.Upper;
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
            if (bdsSINHVIEN.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa lớp học này vì đã có sinh viên.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa Lớp này?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    position = bdsLOP.Position;
                    bdsLOP.RemoveCurrent();
                    this.LOPTableAdapter.Connection.ConnectionString = Program.ConnStr;
                    this.LOPTableAdapter.Update(this.DS.LOP);
                    this.bdsLOP.ResetCurrentItem();

                    undoStack.Push(string.Format("INSERT INTO LOP(MALOP, TENLOP, KHOAHOC, MAKHOA) values(N'{0}', N'{1}', N'{2}', N'{3}')", LopData.MaLop, LopData.TenLop, LopData.KhoaHoc, LopData.MaKhoa));
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa lớp học.\nMã lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    LopForm_Load(sender, e);
                }
            }

            barButtonDelete.Enabled = bdsLOP.Count > 0;
            barButtonUndo.Enabled = undoStack.Count > 0;
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
            bdsLOP.CancelEdit();
            SetButtonState(false);
            LoadData();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                LopData = new LopClass(txtMaLop.Text.Trim(), txtTenLop.Text.Trim(), txtKhoaHoc.Text.Trim(), txtMaKhoa.Text.Trim());
            }
            catch { }
        }
    }
}