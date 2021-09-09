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
            Program.AuthUserID = string.Empty;
            Program.AuthLogin = string.Empty;
            Program.AuthPassword = string.Empty;
            Program.AuthGroup = string.Empty;
            Program.AuthHoten = string.Empty;

            Program.MaKhoa = 0;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            logout();
            Program.LoginForm.StartPosition = FormStartPosition.CenterScreen;
            Program.LoginForm.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // set thông tin dưới status trip
            statusStrip1.Items[0].Text = string.Format("MÃ SỐ: {0}", Program.AuthUserID);
            statusStrip1.Items[1].Text = string.Format("HỌ VÀ TÊN: {0}",Program.AuthHoten);
            statusStrip1.Items[2].Text = string.Format("NHÓM: {0}", Program.AuthGroup);
            statusStrip1.Items[3].Text = string.Format("SERVER: {0}", Program.ServerList[Program.MaKhoa]);

            //Hiện tính năng cho mỗi quyền khác nhau

            if (Program.AuthGroup == "PGV")
            {
                usersGroup.Visible = true;
            }
            else if (Program.AuthGroup == "KHOA")
            {
                usersGroup.Visible = true;
            }
            else if (Program.AuthGroup == "PKT")
            {
                usersGroup.Visible = true;
            }
            else
            {
                usersGroup.Visible = false;
            }

        }

        // TODO : HANDLE CONTROL CHILDREN
        private void ShowMdiChildren(Type fType)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                {
                    f.Activate();
                    return;
                }
            }
            Form form = (Form)Activator.CreateInstance(fType);
            form.MdiParent = this;
            form.Show();
        }

        private void registerBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(AddLoginForm));
        }
    }
}