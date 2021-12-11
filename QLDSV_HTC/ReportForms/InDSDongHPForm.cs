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
    public partial class InDSDongHPForm : DevExpress.XtraEditors.XtraForm
    {
        public InDSDongHPForm()
        {
            InitializeComponent();
        }

        private void button_preview_Click(object sender, EventArgs e)
        {

            DataRowView dataRow = lookUpEdit_ML.GetSelectedDataRow() as DataRowView;
            if (dataRow == null)
            {
                XtraMessageBox.Show("Mã lớp không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textEdit_NK.Text.Trim() == "")
            {
                MessageBox.Show("Niên khóa không hợp lệ vd:2021-2022", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (textEdit_HK.Text.Trim() == "")
            {
                MessageBox.Show("Học kì không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string khoa = dataRow["MAKHOA"].ToString().Trim();
            foreach (DataRowView item in Program.Bds_Dspm)
            {
                var name = item["TENKHOA"].ToString().Trim();
                if (Utils.GetMaKhoa(name) == khoa)
                {
                    khoa = name;
                    break;
                }
            }
            InDSDongHP_RP report = new InDSDongHP_RP(lookUpEdit_ML.EditValue.ToString().Trim(), textEdit_NK.Text.Trim(), Convert.ToInt32(textEdit_HK.Text.Trim()), khoa);
            ReportPrintTool print = new ReportPrintTool(report);
            print.ShowPreviewDialog();
        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lOPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);
        }

        private void InDSDongHPForm_Load(object sender, EventArgs e)
        {
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.ConnStr;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);

        }

        private void lookUpEdit_ML_EditValueChanged(object sender, EventArgs e)
        {
            DataRowView dataRow = lookUpEdit_ML.GetSelectedDataRow() as DataRowView;
            textEdit_NK.Text = dataRow["KHOAHOC"].ToString();
        }
    }
}