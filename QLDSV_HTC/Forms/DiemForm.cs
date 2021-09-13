using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class DiemForm : DevExpress.XtraEditors.XtraForm
    {
        private int position = 0;
        private string state;
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

            if (lookUpMonHoc.EditValue.ToString().Trim() == "")
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

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            DataRowView rowView = e.Row as DataRowView;
            DataRow row = rowView.Row;
            Console.WriteLine(row.ItemArray[2].ToString());
        }
    }
}