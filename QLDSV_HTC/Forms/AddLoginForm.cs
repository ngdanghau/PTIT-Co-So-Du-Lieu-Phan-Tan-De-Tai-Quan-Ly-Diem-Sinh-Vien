using DevExpress.XtraEditors;
using QLDSV_HTC.Class;
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
    public partial class AddLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public AddLoginForm()
        {
            InitializeComponent();
        }

        private bool CheckMaGV(string maGV, string makhoa)
        {
            String query = String.Format("EXEC sp_KiemTraMaGV @MAGV = '{0}', @MAKHOA = '{1}'", maGV, makhoa);
            int check = Program.ExecSqlNonQuery(query);
            if (check == 0) return true;
            return false;
        }

        private void createLogin_Click(object sender, EventArgs e)
        {
            string userName = userNameTxt.Text;
            string pass = passTxt.Text;
            string userId = userIdTxt.Text;
            string makhoa = cmbKhoa.Text;

            if (string.IsNullOrEmpty(userId) || string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(pass) || roleList.SelectedValue == null || string.IsNullOrEmpty(makhoa))
            {
                XtraMessageBox.Show("Thông tin không được trống!", "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

 

            string role = roleList.SelectedValue.ToString();
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
            if (pass.Length < 6)
            {
                XtraMessageBox.Show("Mật khẩu phải ít nhất 6 ký tự!", "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // kiểm tra giao viên có ở site hiện tại ko

            if (!CheckMaGV(userId, Utils.GetMaKhoa(makhoa)))
            {
                return;
            }

            // Tạo tài khoản ở site hiện tại
            string query = string.Format(" EXEC [DBO].[sp_TaoTaiKhoan] " +
                                         " @USERNAME = N'{1}', " +
                                         " @PASSWORD = N'{2}', " +
                                         " @USERID = N'{3}', " +
                                         " @ROLE = N'{4}' ", Program.Database, userName, pass, userId, role);
            int result = Program.ExecSqlNonQuery(query);
            if (result == 0)
            {
                XtraMessageBox.Show("Tạo login thành công!", "Thành công", MessageBoxButtons.OK);
                return;
            }
        }

        private void AddLoginForm_Load(object sender, EventArgs e)
        {
            var target = new List<RoleClass>(Program.roles);

            if (Program.AuthGroup == "PGV")
            {
                target.RemoveAll(p => p.TENSERVER == "PKT");
            }
            else
            {
                target.RemoveAll(p => p.TENSERVER != Program.AuthGroup);
            }

            Program.ServerLogin = Program.AuthLogin;
            Program.ServerPassword = Program.AuthPassword;


            Utils.LoadComboBox(roleList, target);
            Program.Bds_Dspm.Filter = "TENKHOA <> 'Phòng Kế Toán'";
            Utils.LoadComboBox(cmbKhoa, Program.Bds_Dspm.DataSource);
        }
    }
}