using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;


namespace QLDSV_HTC.Reports
{
    public partial class InDiemMonHoc_RP : DevExpress.XtraReports.UI.XtraReport
    {
        public InDiemMonHoc_RP(string nienkhoa, int hocky, string mamh, int nhom,string Khoa,string tenmh)
        {
            InitializeComponent();
            this.xrLabel_Khoa.Text = "Khoa: " +Khoa;
            this.xrLabel_NKHK.Text = "Niên Khóa: " + nienkhoa + "  Học kỳ: " + hocky;
            this.xrLabel_MHN.Text = "Môn Học: "+ tenmh+"  -  Nhóm: "+nhom;
            this.sqlDataSource1.Connection.ConnectionString = Program.ConnStr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = mamh;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Fill();
        }
    }
}
