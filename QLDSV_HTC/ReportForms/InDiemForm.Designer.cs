
namespace QLDSV_HTC.ReportForms
{
    partial class InDiemForm
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
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_Nhom = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_MH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_HK = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_NK = new DevExpress.XtraEditors.TextEdit();
            this.button_preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Nhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(212, 47);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Nhóm:";
            // 
            // textEdit_Nhom
            // 
            this.textEdit_Nhom.Location = new System.Drawing.Point(253, 44);
            this.textEdit_Nhom.Name = "textEdit_Nhom";
            this.textEdit_Nhom.Size = new System.Drawing.Size(100, 20);
            this.textEdit_Nhom.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(199, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Môn học:";
            // 
            // textEdit_MH
            // 
            this.textEdit_MH.Location = new System.Drawing.Point(253, 12);
            this.textEdit_MH.Name = "textEdit_MH";
            this.textEdit_MH.Size = new System.Drawing.Size(100, 20);
            this.textEdit_MH.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 47);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Học kì: ";
            // 
            // textEdit_HK
            // 
            this.textEdit_HK.Location = new System.Drawing.Point(65, 44);
            this.textEdit_HK.Name = "textEdit_HK";
            this.textEdit_HK.Size = new System.Drawing.Size(100, 20);
            this.textEdit_HK.TabIndex = 13;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Niên khóa: ";
            this.labelControl1.Click += new System.EventHandler(this.labelControl1_Click);
            // 
            // textEdit_NK
            // 
            this.textEdit_NK.Location = new System.Drawing.Point(65, 12);
            this.textEdit_NK.Name = "textEdit_NK";
            this.textEdit_NK.Size = new System.Drawing.Size(100, 20);
            this.textEdit_NK.TabIndex = 11;
            this.textEdit_NK.EditValueChanged += new System.EventHandler(this.textEdit_NK_EditValueChanged);
            // 
            // button_preview
            // 
            this.button_preview.Location = new System.Drawing.Point(95, 89);
            this.button_preview.Name = "button_preview";
            this.button_preview.Size = new System.Drawing.Size(177, 35);
            this.button_preview.TabIndex = 10;
            this.button_preview.Text = "Preview";
            this.button_preview.UseVisualStyleBackColor = true;
            this.button_preview.Click += new System.EventHandler(this.button_preview_Click);
            // 
            // InDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 268);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.textEdit_Nhom);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textEdit_MH);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.textEdit_HK);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit_NK);
            this.Controls.Add(this.button_preview);
            this.Name = "InDiemForm";
            this.Text = "InDiemForm";
            this.Load += new System.EventHandler(this.InDiemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Nhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit_Nhom;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit textEdit_MH;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEdit_HK;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_NK;
        private System.Windows.Forms.Button button_preview;
    }
}