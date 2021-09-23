
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
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MSSV.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(9, 45);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 15;
            this.labelControl1.Text = "MSSV: ";
            // 
            // textEdit_MSSV
            // 
            this.textEdit_MSSV.Location = new System.Drawing.Point(48, 42);
            this.textEdit_MSSV.Name = "textEdit_MSSV";
            this.textEdit_MSSV.Properties.Mask.EditMask = "(\\p{Lu}|[0-9])+";
            this.textEdit_MSSV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEdit_MSSV.Size = new System.Drawing.Size(225, 20);
            this.textEdit_MSSV.TabIndex = 14;
            this.textEdit_MSSV.EditValueChanged += new System.EventHandler(this.textEdit_NK_EditValueChanged);
            // 
            // button_preview
            // 
            this.button_preview.Location = new System.Drawing.Point(114, 84);
            this.button_preview.Name = "button_preview";
            this.button_preview.Size = new System.Drawing.Size(76, 35);
            this.button_preview.TabIndex = 13;
            this.button_preview.Text = "In";
            this.button_preview.UseVisualStyleBackColor = true;
            this.button_preview.Click += new System.EventHandler(this.button_preview_Click);
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(48, 6);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(224, 21);
            this.cmbKhoa.TabIndex = 17;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(11, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Khoa: ";
            // 
            // InPhieuDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit_MSSV);
            this.Controls.Add(this.button_preview);
            this.Name = "InPhieuDiemForm";
            this.Text = "In phiếu điểm";
            this.Load += new System.EventHandler(this.InPhieuDiemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_MSSV.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_MSSV;
        private System.Windows.Forms.Button button_preview;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}