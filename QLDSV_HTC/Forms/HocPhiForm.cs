using DevExpress.XtraEditors;
using QLDSV_HTC.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class HocPhiForm : DevExpress.XtraEditors.XtraForm
    {

        public HocPhiForm()
        {
            InitializeComponent();
        }

        private void txtMaLop_EditValueChanged(object sender, EventArgs e)
        {
            txtMaLop.Properties.CharacterCasing = CharacterCasing.Upper;
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var maSV = txtMaSV.Text.Trim();

            txtHoTen.Text = "";
            txtMaLop.Text = "";

            if (maSV == "")
            {
                XtraMessageBox.Show("Mã SV không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Program.KetNoi();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Không thể kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string lenh = string.Format("SELECT HO, TEN, MALOP, DANGHIHOC FROM SINHVIEN WHERE MASV = N'{0}'", maSV);
            Program.MyReader = Program.ExecSqlDataReader(lenh);
            if (Program.MyReader == null || !Program.MyReader.HasRows)
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.MyReader.Close();
                return;
            }
            Program.MyReader.Read();
            if (Program.MyReader.GetBoolean(3))
            {
                MessageBox.Show("Sinh viên đã nghỉ học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Program.MyReader.Close();
                return;
            }

            txtHoTen.Text = Program.MyReader.GetString(0) + " " + Program.MyReader.GetString(1);
            txtMaLop.Text = Program.MyReader.GetString(2);
            Program.MyReader.Close();


            try
            {
                this.sp_GetThongTinDongHocPhiTableAdapter.Fill(this.DS.sp_GetThongTinDongHocPhi, maSV);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                this.sp_GetChiTietDongHocPhiTableAdapter.Fill(this.DS.sp_GetChiTietDongHocPhi, txtMaSV.Text.Trim(), txtNienKhoa.Text.Trim(), int.Parse(txtHocKy.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sp_GetChiTietDongHocPhiTableAdapter.Fill(this.DS.sp_GetChiTietDongHocPhi, txtMaSV.Text.Trim(), txtNienKhoa.Text.Trim(), int.Parse(txtHocKy.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}