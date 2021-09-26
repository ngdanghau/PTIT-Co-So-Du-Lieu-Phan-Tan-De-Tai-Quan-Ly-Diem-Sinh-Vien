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
    public partial class DangKyLTCForm : DevExpress.XtraEditors.XtraForm
    {
        private bool isLogin = false;
        private string maSV = "";
        public DangKyLTCForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                isLogin = false;
                txtMaSV.Enabled = true;
                btnLogin.Text = "Đăng nhập";
                labelHoTen.Text = "";
                labelLop.Text = "";
            }
            else
            {
                maSV = txtMaSV.Text.Trim();
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

                isLogin = true;
                txtMaSV.Enabled = false;
                btnLogin.Text = "Thoát";

                labelHoTen.Text = string.Format("Họ và tên: {0}", Program.MyReader.GetString(0) + " " + Program.MyReader.GetString(1));
                labelLop.Text = string.Format("Lớp: {0}", Program.MyReader.GetString(2));

                Program.MyReader.Close();


            }
           


        }

        private void DangKyLTCForm_Load(object sender, EventArgs e)
        {
            labelHoTen.Text = "";
            labelLop.Text = "";
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtNienKhoa.Text.Trim() == "")
            {
                XtraMessageBox.Show("Niên khóa không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtHocKy.Text.Trim() == "")
            {
                XtraMessageBox.Show("Học kỳ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                this.sp_LayDSLopTinChiDeDangKyTableAdapter.Fill(this.DS.sp_LayDSLopTinChiDeDangKy, txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}