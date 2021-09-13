using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Reports
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1(string khoa, string nienkhoa, int hocky)
        {
            InitializeComponent();
            ds1.EnforceConstraints = false;
            this.sp_InDSLopTinChiTableAdapter.Connection.ConnectionString = Program.ConnStr;
            this.sp_InDSLopTinChiTableAdapter.Fill(ds1.sp_InDSLopTinChi, "2021-2022", 1);
        }

    }
}
