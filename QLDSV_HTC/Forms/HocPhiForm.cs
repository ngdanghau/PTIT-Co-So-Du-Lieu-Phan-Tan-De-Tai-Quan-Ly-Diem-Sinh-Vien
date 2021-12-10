using DevExpress.XtraEditors;
using QLDSV_HTC.Class;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace QLDSV_HTC.Forms
{
    public partial class HocPhiForm : DevExpress.XtraEditors.XtraForm
    {
        private string maSV = "";
        private int position = 0;
        private string state;
        private string state2;
        Stack<string> undoStack = new Stack<string>();
        private HocPhiClass HocPhiData = null;
        private ChiTietDongHPClass ChiTietDongHP = null;
        public HocPhiForm()
        {
            InitializeComponent();
        }

        private void SetButtonState(bool value)
        {
            if (state == "edit")
            {
                barButtonAdd.Enabled
                    = barButtonEdit.Enabled
                    = barButtonDelete.Enabled
                    = barButtonRenew.Enabled
                    = sp_GetThongTinDongHocPhiGridControl.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = groupControl2.Enabled
                    = value;

                barButtonUndo.Enabled = undoStack.Count > 0;
            }
            else if (state == "add")
            {
                barButtonAdd.Enabled
                    = barButtonEdit.Enabled
                    = barButtonDelete.Enabled
                    = barButtonRenew.Enabled
                    = sp_GetThongTinDongHocPhiGridControl.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = groupControl2.Enabled
                    = value;
            }
        }

        private void SetButtonStatePanel2(bool value)
        {
            if (state2 == "edit")
            {
                simpleBtnThem.Enabled
                    = simpleBtnEdit.Enabled
                    = simpleBtnDelete.Enabled
                    = simpleBtnRenew.Enabled
                    = sp_GetChiTietDongHocPhiGridControl.Enabled
                    = !value;

                simpleBtnHuy.Enabled
                    = simpleBtnSave.Enabled
                    = groupControl4.Enabled
                    = value;

                barButtonUndo.Enabled = undoStack.Count > 0;
            }
            else if (state2 == "add")
            {
                simpleBtnThem.Enabled
                    = simpleBtnEdit.Enabled
                    = simpleBtnDelete.Enabled
                    = simpleBtnRenew.Enabled
                    = sp_GetThongTinDongHocPhiGridControl.Enabled
                    = !value;

                simpleBtnHuy.Enabled
                    = simpleBtnSave.Enabled
                    = groupControl4.Enabled
                    = value;
            }
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {

            maSV = txtMaSV.Text.Trim();
            txtHoTen.Text = "";
            txtMaLop.Text = "";

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

            txtHoTen.Text = Program.MyReader.GetString(0) + " " + Program.MyReader.GetString(1);
            txtMaLop.Text = Program.MyReader.GetString(2);
            Program.MyReader.Close();


            try
            {
                this.sp_GetThongTinDongHocPhiTableAdapter.Connection.ConnectionString = Program.ConnStr;
                this.sp_GetThongTinDongHocPhiTableAdapter.Fill(this.DS.sp_GetThongTinDongHocPhi, maSV);
                barButtonEdit.Enabled = barButtonDelete.Enabled = sp_GetThongTinDongHocPhiBindingSource.Count > 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (position > 0)
            {
                sp_GetThongTinDongHocPhiBindingSource.Position = position;
            }

            barButtonDelete.Enabled = barButtonEdit.Enabled = sp_GetThongTinDongHocPhiBindingSource.Count > 0;
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            try
            {
                this.sp_GetChiTietDongHocPhiTableAdapter.Connection.ConnectionString = Program.ConnStr;
                this.sp_GetChiTietDongHocPhiTableAdapter.Fill(this.DS.sp_GetChiTietDongHocPhi, txtMaSV.Text.Trim(), txtNienKhoa.Text.Trim(), int.Parse(txtHocKy.Text));

                HocPhiData = new HocPhiClass(txtMaSV.Text.Trim(), txtNienKhoa.Text.Trim(), int.Parse(txtHocKy.Text), int.Parse(txtHocPhi.EditValue.ToString()), txtNienKhoa.Text.Trim(), int.Parse(txtHocKy.Text), int.Parse(txtHocPhi.EditValue.ToString()));


                if (sp_GetChiTietDongHocPhiBindingSource.Count > 0)
                {
                    ChiTietDongHP = new ChiTietDongHPClass(txtMaSV.Text.Trim(), txtNienKhoa.Text.Trim(), int.Parse(txtHocKy.Text), int.Parse(txtHocPhi1.EditValue.ToString()), txtNienKhoa.Text.Trim(), int.Parse(txtHocKy.Text), int.Parse(txtHocPhi1.EditValue.ToString()), DateTime.Parse(dateDong.Text), DateTime.Parse(dateDong.Text));
                }

                groupControl5.Enabled = sp_GetChiTietDongHocPhiBindingSource.Count > 0;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateForm()
        {
            if (txtMaSV.Text.Trim() == "")
            {
                XtraMessageBox.Show("Mã Sinh Viên không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtNienKhoa.Text.Trim() == "")
            {
                XtraMessageBox.Show("Niên khóa không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtHocKy.Text.Trim() == "")
            {
                XtraMessageBox.Show("Học kỳ không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtHocPhi.EditValue.ToString().Trim() == "")
            {
                XtraMessageBox.Show("Học phí không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private bool ValidateForm2()
        {
            if (dateDong.Text.Trim() == "")
            {
                XtraMessageBox.Show("Ngày đóng không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtHocPhi.EditValue.ToString().Trim() == "")
            {
                XtraMessageBox.Show("Học phí không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            return true;
        }

        private void barButtonAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = sp_GetThongTinDongHocPhiBindingSource.Position;
            state = "add";
            SetButtonState(true);
            txtNienKhoa.Focus();
            if (textMaSV.DataBindings.Count > 0)
            {
                this.DS.sp_GetThongTinDongHocPhi.MASVColumn.DefaultValue = maSV;
                textMaSV.DataBindings[0].DataSourceNullValue = maSV;
            }
            this.sp_GetThongTinDongHocPhiBindingSource.AddNew();
        }

        private void barButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sp_GetChiTietDongHocPhiBindingSource.Count > 0)
            {
                MessageBox.Show("Sinh viên đã đóng học phí. Không thể sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            state = "edit";
            SetButtonState(true);
            position = sp_GetThongTinDongHocPhiBindingSource.Position;
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (sp_GetChiTietDongHocPhiBindingSource.Count > 0)
            {
                MessageBox.Show("Sinh viên đã đóng học phí. Không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa thông tin học phí này?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!ValidateForm()) return;
                try
                {
                    position = sp_GetThongTinDongHocPhiBindingSource.Position;
                    sp_GetThongTinDongHocPhiBindingSource.RemoveCurrent();
                    this.sp_GetThongTinDongHocPhiTableAdapter.Connection.ConnectionString = Program.ConnStr;
                    this.sp_GetThongTinDongHocPhiTableAdapter.Update(this.DS.sp_GetThongTinDongHocPhi);
                    this.sp_GetThongTinDongHocPhiBindingSource.ResetCurrentItem();

                    undoStack.Push(string.Format("INSERT INTO HOCPHI(MASV, NIENKHOA , HOCKY, HOCPHI) VALUES(N'{0}', N'{1}', {2}, {3})", HocPhiData.MaSV, HocPhiData.NienKhoa, HocPhiData.HocKy, HocPhiData.HocPhi));


                    this.sp_GetThongTinDongHocPhiTableAdapter.Fill(this.DS.sp_GetThongTinDongHocPhi, maSV);
                    barButtonEdit.Enabled = barButtonDelete.Enabled = sp_GetThongTinDongHocPhiBindingSource.Count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            barButtonUndo.Enabled = undoStack.Count > 0;
        }

        private bool checkHocPhi()
        {
            string query = string.Format(" EXEC sp_KiemTraHocPhi @MASV =  N'{0}', @NIENKHOA = N'{1}', @HOCKY = {2}", maSV, txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text.Trim()));
            var check = Program.ExecSqlNonQuery(query);
            if (check == 0) return true;
            return false;
        }

        private bool checkHocPhiDaDong()
        {
            string ngaydong = dateDong.Text;
            string query = string.Format(" EXEC sp_KiemTraHocPhiDaDong @MASV =  N'{0}', @NIENKHOA = N'{1}', @HOCKY = {2}, @NGAYDONG = N'{3}'", maSV, txtNienKhoa.Text.Trim(), Convert.ToInt32(txtHocKy.Text.Trim()), ngaydong);
            var check = Program.ExecSqlNonQuery(query);
            if (check == 0) return true;
            return false;
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateForm()) return;
            if (state == "add" && !checkHocPhi()) return;

            if(state == "edit")
            {
                HocPhiData.NienKhoaNew = txtNienKhoa.Text.Trim();
                HocPhiData.HocKyNew = Convert.ToInt32(txtHocKy.Text);
                HocPhiData.HocPhiNew = Convert.ToInt32(txtHocPhi.EditValue.ToString());
            }
            try
            {
                this.sp_GetThongTinDongHocPhiBindingSource.EndEdit();
                this.sp_GetThongTinDongHocPhiBindingSource.ResetCurrentItem();


                if (state == "add") {
                    this.sp_GetThongTinDongHocPhiTableAdapter.Update(this.DS.sp_GetThongTinDongHocPhi);
                } 
                else if (state == "edit")
                {
                    this.sp_GetThongTinDongHocPhiTableAdapter.SuaHocPhi(HocPhiData.MaSV, HocPhiData.NienKhoa, HocPhiData.HocKy, HocPhiData.NienKhoaNew, HocPhiData.HocKyNew, HocPhiData.HocPhiNew);
                    Console.WriteLine(string.Format("UPDATE HOCPHI " +
                                                 "SET NIENKHOA = N'{0}', HOCKY = {1}, HOCPHI = {2} " +
                                                 "WHERE MASV = N'{3}' AND NIENKHOA = N'{4}' AND HOCKY = {5}", HocPhiData.NienKhoa, HocPhiData.HocKy, HocPhiData.HocPhi, HocPhiData.MaSV, HocPhiData.NienKhoaNew, HocPhiData.HocKyNew));

                    undoStack.Push(string.Format("UPDATE HOCPHI " +
                                                 "SET NIENKHOA = N'{0}', HOCKY = {1}, HOCPHI = {2} " +
                                                 "WHERE MASV = N'{3}' AND NIENKHOA = N'{4}' AND HOCKY = {5}", HocPhiData.NienKhoa, HocPhiData.HocKy, HocPhiData.HocPhi, HocPhiData.MaSV, HocPhiData.NienKhoaNew, HocPhiData.HocKyNew));
                }
            }
            catch (Exception ex)
            {
                sp_GetThongTinDongHocPhiBindingSource.RemoveCurrent();
                XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SetButtonState(false);
            barButtonUndo.Enabled = undoStack.Count > 0;
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SetButtonState(false);
            simpleButton1_Click(null, null);
        }

        private void barButtonRenew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!ValidateForm()) return;
            simpleButton1_Click(null, null);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void barButtonUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string command = undoStack.Pop();
            Program.ExecSqlNonQuery(command);

            barButtonUndo.Enabled = undoStack.Count > 0;
            simpleButton1_Click(null, null);
        }

        private void barButtonOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (this.groupControl2.Enabled)
            {
                string message = "Dữ liệu có thể chưa lưu vào Database. \n Bạn có chắc muốn thoát !";
                DialogResult dr = XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
        }




        private void simpleBtnEdit_Click(object sender, EventArgs e)
        {
            state2 = "edit";
            SetButtonStatePanel2(true);
        }

        private void simpleBtnDelete_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa lần đóng tiền học phí này?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!ValidateForm2()) return;
                try
                {
                    sp_GetChiTietDongHocPhiBindingSource.RemoveCurrent();
                    this.sp_GetChiTietDongHocPhiBindingSource.ResetCurrentItem();
                    this.sp_GetChiTietDongHocPhiTableAdapter.Connection.ConnectionString = Program.ConnStr;
                    this.sp_GetChiTietDongHocPhiTableAdapter.sp_XoaChiTietDongHP(ChiTietDongHP.MaSV, ChiTietDongHP.NienKhoa, ChiTietDongHP.HocKy, ChiTietDongHP.NgayDong);

                    this.sp_GetChiTietDongHocPhiTableAdapter.Fill(this.DS.sp_GetChiTietDongHocPhi, ChiTietDongHP.MaSV, ChiTietDongHP.NienKhoa, ChiTietDongHP.HocKy);
                    simpleButton1_Click(null, null);
                    simpleBtnEdit.Enabled = simpleBtnDelete.Enabled = sp_GetThongTinDongHocPhiBindingSource.Count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void simpleBtnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateForm2()) return;
            if (state2 == "add" && !checkHocPhiDaDong()) return;

            ChiTietDongHP.NgayDongNew = DateTime.Parse(dateDong.Text);
            ChiTietDongHP.TienDaDongNew = Convert.ToInt32(txtHocPhi1.EditValue.ToString());

            try
            {
                int check = 0;
                this.sp_GetChiTietDongHocPhiBindingSource.EndEdit();
                if (state2 == "add")
                {
                    string query = string.Format(" EXEC sp_ThemChiTietDongHP @MASV = N'{0}', @NIENKHOA = N'{1}', @HOCKY = {2}, @NGAYDONG = N'{3}', @SOTIENDONG = {4}", ChiTietDongHP.MaSV, ChiTietDongHP.NienKhoa, ChiTietDongHP.HocKy, ChiTietDongHP.NgayDongNew, ChiTietDongHP.TienDaDongNew);
                    check = Program.ExecSqlNonQuery(query);
                    if (check != 0)
                    {
                        sp_GetChiTietDongHocPhiBindingSource.RemoveCurrent();
                    }

                }
                else if (state2 == "edit")
                {
                    string query = string.Format(" EXEC sp_SuaChiTietDongHP @MASV = N'{0}', @NIENKHOA = N'{1}', @HOCKY = {2}, @NGAYDONG = N'{3}', @NIENKHOANEW = N'{4}', @HOCKYNEW = {5}, @SOTIENDONGNEW = {6}, @NGAYDONGNEW = N'{7}'", ChiTietDongHP.MaSV, ChiTietDongHP.NienKhoa, ChiTietDongHP.HocKy, ChiTietDongHP.NgayDong, ChiTietDongHP.NienKhoaNew, ChiTietDongHP.HocKyNew, ChiTietDongHP.TienDaDongNew, ChiTietDongHP.NgayDongNew);
                    check = Program.ExecSqlNonQuery(query);
                }
                if (check != 0)
                {
                    this.sp_GetChiTietDongHocPhiBindingSource.ResetCurrentItem();
                    gridView1_RowClick(null, null);
                }
                }
            catch (Exception ex)
            {
                
                
            }
            SetButtonStatePanel2(false);
            simpleButton1_Click(null, null);
        }

        private void simpleBtnThem_Click(object sender, EventArgs e)
        {
            state2 = "add";
            SetButtonStatePanel2(true);
            this.sp_GetChiTietDongHocPhiBindingSource.AddNew();
        }


        private void simpleBtnRenew_Click(object sender, EventArgs e)
        {
            gridView1_RowClick(null, null);
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleBtnHuy_Click(object sender, EventArgs e)
        {
            SetButtonStatePanel2(false);
            gridView1_RowClick(null, null);
        }

        private void gridView2_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            ChiTietDongHP = new ChiTietDongHPClass(txtMaSV.Text.Trim(), txtNienKhoa.Text.Trim(), int.Parse(txtHocKy.Text), int.Parse(txtHocPhi1.EditValue.ToString()), txtNienKhoa.Text.Trim(), int.Parse(txtHocKy.Text), int.Parse(txtHocPhi1.EditValue.ToString()), DateTime.Parse(dateDong.Text), DateTime.Parse(dateDong.Text));
        }
    }
}