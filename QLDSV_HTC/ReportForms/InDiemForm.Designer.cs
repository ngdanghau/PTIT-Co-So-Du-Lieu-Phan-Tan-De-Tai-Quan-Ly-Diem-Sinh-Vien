
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
            this.components = new System.ComponentModel.Container();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit_NK = new DevExpress.XtraEditors.TextEdit();
            this.button_preview = new System.Windows.Forms.Button();
            this.comboBox_Khoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpEdit_MH = new DevExpress.XtraEditors.LookUpEdit();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_HTC.DS();
            this.mONHOCTableAdapter = new QLDSV_HTC.DSTableAdapters.MONHOCTableAdapter();
            this.textEdit_HK = new DevExpress.XtraEditors.SpinEdit();
            this.textEdit_Nhom = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_MH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Nhom.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(217, 91);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Nhóm:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(204, 59);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(44, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Môn học:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(29, 91);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(35, 13);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Học kì: ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 59);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Niên khóa: ";
            // 
            // textEdit_NK
            // 
            this.textEdit_NK.Location = new System.Drawing.Point(70, 56);
            this.textEdit_NK.Name = "textEdit_NK";
            this.textEdit_NK.Properties.Mask.EditMask = "\\d{4}-\\d{4}";
            this.textEdit_NK.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.textEdit_NK.Size = new System.Drawing.Size(100, 20);
            this.textEdit_NK.TabIndex = 11;
            // 
            // button_preview
            // 
            this.button_preview.Location = new System.Drawing.Point(156, 133);
            this.button_preview.Name = "button_preview";
            this.button_preview.Size = new System.Drawing.Size(70, 35);
            this.button_preview.TabIndex = 10;
            this.button_preview.Text = "In";
            this.button_preview.UseVisualStyleBackColor = true;
            this.button_preview.Click += new System.EventHandler(this.button_preview_Click);
            // 
            // comboBox_Khoa
            // 
            this.comboBox_Khoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Khoa.FormattingEnabled = true;
            this.comboBox_Khoa.Location = new System.Drawing.Point(70, 17);
            this.comboBox_Khoa.Name = "comboBox_Khoa";
            this.comboBox_Khoa.Size = new System.Drawing.Size(288, 21);
            this.comboBox_Khoa.TabIndex = 19;
            this.comboBox_Khoa.SelectedIndexChanged += new System.EventHandler(this.comboBox_Khoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Khoa:";
            // 
            // lookUpEdit_MH
            // 
            this.lookUpEdit_MH.Location = new System.Drawing.Point(254, 56);
            this.lookUpEdit_MH.Name = "lookUpEdit_MH";
            this.lookUpEdit_MH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit_MH.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("MAMH", "MAMH", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("TENMH", "TENMH", 44, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit_MH.Properties.DataSource = this.mONHOCBindingSource;
            this.lookUpEdit_MH.Properties.DisplayMember = "MAMH";
            this.lookUpEdit_MH.Properties.NullText = "";
            this.lookUpEdit_MH.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSuggest;
            this.lookUpEdit_MH.Properties.ValueMember = "MAMH";
            this.lookUpEdit_MH.Size = new System.Drawing.Size(100, 20);
            this.lookUpEdit_MH.TabIndex = 22;
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
            this.textEdit_HK.Location = new System.Drawing.Point(70, 88);
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
            this.textEdit_HK.TabIndex = 13;
            // 
            // textEdit_Nhom
            // 
            this.textEdit_Nhom.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit_Nhom.Location = new System.Drawing.Point(254, 88);
            this.textEdit_Nhom.Name = "textEdit_Nhom";
            this.textEdit_Nhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.textEdit_Nhom.Properties.EditValueChangedFiringMode = DevExpress.XtraEditors.Controls.EditValueChangedFiringMode.Default;
            this.textEdit_Nhom.Properties.IsFloatValue = false;
            this.textEdit_Nhom.Properties.Mask.EditMask = "N00";
            this.textEdit_Nhom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.textEdit_Nhom.Properties.MaxValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit_Nhom.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.textEdit_Nhom.Size = new System.Drawing.Size(100, 20);
            this.textEdit_Nhom.TabIndex = 17;
            // 
            // InDiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 268);
            this.Controls.Add(this.lookUpEdit_MH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Khoa);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textEdit_NK);
            this.Controls.Add(this.button_preview);
            this.Controls.Add(this.textEdit_HK);
            this.Controls.Add(this.textEdit_Nhom);
            this.Name = "InDiemForm";
            this.Text = "In bảng điểm môn học";
            this.Load += new System.EventHandler(this.InDiemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_NK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit_MH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_HK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit_Nhom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEdit_NK;
        private System.Windows.Forms.Button button_preview;
        private System.Windows.Forms.ComboBox comboBox_Khoa;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit_MH;
        private DS dS;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private DSTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraEditors.SpinEdit textEdit_HK;
        private DevExpress.XtraEditors.SpinEdit textEdit_Nhom;
    }
}