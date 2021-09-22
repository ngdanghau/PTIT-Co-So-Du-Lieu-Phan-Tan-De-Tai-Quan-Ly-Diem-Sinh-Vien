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

        private void InPhieuDiemForm_Load(object sender, EventArgs e)
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

        private void button_preview_Click(object sender, EventArgs e)
        {
            String mssv = textEdit_MSSV.Text.Trim();
            String Khoa = cmbKhoa.Text.Trim();
            if(mssv.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if(mssv.Length!=10)
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng vd:N15DCCN001", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            String cmd = "Select MASV from SinhVien Where MaSV='"+mssv+"'";
            SqlDataReader dr = Program.ExecSqlDataReader(cmd);

            if(!dr.Read())
            {
                MessageBox.Show("Mã số sinh viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dr.Close();
                return;
            }dr.Close();
            InPhieuDiem_RP rpt = new InPhieuDiem_RP(mssv,Khoa);
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.ChangeServer(cmbKhoa);
        }
    }
}