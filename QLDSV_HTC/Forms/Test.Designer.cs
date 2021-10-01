
namespace QLDSV_HTC.Forms
{
    partial class Test
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
            this.dS = new QLDSV_HTC.DS();
            this.sp_GetChiTietDongHocPhiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sp_GetChiTietDongHocPhiTableAdapter = new QLDSV_HTC.DSTableAdapters.sp_GetChiTietDongHocPhiTableAdapter();
            this.tableAdapterManager = new QLDSV_HTC.DSTableAdapters.TableAdapterManager();
            this.sp_GetChiTietDongHocPhiGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetChiTietDongHocPhiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetChiTietDongHocPhiGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_GetChiTietDongHocPhiBindingSource
            // 
            this.sp_GetChiTietDongHocPhiBindingSource.DataMember = "sp_GetChiTietDongHocPhi";
            this.sp_GetChiTietDongHocPhiBindingSource.DataSource = this.dS;
            // 
            // sp_GetChiTietDongHocPhiTableAdapter
            // 
            this.sp_GetChiTietDongHocPhiTableAdapter.ClearBeforeFill = true;
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
            // sp_GetChiTietDongHocPhiGridControl
            // 
            this.sp_GetChiTietDongHocPhiGridControl.DataSource = this.sp_GetChiTietDongHocPhiBindingSource;
            this.sp_GetChiTietDongHocPhiGridControl.Location = new System.Drawing.Point(71, 52);
            this.sp_GetChiTietDongHocPhiGridControl.MainView = this.gridView1;
            this.sp_GetChiTietDongHocPhiGridControl.Name = "sp_GetChiTietDongHocPhiGridControl";
            this.sp_GetChiTietDongHocPhiGridControl.Size = new System.Drawing.Size(672, 255);
            this.sp_GetChiTietDongHocPhiGridControl.TabIndex = 2;
            this.sp_GetChiTietDongHocPhiGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.sp_GetChiTietDongHocPhiGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 378);
            this.Controls.Add(this.sp_GetChiTietDongHocPhiGridControl);
            this.Name = "Test";
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetChiTietDongHocPhiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sp_GetChiTietDongHocPhiGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DS dS;
        private System.Windows.Forms.BindingSource sp_GetChiTietDongHocPhiBindingSource;
        private DSTableAdapters.sp_GetChiTietDongHocPhiTableAdapter sp_GetChiTietDongHocPhiTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl sp_GetChiTietDongHocPhiGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}