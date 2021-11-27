
namespace QLDSV_HTC.Forms
{
    partial class AddLoginForm
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.createLogin = new DevExpress.XtraEditors.SimpleButton();
            this.passTxt = new DevExpress.XtraEditors.TextEdit();
            this.userIdTxt = new DevExpress.XtraEditors.TextEdit();
            this.userNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.roleList = new System.Windows.Forms.ComboBox();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(356, 273);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.createLogin);
            this.layoutControl1.Controls.Add(this.passTxt);
            this.layoutControl1.Controls.Add(this.userIdTxt);
            this.layoutControl1.Controls.Add(this.userNameTxt);
            this.layoutControl1.Controls.Add(this.roleList);
            this.layoutControl1.Controls.Add(this.cmbKhoa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(352, 269);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // createLogin
            // 
            this.createLogin.Location = new System.Drawing.Point(12, 134);
            this.createLogin.Name = "createLogin";
            this.createLogin.Size = new System.Drawing.Size(328, 22);
            this.createLogin.StyleController = this.layoutControl1;
            this.createLogin.TabIndex = 8;
            this.createLogin.Text = "Tạo Tài Khoản";
            this.createLogin.Click += new System.EventHandler(this.createLogin_Click);
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(67, 110);
            this.passTxt.Name = "passTxt";
            this.passTxt.Properties.PasswordChar = '*';
            this.passTxt.Size = new System.Drawing.Size(273, 20);
            this.passTxt.StyleController = this.layoutControl1;
            this.passTxt.TabIndex = 7;
            // 
            // userIdTxt
            // 
            this.userIdTxt.Location = new System.Drawing.Point(67, 86);
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Properties.Mask.EditMask = "(\\p{Lu}|[0-9])+";
            this.userIdTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.userIdTxt.Properties.MaxLength = 10;
            this.userIdTxt.Size = new System.Drawing.Size(273, 20);
            this.userIdTxt.StyleController = this.layoutControl1;
            this.userIdTxt.TabIndex = 6;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(67, 62);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Properties.Mask.EditMask = "(\\p{Lu}|[0-9])+";
            this.userNameTxt.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.userNameTxt.Size = new System.Drawing.Size(273, 20);
            this.userNameTxt.StyleController = this.layoutControl1;
            this.userNameTxt.TabIndex = 5;
            // 
            // roleList
            // 
            this.roleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleList.FormattingEnabled = true;
            this.roleList.Location = new System.Drawing.Point(67, 12);
            this.roleList.Name = "roleList";
            this.roleList.Size = new System.Drawing.Size(273, 21);
            this.roleList.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(352, 269);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.roleList;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(332, 25);
            this.layoutControlItem1.Text = "Chức vụ:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(52, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 148);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(332, 101);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.userNameTxt;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 50);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem2.Text = "Username:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.userIdTxt;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 74);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem3.Text = "UserID:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.passTxt;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 98);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(332, 24);
            this.layoutControlItem4.Text = "Mật khẩu:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.createLogin;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 122);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(332, 26);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(67, 37);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(273, 21);
            this.cmbKhoa.TabIndex = 4;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.cmbKhoa;
            this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.layoutControlItem6.CustomizationFormText = "Chức vụ:";
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(332, 25);
            this.layoutControlItem6.Text = "Khoa:";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(52, 13);
            // 
            // AddLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 273);
            this.Controls.Add(this.panelControl1);
            this.Name = "AddLoginForm";
            this.Text = "Tạo tài khoản login";
            this.Load += new System.EventHandler(this.AddLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIdTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private System.Windows.Forms.ComboBox roleList;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.TextEdit passTxt;
        private DevExpress.XtraEditors.TextEdit userIdTxt;
        private DevExpress.XtraEditors.TextEdit userNameTxt;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.SimpleButton createLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}