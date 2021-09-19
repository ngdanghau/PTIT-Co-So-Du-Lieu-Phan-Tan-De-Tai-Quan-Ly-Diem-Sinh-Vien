using DevExpress.XtraReports.UI;
using QLDSV_HTC.Reports;
using System;

namespace QLDSV_HTC.ReportForms
{
    public partial class InDSSV : DevExpress.XtraEditors.XtraForm
    {
        public InDSSV()
        {
            InitializeComponent();
        }


        private void ButtonPreviewclick(object sender, EventArgs e)
        {

            InDSSV_RP rpt = new InDSSV_RP(textEdit_NK.Text, int.Parse(textEdit_HK.Text), textEdit_MH.Text, int.Parse(textEdit_Nhom.Text));
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void InDSSV_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void textEdit_MH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textEdit_Nhom_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}