using DevExpress.XtraEditors;
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
    public partial class AddLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public AddLoginForm()
        {
            InitializeComponent();
        }

        private void AddLoginForm_Load(object sender, EventArgs e) { 
            roleList.Properties.Items.Clear();
            if(Program.AuthGroup == "PGV"){
                roleList.Properties.Items.Add("PGV");
                roleList.Properties.Items.Add("KHOA");
            }
            else if (Program.AuthGroup == "KHOA"){
                roleList.Properties.Items.Add("KHOA");
            }
            else if (Program.AuthGroup == "PKT"){
                roleList.Properties.Items.Add("PKT");
            }
            roleList.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            string userName = userNameTxt.Text;
            string pass = passTxt.Text;
            string userId = userIdTxt.Text;
            string role = roleList.SelectedText;
            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(pass))
            {
                XtraMessageBox.Show("Thông tin không được trống!", "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // login không được chứa khoảng trắng
            if (userId.Contains(" "))
            {
                XtraMessageBox.Show("UserID không được chứa khoảng trắng!", "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userName.Contains(" "))
            {
                XtraMessageBox.Show("UserName không được chứa khoảng trắng!", "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            var linkServer = "";
            if (Program.ServerName.Contains("SERVER1"))
            {
                linkServer = "LINK2";
            }
            else if (Program.ServerName.Contains("SERVER2"))
            {
                linkServer = "LINK1";
            }

            

            // Tạo tài khoản ở site hiện tại
            string query = string.Format(" EXEC    @return_value = [DBO].[sp_TaoTaiKhoan] " +
                                         " @USERNAME = N'{1}', " +
                                         " @PASSWORD = N'{2}', " +
                                         " @USERID = N'{3}', " +
                                         " @ROLE = N'{4}' ", Program.Database, userName, pass, userId, role);


            if (Program.AuthGroup == "PGV")
            {
                // Tạo tài khoản ở site phân khác => ở SERVER 1 => dùng link 1 để lk tới SERVER 2 và ngược lại
                query = string.Format(" EXEC    @return_value = {0}.{1}.[DBO].[sp_TaoTaiKhoan] " +
                                      " @USERNAME = N'{2}', " +
                                      " @PASSWORD = N'{3}', " +
                                      " @USERID = N'{4}', " +
                                      " @ROLE = N'{5}' ", linkServer, Program.Database, userName, pass, userId, role);
            }

                //// trường hợp tạo tài khoản cho chỉ khoa và pgv

                //String strLenh = " DECLARE @return_value int " + subLenh +
                //             " SELECT  'Return Value' = @return_value ";

                //int resultCheckLogin = Utils.CheckDataHelper(strLenh);

                //if (resultCheckLogin == -1)
                //{
                //    XtraMessageBox.Show("Lỗi kết nối với database. Mời ban xem lại !", "", MessageBoxButtons.OK);
                //    this.Close();
                //}
                //if (resultCheckLogin == 1)
                //{
                //    errorProvider.SetError(this.txtLogin, "Login bị trùng . Mời bạn nhập login khác !");
                //}
                //else if (resultCheckLogin == 2)
                //{
                //    errorProvider.SetError(this.lookUpUser, "Giảng viên đã có tài khoản rồi !");

                //}
                //else if (resultCheckLogin == 3)
                //{
                //    XtraMessageBox.Show("Lỗi thực thi trong cơ sơ dữ liệu !", "", MessageBoxButtons.OK);
                //}
                //else if (resultCheckLogin == 0)
                //{
                //    XtraMessageBox.Show("Tạo tài khoản thành công !", "", MessageBoxButtons.OK);

                //}

                //return;
        }
    }
}