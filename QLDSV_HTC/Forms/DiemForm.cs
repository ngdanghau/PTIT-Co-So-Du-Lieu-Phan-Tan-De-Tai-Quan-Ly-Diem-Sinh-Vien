using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class DiemForm : DevExpress.XtraEditors.XtraForm
    {
        private bool state = false;
        private int position = -1;
        public DiemForm()
        {
            InitializeComponent();
        }


        private void barButtonRenew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DiemForm_Load(sender, e);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK);
        }

        private void barButtonCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (state)
            {
                DialogResult dr = XtraMessageBox.Show("Điểm đang được hiệu chỉnh, chưa lưu vào Database. \n Bạn có chắc muốn thoát !", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
        }


        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.ChangeServer(cmbKhoa);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (txtNienKhoa.Text.Trim() == "")
            {
                XtraMessageBox.Show("Niên khóa không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtHocKy.Text.Trim() == "")
            {
                XtraMessageBox.Show("Học kỳ không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtNhom.Text.Trim() == "")
            {
                XtraMessageBox.Show("Nhóm không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lookUpMonHoc.EditValue == null || lookUpMonHoc.EditValue.ToString().Trim() == "")
            {
                XtraMessageBox.Show("Môn học không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                this.sp_GetBangDiemMonHocTableAdapter.Fill(this.DS.sp_GetBangDiemMonHoc, Utils.GetMaKhoa(cmbKhoa.Text), txtNienKhoa.Text, Convert.ToInt32(txtHocKy.Text), lookUpMonHoc.EditValue.ToString(), Convert.ToInt32(txtNhom.Text));
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi tìm kiếm!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sp_GetBangDiemMonHocBindingSource.EndEdit();

            BindingSource bdsTemp = (BindingSource)this.sp_GetBangDiemMonHocGridControl.DataSource;

            // kết thúc việc cập nhật dữ liệu
            this.Validate();
            bdsTemp.EndEdit();

            for (int i = 0; i < bdsTemp.Count; i++)
            {
                string masv = ((DataRowView)bdsTemp[i])["MASV"].ToString();
                int diemcc = Convert.ToInt32(((DataRowView)bdsTemp[i])["DIEM_CC"]);
                double diemGK = Convert.ToDouble(((DataRowView)bdsTemp[i])["DIEM_GK"]);
                double diemCK = Convert.ToDouble(((DataRowView)bdsTemp[i])["DIEM_CK"]);
                this.sp_GetBangDiemMonHocTableAdapter.Update(Utils.GetMaKhoa(cmbKhoa.Text), txtNienKhoa.Text, Convert.ToInt32(txtHocKy.Text), Convert.ToInt32(txtNhom.Text), lookUpMonHoc.EditValue.ToString(), masv, diemcc, diemGK, diemCK);
            }
            btnSave.Enabled = btnHuy.Enabled = false;
            btnUndo.Enabled = true;
            XtraMessageBox.Show("Cập nhật điểm thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void sp_GetBangDiemMonHocBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sp_GetBangDiemMonHocBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void DiemForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.MONHOC' table. You can move, or remove it, as needed.
            this.MONHOCTableAdapter.Fill(this.DS.MONHOC);
            if (Program.AuthGroup == "PGV")
            {
                Program.Bds_Dspm.Filter = "TENKHOA <> 'Phòng Kế Toán'";
            }
            else if (Program.AuthGroup == "KHOA")
            {
                Program.Bds_Dspm.Filter = string.Format("TENSERVER = '{0}'", Program.ServerName);
            }

            Utils.LoadComboBox(cmbKhoa, Program.Bds_Dspm.DataSource);
            Utils.ChangeServer(cmbKhoa);


            lookUpMonHoc.Properties.PopulateColumns();
            lookUpMonHoc.Properties.Columns[2].Visible = false;
            lookUpMonHoc.Properties.Columns[3].Visible = false;
        }

        private void gridView1_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView1.FocusedColumn.FieldName == "DIEM_CC")
            {
                int x = 0;
                if (!int.TryParse(e.Value as String, out x))
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm CC chỉ cho phép số tự nhiên từ 0-10";
                }
                else if (x < 0 || x > 10)
                {
                    e.Valid = false;
                    e.ErrorText = "Điểm CC chỉ cho phép số tự nhiên từ 0-10";
                }
                else
                {
                    position = sp_GetBangDiemMonHocBindingSource.Position;
                    state = true;
                    btnSave.Enabled = btnHuy.Enabled = true;
                }
            }
            else if (gridView1.FocusedColumn.FieldName == "DIEM_GK" || gridView1.FocusedColumn.FieldName == "DIEM_CK")
            {
                var mess = "Điểm CK chỉ cho phép số thập phân từ 0-10";
                if(gridView1.FocusedColumn.FieldName == "DIEM_GK")
                {
                    mess = "Điểm GK chỉ cho phép số thập phân từ 0-10";
                }
                double x = 0;

                if (!double.TryParse(e.Value as String, out x))
                {
                    e.Valid = false;
                    e.ErrorText = mess;
                }
                else
                {
                    x = Math.Round(x, 1);
                    if (x < 0 || x > 10)
                    {
                        e.Valid = false;
                        e.ErrorText = mess;
                    }
                    else
                    {
                        e.Value = x;
                        position = sp_GetBangDiemMonHocBindingSource.Position;
                        state = true;
                        btnSave.Enabled = btnHuy.Enabled = true;
                    }
                }
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // hủy
            btnUndo.Enabled = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnStart_Click(null, null);
            if (position > -1)
            {
                sp_GetBangDiemMonHocBindingSource.Position = position;
            }
        }
    }
}