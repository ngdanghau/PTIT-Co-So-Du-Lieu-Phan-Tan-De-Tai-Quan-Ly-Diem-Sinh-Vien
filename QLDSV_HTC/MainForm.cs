using QLDSV_HTC.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public bool check = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void logout()
        {
            Program.MLoginDN = string.Empty;
            Program.PasswordDN = string.Empty;
            Program.MGroup = string.Empty;
            Program.MHoten = string.Empty;
            Program.MKhoa = 0;
    }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logout();
            Program.MainForm.StartPosition = FormStartPosition.CenterScreen;
            Program.MainForm.Show();
            this.Hide();
        }
    }
}