
namespace QLDSV_HTC.ReportForms
{
    partial class InPhieuDiemForm
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_MSSV = new DevExpress.XtraEditors.TextEdit();
            this.button_preview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MSSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "MSSV: ";
            // 
            // textEdit_MSSV
            // 
            this.textEdit_MSSV.Location = new System.Drawing.Point(49, 23);
            this.textEdit_MSSV.Name = "textEdit_MSSV";
            this.textEdit_MSSV.Size = new System.Drawing.Size(100, 20);
            this.textEdit_MSSV.TabIndex = 14;
            this.textEdit_MSSV.EditValueChanged += new System.EventHandler(this.textEdit_NK_EditValueChanged);
            // 
            // button_preview
            // 
            this.button_preview.Location = new System.Drawing.Point(109, 85);
            this.button_preview.Name = "button_preview";
            this.button_preview.Size = new System.Drawing.Size(76, 35);
            this.button_preview.TabIndex = 13;
            this.button_preview.Text = "Preview";
            this.button_preview.UseVisualStyleBackColor = true;
            this.button_preview.Click += new System.EventHandler(this.button_preview_Click);
            // 
            // InPhieuDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit_MSSV);
            this.Controls.Add(this.button_preview);
            this.Name = "InPhieuDiemForm";
            this.Text = "InPhieuDiemForm";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MSSV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_MSSV;
        private System.Windows.Forms.Button button_preview;
    }
}