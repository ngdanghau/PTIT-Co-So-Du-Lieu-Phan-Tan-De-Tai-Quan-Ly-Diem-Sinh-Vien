using DevExpress.XtraReports.UI;
using QLDSV_HTC.Reports;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            try
            {
                if (HK.Equals("") || MH.Equals("") || Nhom.Equals("") || NK.Equals(""))
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!Regex.IsMatch(textEdit_NK.Text, "\\d{4}-\\d{4}"))
                {
                    MessageBox.Show("Niên khóa không hợp lệ vd:2021-2022", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (int.Parse(textEdit_NK.Text.Substring(0, 4)) < 2000 || int.Parse(textEdit_NK.Text.Substring(5, 4)) < 2000)
                {
                    MessageBox.Show("Vui lòng nhập niên khóa lớn hơn 2000", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (int.Parse(textEdit_HK.Text) < 0 || int.Parse(textEdit_HK.Text) > 4)
                {
                    MessageBox.Show("Học kì không hợp lệ (1-4)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (int.Parse(textEdit_HK.Text) < 0 || int.Parse(textEdit_HK.Text) > 4)
                {
                    MessageBox.Show("Học kì không hợp lệ (1-4)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception )
            {
               MessageBox.Show("Vui lòng nhập đúng định dạng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            InDSSV_RP rpt = new InDSSV_RP(NK, int.Parse(HK), MH, int.Parse(Nhom),Khoa,tenMH);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }


        private void InDSSV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS.MONHOC' table. You can move, or remove it, as needed.
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

        private void comboBox_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.ChangeServer(comboBox_Khoa);
        }
    }
}