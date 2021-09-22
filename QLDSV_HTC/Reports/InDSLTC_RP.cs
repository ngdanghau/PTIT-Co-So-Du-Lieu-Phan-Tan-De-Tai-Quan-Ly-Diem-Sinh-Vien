using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Reports
{
    public partial class InDSLTC_RP : DevExpress.XtraReports.UI.XtraReport
    {
        public InDSLTC_RP(string nienkhoa, int hocky, string Khoa)
        {
            InitializeComponent();
            this.xrLabel_Khoa.Text = "Khoa: " + Khoa;
            this.xrLabel_NKHK.Text = "Niên Khóa: " + nienkhoa + "  Học kỳ: " + hocky;
            this.sqlDataSource1.Connection.ConnectionString = Program.ConnStr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocky;
            this.sqlDataSource1.Fill();
        }

    }
}
