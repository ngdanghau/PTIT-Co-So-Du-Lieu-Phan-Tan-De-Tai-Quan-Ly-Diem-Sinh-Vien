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
    public partial class InDiemForm : DevExpress.XtraEditors.XtraForm
    {
        public InDiemForm()
        {
            InitializeComponent();
        }

        private void InDiemForm_Load(object sender, EventArgs e)
        {

        }

        private void button_preview_Click(object sender, EventArgs e)
        {
            InDiemMonHoc_RP rpt = new InDiemMonHoc_RP(textEdit_NK.Text, int.Parse(textEdit_HK.Text), textEdit_MH.Text, int.Parse(textEdit_Nhom.Text));
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void textEdit_NK_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}