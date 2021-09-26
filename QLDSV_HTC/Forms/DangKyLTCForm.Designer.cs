
namespace QLDSV_HTC.Forms
{
    partial class DangKyLTCForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelLop = new DevExpress.XtraEditors.LabelControl();
            this.labelHoTen = new DevExpress.XtraEditors.LabelControl();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaSV = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.txtHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.DS = new QLDSV_HTC.DS();
            this.sp_LayDSLopTinChiDeDangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_LayDSLopTinChiDeDangKyTableAdapter = new QLDSV_HTC.DSTableAdapters.sp_LayDSLopTinChiDeDangKyTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.sp_LayDSLopTinChiDeDangKyGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVDK = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDeDangKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDeDangKyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txtMaSV);
            this.groupControl1.Controls.Add(this.labelLop);
            this.groupControl1.Controls.Add(this.btnLogin);
            this.groupControl1.Controls.Add(this.labelHoTen);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(936, 54);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin sinh viên";
            // 
            // labelLop
            // 
            this.labelLop.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelLop.Location = new System.Drawing.Point(437, 30);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(63, 13);
            this.labelLop.TabIndex = 4;
            this.labelLop.Text = "labelControl3";
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelHoTen.Location = new System.Drawing.Point(257, 30);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(63, 13);
            this.labelHoTen.TabIndex = 3;
            this.labelHoTen.Text = "labelControl2";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(162, 25);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(89, 22);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtMaSV
            // 
            this.txtMaSV.Location = new System.Drawing.Point(70, 26);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Properties.Mask.EditMask = "(\\p{Lu}|[0-9])+";
            this.txtMaSV.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtMaSV.Properties.MaxLength = 10;
            this.txtMaSV.Size = new System.Drawing.Size(86, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 30);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã sinh viên";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Controls.Add(this.sp_LayDSLopTinChiDeDangKyGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 54);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(936, 478);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách môn học";
            // 
            // groupControl3
            // 
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 532);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(936, 127);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Danh sách môn học đã chọn";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(179, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Học kì: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Niên khóa: ";
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(70, 5);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Properties.Mask.EditMask = "\\d{4}-\\d{4}";
            this.txtNienKhoa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNienKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtNienKhoa.TabIndex = 15;
            // 
            // txtHocKy
            // 
            this.txtHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtHocKy.Location = new System.Drawing.Point(220, 5);
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
            this.txtHocKy.Size = new System.Drawing.Size(43, 20);
            this.txtHocKy.TabIndex = 17;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(278, 3);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(57, 22);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_LayDSLopTinChiDeDangKyBindingSource
            // 
            this.sp_LayDSLopTinChiDeDangKyBindingSource.DataMember = "sp_LayDSLopTinChiDeDangKy";
            this.sp_LayDSLopTinChiDeDangKyBindingSource.DataSource = this.DS;
            // 
            // sp_LayDSLopTinChiDeDangKyTableAdapter
            // 
            this.sp_LayDSLopTinChiDeDangKyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.sp_GetBangDiemMonHocTableAdapter = null;
            this.tableAdapterManager.sp_GetThongTinDongHocPhiTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sp_LayDSLopTinChiDeDangKyGridControl
            // 
            this.sp_LayDSLopTinChiDeDangKyGridControl.DataSource = this.sp_LayDSLopTinChiDeDangKyBindingSource;
            this.sp_LayDSLopTinChiDeDangKyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_LayDSLopTinChiDeDangKyGridControl.Location = new System.Drawing.Point(2, 23);
            this.sp_LayDSLopTinChiDeDangKyGridControl.MainView = this.gridView1;
            this.sp_LayDSLopTinChiDeDangKyGridControl.Name = "sp_LayDSLopTinChiDeDangKyGridControl";
            this.sp_LayDSLopTinChiDeDangKyGridControl.Size = new System.Drawing.Size(932, 453);
            this.sp_LayDSLopTinChiDeDangKyGridControl.TabIndex = 18;
            this.sp_LayDSLopTinChiDeDangKyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colHOTEN,
            this.colSOSVDK});
            this.gridView1.GridControl = this.sp_LayDSLopTinChiDeDangKyGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.txtHocKy);
            this.panelControl1.Controls.Add(this.txtNienKhoa);
            this.panelControl1.Controls.Add(this.btnFilter);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(2, 23);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(932, 29);
            this.panelControl1.TabIndex = 19;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.AllowFocus = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 0;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ tên GV";
            this.colHOTEN.FieldName = "HO TEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.OptionsColumn.AllowFocus = false;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.OptionsColumn.AllowFocus = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 2;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.AllowEdit = false;
            this.colNHOM.OptionsColumn.AllowFocus = false;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 3;
            // 
            // colSOSVDK
            // 
            this.colSOSVDK.Caption = "Số SV đăng ký";
            this.colSOSVDK.FieldName = "SOSVDK";
            this.colSOSVDK.Name = "colSOSVDK";
            this.colSOSVDK.OptionsColumn.AllowEdit = false;
            this.colSOSVDK.OptionsColumn.AllowFocus = false;
            this.colSOSVDK.Visible = true;
            this.colSOSVDK.VisibleIndex = 4;
            // 
            // DangKyLTCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 659);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "DangKyLTCForm";
            this.Text = "Đăng ký lớp tín chỉ";
            this.Load += new System.EventHandler(this.DangKyLTCForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaSV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDeDangKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDeDangKyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.XtraEditors.TextEdit txtMaSV;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelLop;
        private DevExpress.XtraEditors.LabelControl labelHoTen;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraEditors.SpinEdit txtHocKy;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DS DS;
        private System.Windows.Forms.BindingSource sp_LayDSLopTinChiDeDangKyBindingSource;
        private DSTableAdapters.sp_LayDSLopTinChiDeDangKyTableAdapter sp_LayDSLopTinChiDeDangKyTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sp_LayDSLopTinChiDeDangKyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVDK;
    }
}