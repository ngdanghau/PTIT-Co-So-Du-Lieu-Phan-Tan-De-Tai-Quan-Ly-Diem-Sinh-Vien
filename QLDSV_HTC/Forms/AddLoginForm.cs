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
            role.Properties.Items.Clear();
            if(Program.AuthGroup == "PGV"){
                role.Properties.Items.Add("PGV");
                role.Properties.Items.Add("KHOA");
            }
            else if (Program.AuthGroup == "KHOA"){
                role.Properties.Items.Add("KHOA");
            }
            else if (Program.AuthGroup == "PKT"){
                role.Properties.Items.Add("PKT");
            }
            role.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(userIdTxt.Text) || string.IsNullOrEmpty(userNameTxt.Text) || string.IsNullOrEmpty(passTxt.Text))
            {
                XtraMessageBox.Show("Thông tin không được trống!", "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // login không được chứa khoảng trắng
            if (userIdTxt.Text.Contains(" "))
            {
                XtraMessageBox.Show("UserID không được chứa khoảng trắng!", "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userNameTxt.Text.Contains(" "))
            {
                XtraMessageBox.Show("UserName không được chứa khoảng trắng!", "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //try
            //{
            //    SqlConnection sqlConnection = new SqlConnection(Program.connectBackup);
            //    SqlCommand sqlCommand = sqlConnection.CreateCommand();
            //    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
            //    //kirm tra
            //    sqlCommand.CommandText = "sp_TaoTaiKhoan";
            //    sqlCommand.Parameters.Add(new SqlParameter("@LGNAME", tendangnhap));
            //    sqlCommand.Parameters.Add(new SqlParameter("@PASS", matkhau));
            //    sqlCommand.Parameters.Add(new SqlParameter("@USERNAME", ten));
            //    sqlCommand.Parameters.Add(new SqlParameter("@ROLE", cmbNhom.Text));
            //    SqlParameter sqlParameter = new SqlParameter("@return", System.Data.SqlDbType.Int, sizeof(int));
            //    sqlParameter.Direction = System.Data.ParameterDirection.ReturnValue;
            //    sqlCommand.Parameters.Add(sqlParameter);
            //    sqlConnection.Open();
            //    sqlCommand.ExecuteNonQuery();


            //    int result = (int)sqlCommand.Parameters["@return"].Value;
            //    sqlConnection.Close();

            //    if (result == 0)
            //    {
            //        XtraMessageBox.Show("Tạo tài khoản thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        MessageBox.Show("Tạo tài khoản thành công");
            //        //this.gETDSSVTableAdapter.Fill(this.dS.GETDSSV);
            //        return;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    XtraMessageBox.Show(ex.Message, "Lỗi tạo tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}




            //String login = txtLogin.Text;
            //String pass = txtPass.Text;
            //String user = (String)lookUpUser.EditValue;
            //String role = rdoKhoa.Checked ? Program.NhomQuyen[1] : (rdoPGV.Checked ? Program.NhomQuyen[0] : Program.NhomQuyen[2]);

            //String subLenh = " EXEC    @return_value = [dbo].[SP_TAOLOGIN] " +

            //                " @LGNAME = N'" + login + "', " +
            //                " @PASS = N'" + pass + "', " +
            //                " @USERNAME = N'" + user + "', " +
            //                " @ROLE = N'" + role + "' ";


            //// trường hợp tạo tài khoản cho pketoan thì phải dùng LINK1, LINK2 để link tới Site 3 tạo tài khoản cho pKeToan
            //if (role == (Program.NhomQuyen[2]) && Program.ServerName == ((DataRowView)Program.Bds_Dspm[0])["TENSERVER"].ToString())
            //{
            //    // site 1 ---> sử dụng LINK2
            //    subLenh = " EXEC    @return_value = LINK2.QLDSV.[dbo].[SP_TAOLOGIN] " +

            //                " @LGNAME = N'" + login + "', " +
            //                " @PASS = N'" + pass + "', " +
            //                " @USERNAME = N'" + user + "', " +
            //                " @ROLE = N'" + role + "' ";
            //}
            //else if (role == (Program.NhomQuyen[2]) && Program.ServerName == ((DataRowView)Program.Bds_Dspm[1])["TENSERVER"].ToString())

            //{
            //    subLenh = " EXEC    @return_value = LINK1.QLDSV.[dbo].[SP_TAOLOGIN] " +

            //               " @LGNAME = N'" + login + "', " +
            //               " @PASS = N'" + pass + "', " +
            //               " @USERNAME = N'" + user + "', " +
            //               " @ROLE = N'" + role + "' ";
            //}

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