using QLDSV_HTC.Forms;
using QLDSV_HTC.ReportForms;
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

            Program.MaKhoa = "";
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
            Program.Bds_Dspm.RemoveFilter();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // set thông tin dưới status trip
            statusStrip1.Items[0].Text = string.Format("MÃ SỐ: {0}", Program.AuthUserID);
            statusStrip1.Items[1].Text = string.Format("HỌ VÀ TÊN: {0}",Program.AuthHoten);
            statusStrip1.Items[2].Text = string.Format("NHÓM: {0}", Program.AuthGroup);

            //Hiện tính năng cho mỗi quyền khác nhau

            if (Program.AuthGroup == "PGV")
            {

                baoCaoPage.Visible = true;
                InDSSVBtn.Visibility
                    = inBDMH.Visibility
                    = inDSL.Visibility
                    = inBDTK.Visibility
                    = inPhieuDiem.Visibility
                    = DevExpress.XtraBars.BarItemVisibility.Always;

                inHocPhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                
                usersGroup.Visible = true;
                hocPhiPageGroup.Visible = false;
                quanLyPageGroup.Visible = true;
                dangKyPageGroup.Visible = false;
            }
            else if (Program.AuthGroup == "KHOA")
            {
                baoCaoPage.Visible = true;
                InDSSVBtn.Visibility
                    = inBDMH.Visibility
                    = inDSL.Visibility
                    = inBDTK.Visibility
                    = inPhieuDiem.Visibility
                    = DevExpress.XtraBars.BarItemVisibility.Always;

                inHocPhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;

                usersGroup.Visible = true;
                hocPhiPageGroup.Visible = false;
                quanLyPageGroup.Visible = true;
                dangKyPageGroup.Visible = false;
            }
            else if (Program.AuthGroup == "PKT")
            {

                baoCaoPage.Visible = true;
                InDSSVBtn.Visibility 
                    = inBDMH.Visibility
                    = inDSL.Visibility
                    = inBDTK.Visibility
                    = inPhieuDiem.Visibility
                    = DevExpress.XtraBars.BarItemVisibility.Never;

                inHocPhi.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;

                usersGroup.Visible = true;
                hocPhiPageGroup.Visible = true;
                quanLyPageGroup.Visible = false;
                dangKyPageGroup.Visible = false;
            }
            else
            {
                baoCaoPage.Visible = false;
                hocPhiPageGroup.Visible = false;
                quanLyPageGroup.Visible = false;
                usersGroup.Visible = false;
                dangKyPageGroup.Visible = true;

                statusStrip1.Items[2].Text = string.Format("LỚP: {0}", Program.AuthGroup);
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

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(SinhVienForm));
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(MonHocForm));
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(InDSLOPTINCHI));
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(MoLopTinChiForm));
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(LopForm));
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(DiemForm));
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(DangKyLTCForm));
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(HocPhiForm));
        }

        private void InDSSVBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(InDSSV));
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(InPhieuDiemForm));
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(InDiemForm));
        }

        private void inHocPhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(InDSDongHPForm));
        }

        private void inBDTK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ShowMdiChildren(typeof(InBangDiemTKForm));
        }
    }
}