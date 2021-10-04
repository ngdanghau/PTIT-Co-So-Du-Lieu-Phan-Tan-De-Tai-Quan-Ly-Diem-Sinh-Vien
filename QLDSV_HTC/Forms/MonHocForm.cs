using DevExpress.XtraEditors;
using QLDSV_HTC.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class MonHocForm : DevExpress.XtraEditors.XtraForm
    {
        private int position = -1;
        private string state;
        private MonHocClass MonHocData = null;

        Stack<string> undoStack = new Stack<string>();

        public MonHocForm()
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
                    = gcMONHOC.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = panelControl1.Enabled
                    = txtMaMonHoc.Properties.ReadOnly
                    = value;

                barButtonUndo.Enabled = undoStack.Count > 0;
            }
            else if (state == "add")
            {
                barButtonAdd.Enabled
                    = barButtonEdit.Enabled
                    = barButtonDelete.Enabled
                    = barButtonRenew.Enabled
                    = gcMONHOC.Enabled
                    = txtMaMonHoc.Properties.ReadOnly
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = panelControl1.Enabled
                    = value;
            }
        }

        private bool ValidateForm()
        {
            if (txtMaMonHoc.Text.Trim() == "")
            {
                XtraMessageBox.Show("Mã môn học không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTenMonHoc.Text.Trim() == "")
            {
                XtraMessageBox.Show("Tên môn học không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Convert.ToInt32(txtSoTietLT.Text) < 0)
            {
                XtraMessageBox.Show("Số tiết lý thuyết phải lớn hơn 0!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (Convert.ToInt32(txtSoTietTH.Text) < 0)
            {
                XtraMessageBox.Show("Số tiết thực hành phải lớn hơn 0!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMONHOC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void MonHocForm_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.ConnStr;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

            // TODO: This line of code loads data into the 'DS.LOPTINCHI' table. You can move, or remove it, as needed.
            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.ConnStr;
            this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            if (position > -1)
            {
                bdsMONHOC.Position = position;
            }

            barButtonDelete.Enabled = barButtonEdit.Enabled = bdsMONHOC.Count > 0;
        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsMONHOC.Position;
            state = "add";
            SetButtonState(true);
            txtMaMonHoc.Focus();
            bdsMONHOC.AddNew();
        }

        private void barButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsMONHOC.Position;
            state = "edit";
            SetButtonState(true);
        }

        private void barButtonRenew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = 0;
            MonHocForm_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barButtonCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.panelControl1.Enabled)
            {
                string message = "Môn học đang thêm chưa lưu vào Database. \n Bạn có chắc muốn thoát !";
                if (state == "edit") message = "Môn học đang hiệu chỉnh chưa lưu vào Database. \n Bạn có chắc muốn thoát !";
                DialogResult dr = XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
        }

        private bool checkMaMonHoc()
        {
            string query = string.Format(" EXEC sp_KiemTraMaMH N'{0}' ", txtMaMonHoc.Text.Trim());

            var check = Program.ExecSqlNonQuery(query);
            if(check == 0) return true;
            return false;
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateForm()) return;

            if (state == "add" && !checkMaMonHoc()) return;
            try
            {
                this.bdsMONHOC.EndEdit();
                this.bdsMONHOC.ResetCurrentItem();
                this.MONHOCTableAdapter.Update(this.DS.MONHOC);

                if(state == "edit")
                {
                    undoStack.Push(string.Format("UPDATE MONHOC SET TENMH = N'{0}', SOTIET_LT = {1}, SOTIET_TH = {2} WHERE MAMH = '{3}'", MonHocData.TenMonHoc, MonHocData.SoTiet_LT, MonHocData.SoTiet_TH, MonHocData.MaMonHoc));
                }
            }
            catch (Exception ex)
            {
                bdsMONHOC.RemoveCurrent();
                XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetButtonState(false);
        }

        private void barButtonUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command = undoStack.Pop();
            Program.ExecSqlNonQuery(command);

            MonHocForm_Load(null, null);
            barButtonUndo.Enabled = undoStack.Count > 0;
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLOPTINCHI.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa môn học này vì đã có lớp tín chỉ.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa Lớp này?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    position = bdsMONHOC.Position;
                    bdsMONHOC.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.ConnStr;
                    this.MONHOCTableAdapter.Update(this.DS.MONHOC);
                    this.bdsMONHOC.ResetCurrentItem();

                    undoStack.Push(string.Format("INSERT INTO MONHOC(MAMH, TENMH, SOTIET_LT, SOTIET_TH) values('{0}', N'{1}', {2}, {3})", MonHocData.MaMonHoc, MonHocData.TenMonHoc, MonHocData.SoTiet_LT, MonHocData.SoTiet_TH));
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa môn học.\nMã lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
                    bdsMONHOC.Position = position;
                }
            }
            barButtonDelete.Enabled = bdsMONHOC.Count > 0;
            barButtonUndo.Enabled = undoStack.Count > 0;
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMONHOC.CancelEdit();
            SetButtonState(false);
            MonHocForm_Load(sender, e);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                MonHocData = new MonHocClass(txtMaMonHoc.Text.Trim(), txtTenMonHoc.Text.Trim(), Convert.ToInt32(txtSoTietLT.Text), Convert.ToInt32(txtSoTietTH.Text));
            }
            catch { }
        }
    }
}