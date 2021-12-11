using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QLDSV_HTC.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            //TODO: This line of code loads data into the 'dS.MONHOC' table.You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.ConnStr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            if (Program.AuthGroup == "PGV")
            {
                Program.Bds_Dspm.Filter = "TENKHOA <> 'Phòng Kế Toán'";
            }
            else if (Program.AuthGroup == "KHOA")
            {
                Program.Bds_Dspm.Filter = string.Format("TENSERVER = '{0}'", Program.ServerName);
            }
            Utils.LoadComboBox(comboBox_Khoa, Program.Bds_Dspm.DataSource);
 


        }

        private void button_preview_Click(object sender, EventArgs e)
        {
            String HK = textEdit_HK.Text.Trim();
            String MH = lookUpEdit_MH.Text.Trim();
            String Nhom = textEdit_Nhom.Text.Trim();
            String NK = textEdit_NK.Text.Trim();
            String Khoa = comboBox_Khoa.Text.Trim();
            DataRowView dataRow = lookUpEdit_MH.GetSelectedDataRow() as DataRowView;
            if (dataRow == null)
            {
                MessageBox.Show("Mã môn học ko tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String tenMH = dataRow["TENMH"].ToString();
            if (HK.Equals("")|| MH.Equals("") ||Nhom.Equals("") || NK.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
             else if (int.Parse(textEdit_NK.Text.Substring(0,4))<2000|| int.Parse(textEdit_NK.Text.Substring(5, 4)) < 2000)
            {
                MessageBox.Show("Vui lòng nhập niên khóa lớn hơn 2000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (int.Parse(textEdit_HK.Text)<0|| int.Parse(textEdit_HK.Text) >4)
            {
                MessageBox.Show("Học kì không hợp lệ (1-4)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (int.Parse(textEdit_HK.Text) < 0 || int.Parse(textEdit_HK.Text) > 4)
            {
                MessageBox.Show("Học kì không hợp lệ (1-4)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //var tenKhoa = Utils.GetMaKhoa(comboBox_Khoa.Text);
            InDiemMonHoc_RP rpt = new InDiemMonHoc_RP(NK, int.Parse(HK), MH, int.Parse(Nhom),Khoa,tenMH);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
            
        }

        private void comboBox_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.ChangeServer(comboBox_Khoa);
        }

    }
}