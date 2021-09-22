using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Reports
{
    public partial class InDSDongHP_RP : DevExpress.XtraReports.UI.XtraReport
    {
        public InDSDongHP_RP(string malop, string nienkhoa, int hocky, string Khoa)
        {
            InitializeComponent();
            this.xrMaLop.Text = "MÃ LỚP: " + malop;
            this.xrKhoa.Text = "KHOA: " + Khoa;
            this.sqlDataSource1.Connection.ConnectionString = Program.ConnStr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = nienkhoa;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = hocky;
            this.sqlDataSource1.Fill();
        }

    }
}
