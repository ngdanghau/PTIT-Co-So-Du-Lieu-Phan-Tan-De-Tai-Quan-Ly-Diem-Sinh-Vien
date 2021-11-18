using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_HTC.Reports
{
    public partial class InBangDiemTongKet_RP : DevExpress.XtraReports.UI.XtraReport
    {
        public InBangDiemTongKet_RP(object[] array)
        {
            InitializeComponent();


            string malop = array[0].ToString();
            string khoahoc = array[2].ToString();
            string makhoa = array[3].ToString();

            xrLabel1.Text = string.Format("LỚP: {0} - KHÓA HỌC: {1}", malop, khoahoc);
            xrLabel2.Text = "KHOA: " + makhoa;
            this.sqlDataSource1.Connection.ConnectionString = Program.ConnStr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = malop;
            this.sqlDataSource1.Fill();
        }

    }
}
