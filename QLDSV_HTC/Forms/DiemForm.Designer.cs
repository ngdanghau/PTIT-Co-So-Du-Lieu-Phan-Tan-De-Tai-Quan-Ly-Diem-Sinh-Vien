
namespace QLDSV_HTC.Forms
{
    partial class DiemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiemForm));
            this.DS = new QLDSV_HTC.DS();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonRenew = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonOut = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonEdit = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUndo = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonSave = new DevExpress.XtraBars.BarButtonItem();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lookUpMonHoc = new DevExpress.XtraEditors.LookUpEdit();
            this.bdsMONHOC = new System.Windows.Forms.BindingSource(this.components);
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.txtNhom = new DevExpress.XtraEditors.TextEdit();
            this.txtHocKy = new DevExpress.XtraEditors.TextEdit();
            this.txtNienKhoa = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.MONHOCTableAdapter = new QLDSV_HTC.DSTableAdapters.MONHOCTableAdapter();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.sp_GetBangDiemMonHocGridControl = new DevExpress.XtraGrid.GridControl();
            this.sp_GetBangDiemMonHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMASV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIEM_HM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sp_GetBangDiemMonHocTableAdapter = new QLDSV_HTC.DSTableAdapters.sp_GetBangDiemMonHocTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetBangDiemMonHocGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetBangDiemMonHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonAdd,
            this.barButtonEdit,
            this.barButtonDelete,
            this.barButtonUndo,
            this.barButtonSave,
            this.barButtonOut,
            this.barButtonRenew});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 12;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonRenew),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonOut)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonRenew
            // 
            this.barButtonRenew.Caption = "Làm mới";
            this.barButtonRenew.Id = 6;
            this.barButtonRenew.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonRenew.ImageOptions.SvgImage")));
            this.barButtonRenew.Name = "barButtonRenew";
            this.barButtonRenew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonRenew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonRenew_ItemClick);
            // 
            // barButtonOut
            // 
            this.barButtonOut.Caption = "Thoát";
            this.barButtonOut.Id = 5;
            this.barButtonOut.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonOut.ImageOptions.SvgImage")));
            this.barButtonOut.Name = "barButtonOut";
            this.barButtonOut.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.barButtonOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonCancel_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1083, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 731);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1083, 20);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 707);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1083, 24);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 707);
            // 
            // barButtonAdd
            // 
            this.barButtonAdd.Id = 7;
            this.barButtonAdd.Name = "barButtonAdd";
            // 
            // barButtonEdit
            // 
            this.barButtonEdit.Id = 8;
            this.barButtonEdit.Name = "barButtonEdit";
            // 
            // barButtonDelete
            // 
            this.barButtonDelete.Id = 9;
            this.barButtonDelete.Name = "barButtonDelete";
            // 
            // barButtonUndo
            // 
            this.barButtonUndo.Id = 10;
            this.barButtonUndo.Name = "barButtonUndo";
            // 
            // barButtonSave
            // 
            this.barButtonSave.Id = 11;
            this.barButtonSave.Name = "barButtonSave";
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
            this.tableAdapterManager.UpdateOrder = QLDSV_HTC.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl2);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 24);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1083, 232);
            this.panelControl1.TabIndex = 11;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Controls.Add(this.btnStart);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, 156);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(1079, 74);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Bảng điều khiển";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(114, 35);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Ghi điểm";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(14, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.layoutControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(2, 2);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1079, 147);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông tin";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lookUpMonHoc);
            this.layoutControl1.Controls.Add(this.cmbKhoa);
            this.layoutControl1.Controls.Add(this.txtNhom);
            this.layoutControl1.Controls.Add(this.txtHocKy);
            this.layoutControl1.Controls.Add(this.txtNienKhoa);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 23);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1075, 122);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lookUpMonHoc
            // 
            this.lookUpMonHoc.Location = new System.Drawing.Point(617, 12);
            this.lookUpMonHoc.MenuManager = this.barManager1;
            this.lookUpMonHoc.Name = "lookUpMonHoc";
            this.lookUpMonHoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpMonHoc.Properties.DataSource = this.bdsMONHOC;
            this.lookUpMonHoc.Properties.DisplayMember = "TENMH";
            this.lookUpMonHoc.Properties.NullText = "Hãy chọn môn học";
            this.lookUpMonHoc.Properties.ValueMember = "MAMH";
            this.lookUpMonHoc.Size = new System.Drawing.Size(446, 20);
            this.lookUpMonHoc.StyleController = this.layoutControl1;
            this.lookUpMonHoc.TabIndex = 2;
            // 
            // bdsMONHOC
            // 
            this.bdsMONHOC.DataMember = "MONHOC";
            this.bdsMONHOC.DataSource = this.DS;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(66, 12);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(493, 21);
            this.cmbKhoa.TabIndex = 0;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // txtNhom
            // 
            this.txtNhom.Location = new System.Drawing.Point(66, 85);
            this.txtNhom.MenuManager = this.barManager1;
            this.txtNhom.Name = "txtNhom";
            this.txtNhom.Properties.Mask.EditMask = "N0";
            this.txtNhom.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtNhom.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtNhom.Properties.MaxLength = 2;
            this.txtNhom.Size = new System.Drawing.Size(493, 20);
            this.txtNhom.StyleController = this.layoutControl1;
            this.txtNhom.TabIndex = 5;
            // 
            // txtHocKy
            // 
            this.txtHocKy.Location = new System.Drawing.Point(66, 61);
            this.txtHocKy.MenuManager = this.barManager1;
            this.txtHocKy.Name = "txtHocKy";
            this.txtHocKy.Properties.Mask.EditMask = "N0";
            this.txtHocKy.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtHocKy.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtHocKy.Properties.MaxLength = 2;
            this.txtHocKy.Size = new System.Drawing.Size(493, 20);
            this.txtHocKy.StyleController = this.layoutControl1;
            this.txtHocKy.TabIndex = 4;
            // 
            // txtNienKhoa
            // 
            this.txtNienKhoa.Location = new System.Drawing.Point(66, 37);
            this.txtNienKhoa.MenuManager = this.barManager1;
            this.txtNienKhoa.Name = "txtNienKhoa";
            this.txtNienKhoa.Size = new System.Drawing.Size(493, 20);
            this.txtNienKhoa.StyleController = this.layoutControl1;
            this.txtNienKhoa.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1075, 122);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtNienKhoa;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 25);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(551, 24);
            this.layoutControlItem1.Text = "Niên khóa:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtHocKy;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 49);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(551, 24);
            this.layoutControlItem2.Text = "Học Kỳ:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtNhom;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 73);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(551, 29);
            this.layoutControlItem3.Text = "Nhóm:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.cmbKhoa;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(551, 25);
            this.layoutControlItem4.Text = "Khoa:";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(51, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.lookUpMonHoc;
            this.layoutControlItem5.Location = new System.Drawing.Point(551, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(504, 102);
            this.layoutControlItem5.Text = "Môn học:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(51, 13);
            // 
            // MONHOCTableAdapter
            // 
            this.MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.sp_GetBangDiemMonHocGridControl);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 256);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1083, 475);
            this.panelControl2.TabIndex = 12;
            // 
            // sp_GetBangDiemMonHocGridControl
            // 
            this.sp_GetBangDiemMonHocGridControl.DataSource = this.sp_GetBangDiemMonHocBindingSource;
            this.sp_GetBangDiemMonHocGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sp_GetBangDiemMonHocGridControl.Location = new System.Drawing.Point(2, 2);
            this.sp_GetBangDiemMonHocGridControl.MainView = this.gridView1;
            this.sp_GetBangDiemMonHocGridControl.MenuManager = this.barManager1;
            this.sp_GetBangDiemMonHocGridControl.Name = "sp_GetBangDiemMonHocGridControl";
            this.sp_GetBangDiemMonHocGridControl.Size = new System.Drawing.Size(1079, 471);
            this.sp_GetBangDiemMonHocGridControl.TabIndex = 0;
            this.sp_GetBangDiemMonHocGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // sp_GetBangDiemMonHocBindingSource
            // 
            this.sp_GetBangDiemMonHocBindingSource.DataMember = "sp_GetBangDiemMonHoc";
            this.sp_GetBangDiemMonHocBindingSource.DataSource = this.DS;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMASV,
            this.colHOTEN,
            this.colDIEM_CC,
            this.colDIEM_GK,
            this.colDIEM_CK,
            this.colDIEM_HM});
            this.gridView1.GridControl = this.sp_GetBangDiemMonHocGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colMASV
            // 
            this.colMASV.Caption = "Mã SV";
            this.colMASV.FieldName = "MASV";
            this.colMASV.Name = "colMASV";
            this.colMASV.OptionsColumn.AllowEdit = false;
            this.colMASV.OptionsColumn.AllowFocus = false;
            this.colMASV.OptionsColumn.ReadOnly = true;
            this.colMASV.Visible = true;
            this.colMASV.VisibleIndex = 0;
            // 
            // colHOTEN
            // 
            this.colHOTEN.Caption = "Họ tên SV";
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.OptionsColumn.AllowEdit = false;
            this.colHOTEN.OptionsColumn.AllowFocus = false;
            this.colHOTEN.OptionsColumn.ReadOnly = true;
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 1;
            // 
            // colDIEM_CC
            // 
            this.colDIEM_CC.Caption = "Điểm chuyên cần";
            this.colDIEM_CC.FieldName = "DIEM_CC";
            this.colDIEM_CC.Name = "colDIEM_CC";
            this.colDIEM_CC.Visible = true;
            this.colDIEM_CC.VisibleIndex = 2;
            // 
            // colDIEM_GK
            // 
            this.colDIEM_GK.Caption = "Điểm giữa kỳ";
            this.colDIEM_GK.FieldName = "DIEM_GK";
            this.colDIEM_GK.Name = "colDIEM_GK";
            this.colDIEM_GK.Visible = true;
            this.colDIEM_GK.VisibleIndex = 3;
            // 
            // colDIEM_CK
            // 
            this.colDIEM_CK.Caption = "Điểm cuối kỳ";
            this.colDIEM_CK.FieldName = "DIEM_CK";
            this.colDIEM_CK.Name = "colDIEM_CK";
            this.colDIEM_CK.Visible = true;
            this.colDIEM_CK.VisibleIndex = 4;
            // 
            // colDIEM_HM
            // 
            this.colDIEM_HM.Caption = "Điểm hết môn";
            this.colDIEM_HM.FieldName = "DIEM_HM";
            this.colDIEM_HM.Name = "colDIEM_HM";
            this.colDIEM_HM.OptionsColumn.AllowEdit = false;
            this.colDIEM_HM.OptionsColumn.AllowFocus = false;
            this.colDIEM_HM.OptionsColumn.ReadOnly = true;
            this.colDIEM_HM.Visible = true;
            this.colDIEM_HM.VisibleIndex = 5;
            // 
            // sp_GetBangDiemMonHocTableAdapter
            // 
            this.sp_GetBangDiemMonHocTableAdapter.ClearBeforeFill = true;
            // 
            // DiemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1083, 751);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "DiemForm";
            this.Text = "Quản lý điểm";
            this.Load += new System.EventHandler(this.DiemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMONHOC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetBangDiemMonHocGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetBangDiemMonHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonAdd;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem barButtonEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonUndo;
        private DevExpress.XtraBars.BarButtonItem barButtonSave;
        private DevExpress.XtraBars.BarButtonItem barButtonOut;
        private DevExpress.XtraBars.BarButtonItem barButtonRenew;
        private DS DS;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtHocKy;
        private DevExpress.XtraEditors.TextEdit txtNienKhoa;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private DevExpress.XtraEditors.TextEdit txtNhom;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.LookUpEdit lookUpMonHoc;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private System.Windows.Forms.BindingSource bdsMONHOC;
        private DSTableAdapters.MONHOCTableAdapter MONHOCTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl sp_GetBangDiemMonHocGridControl;
        private System.Windows.Forms.BindingSource sp_GetBangDiemMonHocBindingSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMASV;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_CK;
        private DevExpress.XtraGrid.Columns.GridColumn colDIEM_HM;
        private DSTableAdapters.sp_GetBangDiemMonHocTableAdapter sp_GetBangDiemMonHocTableAdapter;
    }
}