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

namespace QLDSV_HTC.Forms
{
    public partial class InBangDiemTKForm : DevExpress.XtraEditors.XtraForm
    {
        public InBangDiemTKForm()
        {
            InitializeComponent();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

        private void InBangDiemTKForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Fill(this.dS.LOP);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DataRowView dataRow = lookUpEdit1.GetSelectedDataRow() as DataRowView;
            if (dataRow == null)
            {
                MessageBox.Show("Mã lớp ko tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            InBangDiemTongKet_RP rpt = new InBangDiemTongKet_RP(dataRow.Row.ItemArray);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}