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
    public partial class DangKyLTCForm : DevExpress.XtraEditors.XtraForm
    {
        public List<int> DisabledRowHandles = new List<int>();
        DataTable table = new DataTable();
        BindingSource bind = new BindingSource();

        public DangKyLTCForm()
        {
            InitializeComponent();

            table.Columns.Add(new DataColumn("STT", typeof(Int32)));
            table.Columns.Add(new DataColumn("MAMH", typeof(string)));
            table.Columns.Add(new DataColumn("TENMH", typeof(string)));
            table.Columns.Add(new DataColumn("HO TEN", typeof(string)));
            table.Columns.Add(new DataColumn("NHOM", typeof(Int32)));
            table.Columns.Add(new DataColumn("SOSVTOITHIEU", typeof(Int32)));
            table.Columns.Add(new DataColumn("SOLUONGCL", typeof(Int32)));
            table.Columns.Add(new DataColumn("MALTC", typeof(Int32)));
        }

        private void LoadDataDanhSachDaDangKy()
        {
            this.dS.EnforceConstraints = false;
            this.sp_LayDSLopTinChiDaDangKyTableAdapter.Connection.ConnectionString = Program.ConnStr;
            this.sp_LayDSLopTinChiDaDangKyTableAdapter.Fill(this.dS.sp_LayDSLopTinChiDaDangKy, Program.AuthUserID, txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));
            this.gridView2.Columns[1].Visible = false;
        }

        private void LoadData()
        {
            DisabledRowHandles.Clear();
            string sqlQuery = string.Format("exec sp_LayDSLopTinChiDeDangKy @NIENKHOA = N'{0}', @HOCKY = {1}", txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));
            Program.MyReader = Program.ExecSqlDataReader(sqlQuery);
            if (Program.MyReader == null) return;

            // lấy danh sách đã đăng ký
            LoadDataDanhSachDaDangKy();

            // lấy danh sách môn học
            table.Rows.Clear();
            int i = 0;
            while (Program.MyReader.Read())
            {
                DataRow drTmp = table.NewRow();
                int stt = i+1;
                string maMH = (string)Program.MyReader["MAMH"];
                int maLTC = (int)Program.MyReader["MALTC"];
                string tenMH = (string)Program.MyReader["TENMH"];
                int nhom = (int)Program.MyReader["NHOM"];
                string hoTen = (string)Program.MyReader["HO TEN"];
                int soluongtoithieu = (int)Program.MyReader["SOSVTOITHIEU"];
                int soluongdadk = (int)Program.MyReader["SOSVDK"];

                drTmp[0] = stt;
                drTmp[1] = maMH;
                drTmp[2] = tenMH;
                drTmp[3] = hoTen;
                drTmp[4] = nhom;
                drTmp[5] = soluongtoithieu;
                drTmp[6] = soluongtoithieu - soluongdadk;
                drTmp[7] = maLTC;
                table.Rows.Add(drTmp);

                sp_LayDSLopTinChiDaDangKyBindingSource.Filter = string.Format("MAMH = '{0}' AND NHOM = {1}", maMH.Trim(), nhom);
                if (sp_LayDSLopTinChiDaDangKyBindingSource.Count > 0)
                {
                    DisabledRowHandles.Add(i);
                }
                i++;

            }
            sp_LayDSLopTinChiDaDangKyBindingSource.Filter = "MAMH <> ''";
            bind.DataSource = table;
            sp_LayDSLopTinChiDeDangKyGridControl.DataSource = bind;

            Program.MyReader.Close();
            Program.Conn.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (txtNienKhoa.Text.Trim() == "")
            {
                XtraMessageBox.Show("Niên khóa không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtHocKy.Text.Trim() == "")
            {
                XtraMessageBox.Show("Học kỳ không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LoadData();
        }

        private void DisabledCellEvents1_ProcessingCell(object sender, DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs e)
        {
            if (DisabledRowHandles.Contains(e.RecordId))
                e.Disabled = true;
        }

        private void btnXoaDangKy_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn hủy đăng ký lớp tín chỉ đã chọn?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                gridView2.ShowLoadingPanel();
                gridView2.BeginSelection();
                int[] selectedRows = gridView2.GetSelectedRows();
                List<int> ltc_ID = new List<int>();
                for (int i = 0; i < selectedRows.Length; i++)
                {
                    DataRow row = gridView2.GetDataRow(selectedRows[i]);
                    ltc_ID.Add(Convert.ToInt32(row["MALTC"]));
                }

                string query = string.Format("UPDATE DANGKY SET HUYDANGKY = {0} WHERE MASV = N'{1}' AND MALTC IN({2})", 1, Program.AuthUserID, string.Join(", ", ltc_ID.ToArray()));
                var result = Program.ExecSqlNonQuery(query);
                gridView2.EndSelection();
                if (result == 0)
                {
                    // làm mới lại data
                    LoadData();
                }
                gridView2.HideLoadingPanel();
            }

            
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view == null) return;
            int[] selectedRows = view.GetSelectedRows();
            btnXoaDangKy.Enabled = selectedRows.Length > 0;
        }

        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {

            DataRow row = gridView1.GetFocusedDataRow();
            if (row == null) return;
            var pos = Convert.ToInt32(row["STT"]) - 1;
            var maLTC = table.Rows[pos]["MALTC"];
            var maMh = table.Rows[pos]["MAMH"];
            int hocky = Convert.ToInt32(txtHocKy.Text.Trim());
            var NienKhoa = txtNienKhoa.Text.Trim();

            string query = string.Format("EXEC sp_DangKyLopTinChi @MALTC = {0}, @MASV = '{1}', @MAMH = '{2}', @HOCKY = {3}, @NIENKHOA = '{4}'", maLTC, Program.AuthUserID, maMh, hocky, NienKhoa);
            Program.ExecSqlNonQuery(query);
            LoadData();
            gridView1.ClearSelection();
        }
    }
}