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
            Program.MLoginDN = "12321";
            this.Hide();

            // truy cập vào frm main 
            Program.MainForm = new MainForm();
            // hiện thông tin tài khoản
            //Program.FormMain.lblMAGV.Text = "MÃ GIẢNG VIÊN : " + Program.UserName.Trim();
            //Program.FormMain.lblHOTEN.Text = "HỌ VÀ TÊN : " + Program.MHoten.Trim();
            //Program.FormMain.lblNHOM.Text = "NHÓM : " + Program.MGroup;

            Program.MainForm.StartPosition = FormStartPosition.CenterScreen;
            Program.MainForm.Show();
            Program.MainForm.Visible = true;
        }

        private void FormLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(Program.MLoginDN))
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

        }
    }
}