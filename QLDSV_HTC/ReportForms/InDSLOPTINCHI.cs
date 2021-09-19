using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLDSV_HTC.Reports;
//using QLDSV_HTC.Reports;
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
    public partial class InDSLOPTINCHI : DevExpress.XtraEditors.XtraForm
    {
        public InDSLOPTINCHI()
        {
            InitializeComponent();
        }

        private void InDSSV_Load(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)Program.Bds_Dspm.DataSource;
            if (Program.AuthGroup == "PGV")
            {
                // lặp và thêm danh sách server vào combobox
                foreach (DataRow dataRow in dt.Rows)
                {
                    if (dataRow.ItemArray[0].ToString().Contains("Khoa"))
                        cmbKhoa.Properties.Items.Add(dataRow.ItemArray[0]);
                }
            }
            else if (Program.AuthGroup == "KHOA")
            {
                //cmbKhoa.Properties.Items.Add(((DataRowView)Program.Bds_Dspm[Program.MaKhoa])["TENKHOA"].ToString());
            }
            
            // sau khi add item vào combobox, set index mặc định là 0
            cmbKhoa.SelectedIndex = 0;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            InDSLTC_RP report = new InDSLTC_RP(/*cmbKhoa.SelectedText,*/ txtNienKhoa.Text, int.Parse(txtHocKy.Text));
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
    }
}