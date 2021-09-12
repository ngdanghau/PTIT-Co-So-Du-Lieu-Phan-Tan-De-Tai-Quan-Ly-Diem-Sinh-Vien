using DevExpress.XtraEditors;
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
    public partial class MonHocForm : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private string state;
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

                barButtonUndo.Enabled
                    = barButtonSave.Enabled
                    = panelControl1.Enabled
                    = txtMaMonHoc.Properties.ReadOnly
                    = value;
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

                barButtonUndo.Enabled
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
            this.MONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);

            // TODO: This line of code loads data into the 'DS.LOPTINCHI' table. You can move, or remove it, as needed.
            this.LOPTINCHITableAdapter.Connection.ConnectionString = Program.URL_Connect;
            this.LOPTINCHITableAdapter.Fill(this.DS.LOPTINCHI);
            if (position > 0)
            {
                bdsMONHOC.Position = position;
            }

        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            state = "add";
            SetButtonState(true);
            txtMaMonHoc.Focus();
            bdsMONHOC.AddNew();
        }

        private void barButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            state = "edit";
            SetButtonState(true);
        }

        private void barButtonRenew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MonHocForm_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
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
                this.bdsMONHOC.EndEdit();
                this.bdsMONHOC.ResetCurrentItem();
                this.MONHOCTableAdapter.Update(this.DS.MONHOC);
                SetButtonState(false);
            }
            catch (Exception ex)
            {
                bdsMONHOC.RemoveCurrent();
                XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mAMHTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            txtMaMonHoc.Properties.CharacterCasing = CharacterCasing.Upper;
        }

        private void barButtonUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsMONHOC.CancelEdit();
            SetButtonState(false);
            MonHocForm_Load(sender, e);
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (bdsMONHOC.Position > 0)
            {
                position = bdsMONHOC.Position;
            }
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsLOPTINCHI.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa môn học này vì đã có lớp tín chỉ.", "", MessageBoxButtons.OK);
                return;
            }

            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa Lớp này?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    position = bdsMONHOC.Position;
                    bdsMONHOC.RemoveCurrent();
                    this.MONHOCTableAdapter.Connection.ConnectionString = Program.URL_Connect;
                    this.MONHOCTableAdapter.Update(this.DS.MONHOC);
                    this.bdsMONHOC.ResetCurrentItem();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa môn học.\nMã lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    MonHocForm_Load(sender, e);
                }
            }
        }
    }
}