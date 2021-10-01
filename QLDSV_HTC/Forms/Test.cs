using DevExpress.XtraEditors;
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
    public partial class Test : DevExpress.XtraEditors.XtraForm
    {
        public Test()
        {
            InitializeComponent();
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    this.sp_GetChiTietDongHocPhiTableAdapter.Fill(this.dS.sp_GetChiTietDongHocPhi, mASVToolStripTextBox.Text, nIENKHOAToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hOCKYToolStripTextBox.Text, typeof(int))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}

        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //try
            //{
            //    this.sp_GetChiTietDongHocPhiTableAdapter.Fill(this.dS.sp_GetChiTietDongHocPhi, mASVToolStripTextBox.Text, nIENKHOAToolStripTextBox.Text, new System.Nullable<int>(((int)(System.Convert.ChangeType(hOCKYToolStripTextBox.Text, typeof(int))))));
            //}
            //catch (System.Exception ex)
            //{
            //    System.Windows.Forms.MessageBox.Show(ex.Message);
            //}
        }
    }
}