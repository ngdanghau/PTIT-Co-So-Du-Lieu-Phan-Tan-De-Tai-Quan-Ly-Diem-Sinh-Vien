using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLDSV_HTC.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC.ReportForms
{
    public partial class InDSSV : DevExpress.XtraEditors.XtraForm
    {
        public InDSSV()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            InDSSVReport rpt = new InDSSVReport("2021-2022", 1, "CTDL", 1);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}