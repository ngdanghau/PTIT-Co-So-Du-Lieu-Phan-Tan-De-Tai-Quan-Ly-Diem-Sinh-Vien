
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
            DevExpress.Utils.AppearanceObject appearanceObject2 = new DevExpress.Utils.AppearanceObject();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.btnFilter = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sp_LayDSLopTinChiDeDangKyGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONGCL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.sp_LayDSLopTinChiDaDangKyGridControl = new DevExpress.XtraGrid.GridControl();
            this.sp_LayDSLopTinChiDaDangKyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLDSV_HTC.DS();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTENMH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnXoaDangKy = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.disabledCellEvents1 = new DevExpress.Utils.Behaviors.Common.DisabledCellEvents(this.components);
            this.sp_LayDSLopTinChiDaDangKyTableAdapter = new QLDSV_HTC.DSTableAdapters.sp_LayDSLopTinChiDaDangKyTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDeDangKyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDaDangKyGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDaDangKyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Controls.Add(this.sp_LayDSLopTinChiDeDangKyGridControl);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(936, 295);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Danh sách môn học";
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
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(70, 5);
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Properties.Mask.EditMask = "\\d{4}-\\d{4}";
            this.txtNienKhoa.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txtNienKhoa.Size = new System.Drawing.Size(100, 20);
            this.txtNienKhoa.TabIndex = 15;
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
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(10, 8);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 13);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "Niên khóa: ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(179, 8);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(35, 13);
            this.labelControl3.TabIndex = 18;
            this.labelControl3.Text = "Học kì: ";
            // 
            // sp_LayDSLopTinChiDeDangKyGridControl
            // 
            this.sp_LayDSLopTinChiDeDangKyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_LayDSLopTinChiDeDangKyGridControl.Location = new System.Drawing.Point(2, 23);
            this.sp_LayDSLopTinChiDeDangKyGridControl.MainView = this.gridView1;
            this.sp_LayDSLopTinChiDeDangKyGridControl.Name = "sp_LayDSLopTinChiDeDangKyGridControl";
            this.sp_LayDSLopTinChiDeDangKyGridControl.Size = new System.Drawing.Size(932, 270);
            this.sp_LayDSLopTinChiDeDangKyGridControl.TabIndex = 18;
            this.sp_LayDSLopTinChiDeDangKyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.behaviorManager1.SetBehaviors(this.gridView1, new DevExpress.Utils.Behaviors.Behavior[] {
            ((DevExpress.Utils.Behaviors.Behavior)(DevExpress.Utils.Behaviors.Common.DisabledCellBehavior.Create(typeof(DevExpress.XtraGrid.Extensions.GridViewDisabledCellSource), "", appearanceObject2, this.disabledCellEvents1)))});
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.colMAMH,
            this.colTENMH,
            this.colNHOM,
            this.colHOTEN,
            this.colSOSVTOITHIEU,
            this.colSOLUONGCL});
            this.gridView1.GridControl = this.sp_LayDSLopTinChiDeDangKyGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "STT";
            this.gridColumn1.FieldName = "STT";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.AllowFocus = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // colMAMH
            // 
            this.colMAMH.Caption = "Mã môn học";
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.OptionsColumn.AllowEdit = false;
            this.colMAMH.OptionsColumn.AllowFocus = false;
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 2;
            // 
            // colTENMH
            // 
            this.colTENMH.Caption = "Tên môn học";
            this.colTENMH.FieldName = "TENMH";
            this.colTENMH.Name = "colTENMH";
            this.colTENMH.OptionsColumn.AllowEdit = false;
            this.colTENMH.OptionsColumn.AllowFocus = false;
            this.colTENMH.Visible = true;
            this.colTENMH.VisibleIndex = 3;
            // 
            // colNHOM
            // 
            this.colNHOM.Caption = "Nhóm";
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.OptionsColumn.AllowEdit = false;
            this.colNHOM.OptionsColumn.AllowFocus = false;
            this.colNHOM.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 5;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ tên GV";
            this.colHOTEN.FieldName = "HO TEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.OptionsColumn.AllowFocus = false;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 4;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.Caption = "Số sinh viên tối thiểu";
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.OptionsColumn.AllowEdit = false;
            this.colSOSVTOITHIEU.OptionsColumn.AllowFocus = false;
            this.colSOSVTOITHIEU.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 6;
            // 
            // colSOLUONGCL
            // 
            this.colSOLUONGCL.Caption = "Số lượng còn lại";
            this.colSOLUONGCL.FieldName = "SOLUONGCL";
            this.colSOLUONGCL.Name = "colSOLUONGCL";
            this.colSOLUONGCL.OptionsColumn.AllowEdit = false;
            this.colSOLUONGCL.OptionsColumn.AllowFocus = false;
            this.colSOLUONGCL.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.colSOLUONGCL.Visible = true;
            this.colSOLUONGCL.VisibleIndex = 7;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.panelControl3);
            this.groupControl3.Controls.Add(this.panelControl2);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 295);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(936, 272);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Danh sách môn học đã chọn";
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.sp_LayDSLopTinChiDaDangKyGridControl);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(2, 56);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(932, 214);
            this.panelControl3.TabIndex = 2;
            // 
            // sp_LayDSLopTinChiDaDangKyGridControl
            // 
            this.sp_LayDSLopTinChiDaDangKyGridControl.DataSource = this.sp_LayDSLopTinChiDaDangKyBindingSource;
            this.sp_LayDSLopTinChiDaDangKyGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_LayDSLopTinChiDaDangKyGridControl.Location = new System.Drawing.Point(2, 2);
            this.sp_LayDSLopTinChiDaDangKyGridControl.MainView = this.gridView2;
            this.sp_LayDSLopTinChiDaDangKyGridControl.Name = "sp_LayDSLopTinChiDaDangKyGridControl";
            this.sp_LayDSLopTinChiDaDangKyGridControl.Size = new System.Drawing.Size(928, 210);
            this.sp_LayDSLopTinChiDaDangKyGridControl.TabIndex = 0;
            this.sp_LayDSLopTinChiDaDangKyGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // sp_LayDSLopTinChiDaDangKyBindingSource
            // 
            this.sp_LayDSLopTinChiDaDangKyBindingSource.DataMember = "sp_LayDSLopTinChiDaDangKy";
            this.sp_LayDSLopTinChiDaDangKyBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSTT,
            this.colMALTC,
            this.colMAMH1,
            this.colTENMH1,
            this.colNHOM1,
            this.colNIENKHOA});
            this.gridView2.GridControl = this.sp_LayDSLopTinChiDaDangKyGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView2.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridView2.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridView2.OptionsSelection.MultiSelect = true;
            this.gridView2.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView2.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView2_SelectionChanged);
            // 
            // colSTT
            // 
            this.colSTT.Caption = "Số thứ tự";
            this.colSTT.FieldName = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.OptionsColumn.AllowEdit = false;
            this.colSTT.OptionsColumn.AllowFocus = false;
            this.colSTT.Visible = true;
            this.colSTT.VisibleIndex = 2;
            // 
            // colMALTC
            // 
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.AllowEdit = false;
            this.colMALTC.OptionsColumn.AllowFocus = false;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 1;
            // 
            // colMAMH1
            // 
            this.colMAMH1.Caption = "Mã môn học";
            this.colMAMH1.FieldName = "MAMH";
            this.colMAMH1.Name = "colMAMH1";
            this.colMAMH1.OptionsColumn.AllowEdit = false;
            this.colMAMH1.Visible = true;
            this.colMAMH1.VisibleIndex = 3;
            // 
            // colTENMH1
            // 
            this.colTENMH1.Caption = "Tên môn học";
            this.colTENMH1.FieldName = "TENMH";
            this.colTENMH1.Name = "colTENMH1";
            this.colTENMH1.OptionsColumn.AllowEdit = false;
            this.colTENMH1.Visible = true;
            this.colTENMH1.VisibleIndex = 4;
            // 
            // colNHOM1
            // 
            this.colNHOM1.Caption = "Nhóm";
            this.colNHOM1.FieldName = "NHOM";
            this.colNHOM1.Name = "colNHOM1";
            this.colNHOM1.OptionsColumn.AllowEdit = false;
            this.colNHOM1.Visible = true;
            this.colNHOM1.VisibleIndex = 6;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.Caption = "Niên khóa";
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.OptionsColumn.AllowEdit = false;
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 5;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnXoaDangKy);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 23);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(932, 33);
            this.panelControl2.TabIndex = 1;
            // 
            // btnXoaDangKy
            // 
            this.btnXoaDangKy.Enabled = false;
            this.btnXoaDangKy.Location = new System.Drawing.Point(22, 5);
            this.btnXoaDangKy.Name = "btnXoaDangKy";
            this.btnXoaDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDangKy.TabIndex = 0;
            this.btnXoaDangKy.Text = "Xóa";
            this.btnXoaDangKy.Click += new System.EventHandler(this.btnXoaDangKy_Click);
            // 
            // disabledCellEvents1
            // 
            this.disabledCellEvents1.ProcessingCell += new System.EventHandler<DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs>(this.DisabledCellEvents1_ProcessingCell);
            // 
            // sp_LayDSLopTinChiDaDangKyTableAdapter
            // 
            this.sp_LayDSLopTinChiDaDangKyTableAdapter.ClearBeforeFill = true;
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
            // DangKyLTCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 567);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Name = "DangKyLTCForm";
            this.Text = "Đăng ký lớp tín chỉ";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDeDangKyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDaDangKyGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_LayDSLopTinChiDaDangKyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraEditors.SpinEdit txtHocKy;
        private DevExpress.XtraEditors.SimpleButton btnFilter;
        private DevExpress.XtraGrid.GridControl sp_LayDSLopTinChiDeDangKyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONGCL;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.Utils.Behaviors.Common.DisabledCellEvents disabledCellEvents1;
        private DS dS;
        private System.Windows.Forms.BindingSource sp_LayDSLopTinChiDaDangKyBindingSource;
        private DSTableAdapters.sp_LayDSLopTinChiDaDangKyTableAdapter sp_LayDSLopTinChiDaDangKyTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sp_LayDSLopTinChiDaDangKyGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colTENMH1;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM1;
        private DevExpress.XtraEditors.SimpleButton btnXoaDangKy;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSTT;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}