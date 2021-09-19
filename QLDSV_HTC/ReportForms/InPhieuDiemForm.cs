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
    public partial class InPhieuDiemForm : DevExpress.XtraEditors.XtraForm
    {
        public InPhieuDiemForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit_NK_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button_preview_Click(object sender, EventArgs e)
        {
            InPhieuDiem_RP rpt = new InPhieuDiem_RP(textEdit_MSSV.Text);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}