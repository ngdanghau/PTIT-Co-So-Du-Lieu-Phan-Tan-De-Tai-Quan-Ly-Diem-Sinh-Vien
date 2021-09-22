
namespace QLDSV_HTC.ReportForms
{
    partial class InDSDongHPForm
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
            this.lookUpEdit_MH = new DevExpress.XtraEditors.LookUpEdit();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_HTC.DS();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_NK = new DevExpress.XtraEditors.TextEdit();
            this.button_preview = new System.Windows.Forms.Button();
            this.mONHOCTableAdapter = new QLDSV_HTC.DSTableAdapters.MONHOCTableAdapter();
            this.textEdit_HK = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_MH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lookUpEdit_MH
            // 
            this.lookUpEdit_MH.Location = new System.Drawing.Point(72, 12);
            this.lookUpEdit_MH.Name = "lookUpEdit_MH";
            this.lookUpEdit_MH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_MH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAMH", "MAMH", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENMH", "TENMH", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SOTIET_LT", "SOTIET_LT", 63, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("SOTIET_TH", "SOTIET_TH", 65, DevExpress.Utils.FormatType.Numeric, "", true, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit_MH.Properties.DataSource = this.mONHOCBindingSource;
            this.lookUpEdit_MH.Properties.DisplayMember = "MAMH";
            this.lookUpEdit_MH.Properties.NullText = "";
            this.lookUpEdit_MH.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.lookUpEdit_MH.Properties.ValueMember = "MAMH";
            this.lookUpEdit_MH.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit_MH.TabIndex = 33;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(22, 15);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 13);
            this.labelControl4.TabIndex = 28;
            this.labelControl4.Text = "Mã lớp:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(31, 44);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 27;
            this.labelControl2.Text = "Học kì: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(192, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 25;
            this.labelControl1.Text = "Niên khóa: ";
            // 
            // textEdit_NK
            // 
            this.textEdit_NK.Location = new System.Drawing.Point(252, 12);
            this.textEdit_NK.Name = "textEdit_NK";
            this.textEdit_NK.Properties.Mask.EditMask = "\\d{4}-\\d{4}";
            this.textEdit_NK.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEdit_NK.Size = new System.Drawing.Size(100, 20);
            this.textEdit_NK.TabIndex = 24;
            // 
            // button_preview
            // 
            this.button_preview.Location = new System.Drawing.Point(143, 97);
            this.button_preview.Name = "button_preview";
            this.button_preview.Size = new System.Drawing.Size(103, 35);
            this.button_preview.TabIndex = 23;
            this.button_preview.Text = "In";
            this.button_preview.UseVisualStyleBackColor = true;
            this.button_preview.Click += new System.EventHandler(this.button_preview_Click);
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // textEdit_HK
            // 
            this.textEdit_HK.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit_HK.Location = new System.Drawing.Point(72, 41);
            this.textEdit_HK.Name = "textEdit_HK";
            this.textEdit_HK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit_HK.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit_HK.Properties.IsFloatValue = false;
            this.textEdit_HK.Properties.Mask.EditMask = "N00";
            this.textEdit_HK.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit_HK.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.textEdit_HK.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit_HK.Size = new System.Drawing.Size(100, 20);
            this.textEdit_HK.TabIndex = 26;
            // 
            // InDSDongHPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 155);
            this.Controls.Add(this.lookUpEdit_MH);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit_NK);
            this.Controls.Add(this.button_preview);
            this.Controls.Add(this.textEdit_HK);
            this.Name = "InDSDongHPForm";
            this.Text = "In danh sách đóng học phí";
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_MH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HK.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_MH;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DS dS;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_NK;
        private System.Windows.Forms.Button button_preview;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.SpinEdit textEdit_HK;
    }
}