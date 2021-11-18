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
    public partial class InDSLOPTINCHI : DevExpress.XtraEditors.XtraForm
    {
        public InDSLOPTINCHI()
        {
            InitializeComponent();
        }

        private void InDSSV_Load(object sender, EventArgs e)
        {
            if (Program.AuthGroup == "PGV")
            {
                Program.Bds_Dspm.Filter = "TENKHOA <> 'Phòng Kế Toán'";
            }
            else if (Program.AuthGroup == "KHOA")
            {
                Program.Bds_Dspm.Filter = string.Format("TENSERVER = '{0}'", Program.ServerName);
            }
            Utils.LoadComboBox(cmbKhoa, Program.Bds_Dspm.DataSource);
        }
        

     

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.ChangeServer(cmbKhoa);
        }


        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            String NK = txtNienKhoa.Text.Trim();
            String HK = txtHocKy.Text.Trim();
            String Khoa = cmbKhoa.Text.Trim();
            if (NK.Equals("") || HK.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (int.Parse(txtNienKhoa.Text.Substring(0, 4)) < 2000 || int.Parse(txtNienKhoa.Text.Substring(5, 4)) < 2000)
            {
                MessageBox.Show("Vui lòng nhập niên khóa lớn hơn 2000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            InDSLTC_RP report = new InDSLTC_RP(NK, int.Parse(HK), Khoa);
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }
    }
}