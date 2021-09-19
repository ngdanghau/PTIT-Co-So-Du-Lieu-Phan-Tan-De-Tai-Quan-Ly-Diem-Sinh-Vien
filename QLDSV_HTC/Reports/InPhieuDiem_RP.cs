using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Reports
{
    public partial class InPhieuDiem_RP : DevExpress.XtraReports.UI.XtraReport
    {
        public InPhieuDiem_RP(String MaSV)
        {
            InitializeComponent();
            this.sqlDataSource1.Queries[0].Parameters[0].Value = MaSV;
            this.sqlDataSource1.Fill();
        }

    }
}
