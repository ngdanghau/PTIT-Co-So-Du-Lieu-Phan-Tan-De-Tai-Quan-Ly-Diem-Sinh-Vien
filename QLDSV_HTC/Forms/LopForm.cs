using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class LopForm : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private string state;
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

                barButtonUndo.Enabled
                    = barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = panelControl4.Enabled
                    = txtMaLop.Properties.ReadOnly
                    = value;
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

                barButtonUndo.Enabled
                    = barButtonHuy.Enabled
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
            if (bdsLOP.Count == 0) barButtonDelete.Enabled = false;
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
            LopForm_Load(sender, e);
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

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateForm()) return;
            try
            {
                this.bdsLOP.EndEdit();
                this.bdsLOP.ResetCurrentItem();
                this.LOPTableAdapter.Update(this.DS.LOP);
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
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa lớp học.\nMã lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    LopForm_Load(sender, e);
                }
            }

            if (bdsLOP.Count == 0) barButtonDelete.Enabled = false;
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Utils.ChangeServer(cmbKhoa))
            {
                LoadData();
            }
        }

        private void txtMaLop_EditValueChanged(object sender, EventArgs e)
        {
            txtMaLop.Properties.CharacterCasing = CharacterCasing.Upper;
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.CancelEdit();
            SetButtonState(false);
            LoadData();
        }
    }
}