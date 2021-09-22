
namespace QLDSV_HTC
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.loginBtn = new DevExpress.XtraBars.BarButtonItem();
            this.logoutBtn = new DevExpress.XtraBars.BarButtonItem();
            this.InDSSVBtn = new DevExpress.XtraBars.BarButtonItem();
            this.inDSL = new DevExpress.XtraBars.BarButtonItem();
            this.inBDMH = new DevExpress.XtraBars.BarButtonItem();
            this.inPhieuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.inHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.inBDTK = new DevExpress.XtraBars.BarButtonItem();
            this.registerBtn = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem11 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem12 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem13 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem14 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem15 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem16 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.usersGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.quanLyPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.hocPhiPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.dangKyPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.baoCaoPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.loginBtn,
            this.logoutBtn,
            this.InDSSVBtn,
            this.inDSL,
            this.inBDMH,
            this.inPhieuDiem,
            this.inHocPhi,
            this.inBDTK,
            this.registerBtn,
            this.barButtonItem9,
            this.barButtonItem10,
            this.barButtonItem11,
            this.barButtonItem12,
            this.barButtonItem13,
            this.barButtonItem14,
            this.barButtonItem15,
            this.barButtonItem16});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 19;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.baoCaoPage});
            this.ribbonControl1.Size = new System.Drawing.Size(1056, 158);
            // 
            // loginBtn
            // 
            this.loginBtn.Caption = "Đăng nhập";
            this.loginBtn.Enabled = false;
            this.loginBtn.Id = 1;
            this.loginBtn.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.login;
            this.loginBtn.LargeWidth = 80;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Caption = "Đăng xuất";
            this.logoutBtn.Id = 2;
            this.logoutBtn.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.logout;
            this.logoutBtn.LargeWidth = 80;
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.logoutBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.logoutBtn_ItemClick);
            // 
            // InDSSVBtn
            // 
            this.InDSSVBtn.Caption = "Danh sách sinh viên";
            this.InDSSVBtn.Id = 4;
            this.InDSSVBtn.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.Whitelisting_Services;
            this.InDSSVBtn.LargeWidth = 80;
            this.InDSSVBtn.Name = "InDSSVBtn";
            this.InDSSVBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.InDSSVBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.InDSSVBtn_ItemClick);
            // 
            // inDSL
            // 
            this.inDSL.Caption = "Danh sách lớp ";
            this.inDSL.Id = 5;
            this.inDSL.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.Whitelisting_Services;
            this.inDSL.LargeWidth = 80;
            this.inDSL.Name = "inDSL";
            this.inDSL.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.inDSL.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // inBDMH
            // 
            this.inBDMH.Caption = "Bảng điểm môn học";
            this.inBDMH.Id = 6;
            this.inBDMH.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.Whitelisting_Services;
            this.inBDMH.LargeWidth = 80;
            this.inBDMH.Name = "inBDMH";
            this.inBDMH.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.inBDMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // inPhieuDiem
            // 
            this.inPhieuDiem.Caption = "Phiếu điểm";
            this.inPhieuDiem.Id = 7;
            this.inPhieuDiem.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.Whitelisting_Services;
            this.inPhieuDiem.LargeWidth = 80;
            this.inPhieuDiem.Name = "inPhieuDiem";
            this.inPhieuDiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.inPhieuDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // inHocPhi
            // 
            this.inHocPhi.Caption = "Danh sách đóng học phí của lớp";
            this.inHocPhi.Id = 8;
            this.inHocPhi.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.Whitelisting_Services;
            this.inHocPhi.LargeWidth = 100;
            this.inHocPhi.Name = "inHocPhi";
            this.inHocPhi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.inHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.inHocPhi_ItemClick);
            // 
            // inBDTK
            // 
            this.inBDTK.Caption = "Bảng điểm tổng kết";
            this.inBDTK.Id = 9;
            this.inBDTK.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.Whitelisting_Services;
            this.inBDTK.LargeWidth = 80;
            this.inBDTK.Name = "inBDTK";
            this.inBDTK.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // registerBtn
            // 
            this.registerBtn.Caption = "Tạo tài khoản";
            this.registerBtn.Id = 10;
            this.registerBtn.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("registerBtn.ImageOptions.SvgImage")));
            this.registerBtn.LargeWidth = 65;
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.registerBtn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.registerBtn_ItemClick);
            // 
            // barButtonItem9
            // 
            this.barButtonItem9.Caption = "Danh sách";
            this.barButtonItem9.Id = 11;
            this.barButtonItem9.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem9.ImageOptions.SvgImage")));
            this.barButtonItem9.LargeWidth = 80;
            this.barButtonItem9.Name = "barButtonItem9";
            // 
            // barButtonItem10
            // 
            this.barButtonItem10.Caption = "Môn Học";
            this.barButtonItem10.Id = 12;
            this.barButtonItem10.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem10.ImageOptions.SvgImage")));
            this.barButtonItem10.LargeWidth = 80;
            this.barButtonItem10.Name = "barButtonItem10";
            this.barButtonItem10.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem10_ItemClick);
            // 
            // barButtonItem11
            // 
            this.barButtonItem11.Caption = "Học Phí";
            this.barButtonItem11.Id = 13;
            this.barButtonItem11.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem11.ImageOptions.SvgImage")));
            this.barButtonItem11.LargeWidth = 80;
            this.barButtonItem11.Name = "barButtonItem11";
            this.barButtonItem11.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
            // 
            // barButtonItem12
            // 
            this.barButtonItem12.Caption = "Lớp Tín Chỉ";
            this.barButtonItem12.Id = 14;
            this.barButtonItem12.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem12.ImageOptions.SvgImage")));
            this.barButtonItem12.LargeWidth = 80;
            this.barButtonItem12.Name = "barButtonItem12";
            this.barButtonItem12.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem12_ItemClick);
            // 
            // barButtonItem13
            // 
            this.barButtonItem13.Caption = "Sinh Viên";
            this.barButtonItem13.Id = 15;
            this.barButtonItem13.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem13.ImageOptions.SvgImage")));
            this.barButtonItem13.LargeWidth = 80;
            this.barButtonItem13.Name = "barButtonItem13";
            this.barButtonItem13.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem13_ItemClick);
            // 
            // barButtonItem14
            // 
            this.barButtonItem14.Caption = "Điểm";
            this.barButtonItem14.Id = 16;
            this.barButtonItem14.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem14.ImageOptions.SvgImage")));
            this.barButtonItem14.LargeWidth = 80;
            this.barButtonItem14.Name = "barButtonItem14";
            this.barButtonItem14.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem14_ItemClick);
            // 
            // barButtonItem15
            // 
            this.barButtonItem15.Caption = "Lớp";
            this.barButtonItem15.Id = 17;
            this.barButtonItem15.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem15.ImageOptions.SvgImage")));
            this.barButtonItem15.LargeWidth = 80;
            this.barButtonItem15.Name = "barButtonItem15";
            this.barButtonItem15.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem15.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem15_ItemClick);
            // 
            // barButtonItem16
            // 
            this.barButtonItem16.Caption = "Đăng ký lớp tín chỉ";
            this.barButtonItem16.Id = 18;
            this.barButtonItem16.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem16.ImageOptions.SvgImage")));
            this.barButtonItem16.Name = "barButtonItem16";
            this.barButtonItem16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barButtonItem16.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem16_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.usersGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ Thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.loginBtn);
            this.ribbonPageGroup1.ItemLinks.Add(this.logoutBtn);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Hệ thống";
            // 
            // usersGroup
            // 
            this.usersGroup.ItemLinks.Add(this.registerBtn);
            this.usersGroup.ItemLinks.Add(this.barButtonItem9);
            this.usersGroup.Name = "usersGroup";
            this.usersGroup.Text = "Users";
            this.usersGroup.Visible = false;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.quanLyPageGroup,
            this.hocPhiPageGroup,
            this.dangKyPageGroup});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản Trị";
            // 
            // quanLyPageGroup
            // 
            this.quanLyPageGroup.ItemLinks.Add(this.barButtonItem10);
            this.quanLyPageGroup.ItemLinks.Add(this.barButtonItem15);
            this.quanLyPageGroup.ItemLinks.Add(this.barButtonItem12);
            this.quanLyPageGroup.ItemLinks.Add(this.barButtonItem13);
            this.quanLyPageGroup.ItemLinks.Add(this.barButtonItem14);
            this.quanLyPageGroup.Name = "quanLyPageGroup";
            this.quanLyPageGroup.Text = "Quản lý";
            // 
            // hocPhiPageGroup
            // 
            this.hocPhiPageGroup.ItemLinks.Add(this.barButtonItem11);
            this.hocPhiPageGroup.Name = "hocPhiPageGroup";
            this.hocPhiPageGroup.Text = "Chi Phí";
            // 
            // dangKyPageGroup
            // 
            this.dangKyPageGroup.ItemLinks.Add(this.barButtonItem16);
            this.dangKyPageGroup.Name = "dangKyPageGroup";
            this.dangKyPageGroup.Text = "Đăng ký";
            // 
            // baoCaoPage
            // 
            this.baoCaoPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.baoCaoPage.Name = "baoCaoPage";
            this.baoCaoPage.Text = "Báo Cáo";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.InDSSVBtn);
            this.ribbonPageGroup3.ItemLinks.Add(this.inDSL);
            this.ribbonPageGroup3.ItemLinks.Add(this.inBDMH);
            this.ribbonPageGroup3.ItemLinks.Add(this.inPhieuDiem);
            this.ribbonPageGroup3.ItemLinks.Add(this.inHocPhi);
            this.ribbonPageGroup3.ItemLinks.Add(this.inBDTK);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "In ấn";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danh sách sinh viên";
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Danh sách sinh viên";
            this.barButtonItem2.Id = 4;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1056, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(26, 17);
            this.toolStripStatusLabel3.Text = "MA";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel2.Text = "HOTEN";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "NHOM";
            // 
            // barButtonItem8
            // 
            this.barButtonItem8.Caption = "Đăng nhập";
            this.barButtonItem8.Enabled = false;
            this.barButtonItem8.Id = 1;
            this.barButtonItem8.ImageOptions.Image = global::QLDSV_HTC.Properties.Resources.login;
            this.barButtonItem8.Name = "barButtonItem8";
            this.barButtonItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbonControl1;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 651);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý điểm sinh viên theo hệ tín chỉ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup quanLyPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonPage baoCaoPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem loginBtn;
        private DevExpress.XtraBars.BarButtonItem logoutBtn;
        private DevExpress.XtraBars.BarButtonItem InDSSVBtn;
        private DevExpress.XtraBars.BarButtonItem inDSL;
        private DevExpress.XtraBars.BarButtonItem inBDMH;
        private DevExpress.XtraBars.BarButtonItem inHocPhi;
        private DevExpress.XtraBars.BarButtonItem inBDTK;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem inPhieuDiem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private DevExpress.XtraBars.BarButtonItem registerBtn;
        private DevExpress.XtraBars.BarButtonItem barButtonItem8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup usersGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem10;
        private DevExpress.XtraBars.BarButtonItem barButtonItem11;
        private DevExpress.XtraBars.BarButtonItem barButtonItem12;
        private DevExpress.XtraBars.BarButtonItem barButtonItem13;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup hocPhiPageGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem14;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup dangKyPageGroup;
        private DevExpress.XtraBars.BarButtonItem barButtonItem15;
        private DevExpress.XtraBars.BarButtonItem barButtonItem16;
    }
}

