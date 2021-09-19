
namespace QLDSV_HTC.ReportForms
{
    partial class InDSSV
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
            this.textEdit_NK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_HK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_Nhom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_MH = new DevExpress.XtraEditors.TextEdit();
            this.button_preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Nhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit_NK
            // 
            this.textEdit_NK.Location = new System.Drawing.Point(72, 20);
            this.textEdit_NK.Name = "textEdit_NK";
            this.textEdit_NK.Size = new System.Drawing.Size(100, 20);
            this.textEdit_NK.TabIndex = 2;
            this.textEdit_NK.EditValueChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 23);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Niên khóa: ";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Học kì: ";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // textEdit_HK
            // 
            this.textEdit_HK.Location = new System.Drawing.Point(72, 52);
            this.textEdit_HK.Name = "textEdit_HK";
            this.textEdit_HK.Size = new System.Drawing.Size(100, 20);
            this.textEdit_HK.TabIndex = 4;
            this.textEdit_HK.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(219, 55);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 9;
            this.labelControl3.Text = "Nhóm:";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // textEdit_Nhom
            // 
            this.textEdit_Nhom.Location = new System.Drawing.Point(260, 52);
            this.textEdit_Nhom.Name = "textEdit_Nhom";
            this.textEdit_Nhom.Size = new System.Drawing.Size(100, 20);
            this.textEdit_Nhom.TabIndex = 8;
            this.textEdit_Nhom.EditValueChanged += new System.EventHandler(this.textEdit_Nhom_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(206, 23);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Môn học:";
            this.labelControl4.Click += new System.EventHandler(this.labelControl4_Click);
            // 
            // textEdit_MH
            // 
            this.textEdit_MH.Location = new System.Drawing.Point(260, 20);
            this.textEdit_MH.Name = "textEdit_MH";
            this.textEdit_MH.Size = new System.Drawing.Size(100, 20);
            this.textEdit_MH.TabIndex = 6;
            this.textEdit_MH.EditValueChanged += new System.EventHandler(this.textEdit_MH_EditValueChanged);
            // 
            // button_preview
            // 
            this.button_preview.Location = new System.Drawing.Point(102, 97);
            this.button_preview.Name = "button_preview";
            this.button_preview.Size = new System.Drawing.Size(177, 35);
            this.button_preview.TabIndex = 1;
            this.button_preview.Text = "Preview";
            this.button_preview.UseVisualStyleBackColor = true;
            this.button_preview.Click += new System.EventHandler(this.ButtonPreviewclick);
            // 
            // InDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 313);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEdit_Nhom);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEdit_MH);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit_HK);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit_NK);
            this.Controls.Add(this.button_preview);
            this.Name = "InDSSV";
            this.Text = "InDSSV";
            this.Load += new System.EventHandler(this.InDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Nhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MH.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_preview;
        private DevExpress.XtraEditors.TextEdit textEdit_NK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_HK;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit_Nhom;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit_MH;
    }
}