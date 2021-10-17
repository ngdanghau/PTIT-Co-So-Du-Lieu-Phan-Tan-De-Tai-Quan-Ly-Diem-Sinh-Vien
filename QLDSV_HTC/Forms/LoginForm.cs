using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
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
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void outBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // Kiểm tra input 
            if (usernameText.Text.Trim() == "" || passwordText.Text.Trim() == "")
            {
                XtraMessageBox.Show("Thông tin đăng nhập không được trống!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.ServerName = cmbServer.SelectedValue.ToString();
            Program.AuthServerName = cmbServer.SelectedValue.ToString();

            Program.AuthLogin = usernameText.Text.Trim();
            Program.AuthPassword = passwordText.Text.Trim();

            Program.ServerLogin = usernameText.Text.Trim();
            Program.ServerPassword = passwordText.Text.Trim();

            if (svLogin.Checked)
            {
                Program.ServerLogin = Program.SVLogin;
                Program.ServerPassword = Program.SVPassword;
                Program.AuthGroup = "SV";
            }

            Program.MaKhoa = Utils.GetMaKhoa(cmbServer.Text);


            try
            {
                Program.KetNoi();
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Không thể kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (svLogin.Checked)
            {
                string lenh = string.Format("SELECT HO, TEN, MALOP, DANGHIHOC, PASSWORD FROM SINHVIEN WHERE MASV = N'{0}'", Program.AuthLogin);
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

                if (Program.MyReader.GetString(4) != Program.AuthPassword)
                {
                    MessageBox.Show("Thông tin mật khẩu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.MyReader.Close();
                    return;
                }

                Program.AuthUserID = Program.AuthLogin;
                Program.AuthHoten = Program.MyReader.GetString(0) + " " + Program.MyReader.GetString(1);
                Program.AuthGroup = Program.MyReader.GetString(2);
                Program.MyReader.Close();
            }
            else
            {
                // Lấy thông tin của user đang login
                string sqlQuery = "exec sp_Get_Info_Login '" + Program.AuthLogin + "'";
                Program.MyReader = Program.ExecSqlDataReader(sqlQuery);
                if (Program.MyReader == null) return;
                Program.MyReader.Read();

                try
                {
                    Program.AuthUserID = Program.MyReader.GetString(0);
                    if (string.IsNullOrEmpty(Program.AuthUserID))
                    {
                        XtraMessageBox.Show("Tài khoản không có quyền truy cập dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    Program.AuthHoten = Program.MyReader.GetString(1);
                    Program.AuthGroup = Program.MyReader.GetString(2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi lấy thông tin login: " + ex.ToString());
                    XtraMessageBox.Show("Tài khoản không tồn tại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Program.MyReader.Close();
                Program.Conn.Close();
            }

            

            // mở Main Form
            Program.MainForm = new MainForm();
            Program.MainForm.StartPosition = FormStartPosition.CenterScreen;
            Program.MainForm.Show();
            Program.MainForm.Visible = true;

            this.Hide();
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(Program.AuthLogin))
            {
                Application.Exit();
            }
        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                passwordText.Properties.PasswordChar = '\0';
            }
            else
            {
                passwordText.Properties.PasswordChar = '*';
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // tạo chỗi kết nối
            string chuoiketnoi = "Data Source="+Program.DataSource + ";Initial Catalog=" + Program.Database + ";Integrated Security=True";

            Program.Conn.ConnectionString = chuoiketnoi;

            DataTable dt = new DataTable();
            //gọi 1 view và trả về dưới dạng datatable
            dt = Program.ExecSqlDataTable("SELECT * FROM Get_Subscribes");

            
            // cất dt vào biến toàn cục Bds_Dspm
            Program.Bds_Dspm.DataSource = dt;
            Utils.LoadComboBox(cmbServer, dt);
        }
    }
}