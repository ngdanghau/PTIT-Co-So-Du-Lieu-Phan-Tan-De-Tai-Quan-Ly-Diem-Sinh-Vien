
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
            this.components = new System.ComponentModel.Container();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.simpleButton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 50);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Niên khóa: ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(250, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Học kỳ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(35, 12);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Khoa: ";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(72, 9);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(316, 21);
            this.cmbKhoa.TabIndex = 3;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(72, 47);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Properties.Mask.EditMask = "\\d{4}-\\d{4}";
            this.txtNienKhoa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNienKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtNienKhoa.TabIndex = 4;
            // 
            // txtHocKy
            // 
            this.txtHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKy.Location = new System.Drawing.Point(288, 47);
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtHocKy.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.txtHocKy.Properties.IsFloatValue = false;
            this.txtHocKy.Properties.Mask.EditMask = "N00";
            this.txtHocKy.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtHocKy.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.txtHocKy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKy.Size = new System.Drawing.Size(100, 20);
            this.txtHocKy.TabIndex = 5;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(181, 88);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "In";
            this.simpleButton1.UseVisualStyleBackColor = true;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // InDSLOPTINCHI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 261);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtNienKhoa);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtHocKy);
            this.Name = "InDSLOPTINCHI";
            this.Text = "In danh sách lớp tín chỉ";
            this.Load += new System.EventHandler(this.InDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraEditors.SpinEdit txtHocKy;
        private System.Windows.Forms.Button simpleButton1;
    }
}