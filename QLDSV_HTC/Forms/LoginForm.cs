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

            Program.ServerName = Program.ServerList[cmbServer.SelectedIndex];
            Program.AuthLogin = usernameText.Text;
            Program.AuthPassword = passwordText.Text;
            try
            {
                Program.KetNoi();
            }
            catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Không thể kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Program.MaKhoa = cmbServer.SelectedIndex;

            if(Program.AuthLogin.Contains("SV_"))
            {
                Program.AuthUserID = Program.AuthLogin;
                Program.AuthHoten = "Sinh Viên";
                Program.AuthGroup = "SV";
            }
            else
            {
                // Lấy thông tin của user đang login
                string sqlQuery = "exec sp_Get_Info_Login '" + Program.AuthLogin + "'";
                Program.MyReader = Program.ExecSqlDataReader(sqlQuery);
                if (Program.MyReader == null)
                {
                    return;
                }

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

            // lặp và thêm danh sách server vào combobox
            foreach (DataRow dataRow in dt.Rows)
            {
                cmbServer.Properties.Items.Add(dataRow.ItemArray[0]);
                Program.ServerList.Add(dataRow.ItemArray[1].ToString());
            }

            // sau khi add item vào combobox, set index mặc định là 0
            cmbServer.SelectedIndex = 0;

        }
    }
}