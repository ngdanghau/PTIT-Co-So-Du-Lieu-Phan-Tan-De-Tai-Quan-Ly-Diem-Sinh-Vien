
namespace QLDSV_HTC.ReportForms
{
    partial class InDSLOPTINCHI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InDSLOPTINCHI));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.cmbKhoa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtHocKy = new DevExpress.XtraEditors.TextEdit();
            this.Button_Preview = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.layoutControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(575, 261);
            this.panelControl1.TabIndex = 0;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.cmbKhoa);
            this.layoutControl1.Controls.Add(this.txtNienKhoa);
            this.layoutControl1.Controls.Add(this.txtHocKy);
            this.layoutControl1.Controls.Add(this.Button_Preview);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(571, 257);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.Location = new System.Drawing.Point(66, 12);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbKhoa.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbKhoa.Size = new System.Drawing.Size(493, 20);
            this.cmbKhoa.StyleController = this.layoutControl1;
            this.cmbKhoa.TabIndex = 4;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(66, 36);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(493, 20);
            this.txtNienKhoa.StyleController = this.layoutControl1;
            this.txtNienKhoa.TabIndex = 5;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(66, 60);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Size = new System.Drawing.Size(493, 20);
            this.txtHocKy.StyleController = this.layoutControl1;
            this.txtHocKy.TabIndex = 6;
            // 
            // Button_Preview
            // 
            this.Button_Preview.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.Button_Preview.Location = new System.Drawing.Point(12, 84);
            this.Button_Preview.Name = "Button_Preview";
            this.Button_Preview.Size = new System.Drawing.Size(547, 36);
            this.Button_Preview.StyleController = this.layoutControl1;
            this.Button_Preview.TabIndex = 7;
            this.Button_Preview.Text = "Xem trước";
            this.Button_Preview.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(571, 257);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.cmbKhoa;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(551, 24);
            this.layoutControlItem1.Text = "Khoa: ";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtNienKhoa;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(551, 24);
            this.layoutControlItem2.Text = "Niên khóa:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtHocKy;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(551, 24);
            this.layoutControlItem3.Text = "Học kỳ:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.Button_Preview;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(551, 165);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // InDSLOPTINCHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 261);
            this.Controls.Add(this.panelControl1);
            this.Name = "InDSLOPTINCHI";
            this.Text = "In danh sách lớp tín chỉ";
            this.Load += new System.EventHandler(this.InDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cmbKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbKhoa;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraEditors.TextEdit txtHocKy;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton Button_Preview;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}