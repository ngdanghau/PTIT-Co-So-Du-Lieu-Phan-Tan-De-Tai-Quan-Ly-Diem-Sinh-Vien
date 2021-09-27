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
        private bool isLogin = false;
        private string maSV = "";

        public List<int> DisabledRowHandles = new List<int>();
        DataTable table = new DataTable();
        BindingSource bind = new BindingSource();

        public DangKyLTCForm()
        {
            InitializeComponent();

            table.Columns.Add(new DataColumn("MAMH", typeof(string)));
            table.Columns.Add(new DataColumn("TENMH", typeof(string)));
            table.Columns.Add(new DataColumn("HO TEN", typeof(string)));
            table.Columns.Add(new DataColumn("NHOM", typeof(Int32)));
            table.Columns.Add(new DataColumn("SOSVTOITHIEU", typeof(Int32)));
            table.Columns.Add(new DataColumn("SOLUONGCL", typeof(Int32)));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (isLogin)
            {
                isLogin = groupControl2.Enabled = groupControl3.Enabled = false;
                txtMaSV.Enabled = true;
                btnLogin.Text = "Đăng nhập";
                labelHoTen.Text = "";
                labelLop.Text = "";
            }
            else
            {
                maSV = txtMaSV.Text.Trim();
                if (maSV == "")
                {
                    XtraMessageBox.Show("Mã SV không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    Program.KetNoi();
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message, "Không thể kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string lenh = string.Format("SELECT HO, TEN, MALOP, DANGHIHOC FROM SINHVIEN WHERE MASV = N'{0}'", maSV);
                Program.MyReader = Program.ExecSqlDataReader(lenh);
                if (Program.MyReader == null || !Program.MyReader.HasRows)
                {
                    MessageBox.Show("Không tìm thấy thông tin sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.MyReader.Close();
                    return;
                }

                Program.MyReader.Read();
                if (Program.MyReader.GetBoolean(3))
                {
                    MessageBox.Show("Sinh viên đã nghỉ học!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Program.MyReader.Close();
                    return;
                }

                isLogin = groupControl2.Enabled = groupControl3.Enabled = true;
                txtMaSV.Enabled = false;
                btnLogin.Text = "Thoát";

                labelHoTen.Text = string.Format("Họ và tên: {0}", Program.MyReader.GetString(0) + " " + Program.MyReader.GetString(1));
                labelLop.Text = string.Format("Lớp: {0}", Program.MyReader.GetString(2));

                Program.MyReader.Close();


            }
           


        }

        private void DangKyLTCForm_Load(object sender, EventArgs e)
        {
            groupControl2.Enabled = groupControl3.Enabled = false;
            labelHoTen.Text = "";
            labelLop.Text = "";
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


            string sqlQuery = string.Format("exec sp_LayDSLopTinChiDeDangKy @NIENKHOA = N'{0}', @HOCKY = {1}", txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));
            Program.MyReader = Program.ExecSqlDataReader(sqlQuery);
            if (Program.MyReader == null) return;

            // lấy danh sách đã đăng ký
            this.sp_LayDSLopTinChiDaDangKyTableAdapter.Fill(this.dS.sp_LayDSLopTinChiDaDangKy, maSV, txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));

            table.Rows.Clear();
            int i = 0;
            while (Program.MyReader.Read())
            {
                DataRow drTmp = table.NewRow();
                string maMH = (string)Program.MyReader["MAMH"];
                string tenMH = (string)Program.MyReader["TENMH"];
                int nhom = (int)Program.MyReader["NHOM"];
                string hoTen = (string)Program.MyReader["HO TEN"];
                int soluongtoithieu = (int)Program.MyReader["SOSVTOITHIEU"];
                int soluongdadk = (int)Program.MyReader["SOSVDK"];

                drTmp[0] = maMH;
                drTmp[1] = tenMH;
                drTmp[2] = hoTen;
                drTmp[3] = nhom;
                drTmp[4] = soluongtoithieu;
                drTmp[5] = soluongtoithieu - soluongdadk;
                table.Rows.Add(drTmp);
                sp_LayDSLopTinChiDaDangKyBindingSource.Filter = string.Format("MAMH = '{0}' AND NHOM = {1} AND NIENKHOA = '{2}'", maMH, nhom, txtNienKhoa.Text.Trim());
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

            //try
            //{
            //    this.sp_LayDSLopTinChiDeDangKyTableAdapter.Fill(this.DS.sp_LayDSLopTinChiDeDangKy, txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }

        private void DisabledCellEvents1_ProcessingCell(object sender, DevExpress.Utils.Behaviors.Common.ProcessCellEventArgs e)
        {
            if (DisabledRowHandles.Contains(e.RecordId))
                e.Disabled = true;
        }

        private void gridView2_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view == null) return;
            view.BeginSelection();
            int[] selectedRows = view.GetSelectedRows();
            Console.WriteLine(selectedRows.Length);
            btnXoaDangKy.Enabled = selectedRows.Length > 0;

            for (int i = 0; i < selectedRows.Length; i++)
            {
                
            }
        }
    }
}