using DevExpress.XtraEditors;
using QLDSV_HTC.Class;
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
    public partial class SinhVienForm : Form
    {
        private int position = -1;
        private string state = "";
        Stack<string> undoStack = new Stack<string>();

        private SinhVienClass sv = null;
        public SinhVienForm()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            if (TextBox_MaSV.Text.Trim() == "")
            {
                XtraMessageBox.Show("Mã sinh viên không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (DateEdit_NgaySinh.Text.Trim() == "")
            {
                XtraMessageBox.Show("Ngày Sinh không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (TextBox_Ho.Text.Trim() == "" || TextBox_Ten.Text.Trim() == "")
            {
                XtraMessageBox.Show("Họ tên không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dIACHITextBox.Text.Trim() == "")
            {
                XtraMessageBox.Show("Địa chỉ không được để trống!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        private void SetButtonState(bool value)
        {
            if (state == "edit")
            {
                barButtonItem_Add.Enabled
                    = barButtonEdit.Enabled
                    = barButtonDelete.Enabled
                    = barButtonRenew.Enabled
                    = GC_Lop.Enabled
                    = GC_SV.Enabled
                    //= panelControl1.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = panelControl3.Enabled
                    = TextBox_MaSV.ReadOnly
                    = dANGHIHOCCheckBox.Visible
                    = NghiHoc_Label.Visible
                    = value;

                barButtonUndo.Enabled = undoStack.Count > 0;

            }
            else if (state == "add")
            {
                barButtonItem_Add.Enabled
                    = barButtonEdit.Enabled
                    = barButtonDelete.Enabled
                    = barButtonRenew.Enabled
                    = GC_Lop.Enabled
                    = GC_SV.Enabled
                    = TextBox_MaSV.ReadOnly
                    //= panelControl1.Enabled
                    = dANGHIHOCCheckBox.Visible
                    = NghiHoc_Label.Visible
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                   = panelControl3.Enabled
                    = value;

            }
        }

        private void LoadData()
        {
            dS.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.ConnStr;
            // TODO: This line of code loads data into the 'dS.LOP' table. You can move, or remove it, as needed.
            this.lOPTableAdapter.Fill(this.dS.LOP);
            // TODO: This line of code loads data into the 'dS.SINHVIEN' table. You can move, or remove it, as needed.
            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.ConnStr;
            this.sINHVIENTableAdapter.Fill(this.dS.SINHVIEN);
            // TODO: This line of code loads data into the 'dS.DANGKY' table. You can move, or remove it, as needed.
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.ConnStr;
            this.dANGKYTableAdapter.Fill(this.dS.DANGKY);
            if (position > 0)
            {
                bdsSINHVIEN.Position = position;
            }
            barButtonDelete.Enabled = barButtonEdit.Enabled = bdsSINHVIEN.Count > 0;
        }

        private void SinhVienForm_Load(object sender, EventArgs e)
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

            if (Utils.ChangeServer(cmbKhoa))
            {
                LoadData();
            }
        }


        private void sINHVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsSINHVIEN.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dS);

        }

    
        private void barButtonOut_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }


        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsSINHVIEN.Position;
            state = "add";
            SetButtonState(true);
            TextBox_MaSV.Focus();
            bdsSINHVIEN.AddNew();
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //check các dk của dữ liệu đưa vào
            if (!ValidateForm()) return;
            dANGHIHOCCheckBox.Checked = false; // SET DA NGHI HOC = FALSE
            try
            {
                this.bdsSINHVIEN.EndEdit();
                this.bdsSINHVIEN.ResetCurrentItem();
                this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);

                if (state == "edit")
                {
                    undoStack.Push(string.Format("UPDATE SINHVIEN SET [HO] =N'{0}',[TEN] = N'{1}',[PHAI] = {2},[DIACHI] = N'{3}',[NGAYSINH] = '{4}',[DANGHIHOC] = {5} WHERE [MASV] = N'{6}'", sv.ho, sv.ten, sv.phai, sv.diaChi, sv.ngaySinh, sv.daNghiHoc, sv.maSV));
                }
            }
            catch (Exception ex)
            {
                bdsSINHVIEN.RemoveCurrent();
                XtraMessageBox.Show("Ghi dữ liệu thất lại. Vui lòng kiểm tra lại!\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //chỉnh sửa lại các trạng thái nút
            SetButtonState(false);
        }

        private void barButtonUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (undoStack.Count == 0) return;
            string command = undoStack.Pop();
            Program.ExecSqlNonQuery(command);
            LoadData();
            barButtonUndo.Enabled = undoStack.Count > 0;
        }


        private void barButtonEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsSINHVIEN.Position;
            state = "edit";
            SetButtonState(true);
        }

        private void barButtonHuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsSINHVIEN.CancelEdit();
            SetButtonState(false);
            LoadData();
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Utils.ChangeServer(cmbKhoa))
            {
                LoadData();
            }
        }

        private void barButtonRenew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadData();
            XtraMessageBox.Show("Làm mới dữ liệu thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBox_MaSV_TextChanged(object sender, EventArgs e)
        {
            TextBox_MaSV.CharacterCasing = CharacterCasing.Upper;
        }
        private void gridView2_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int phai = 0;
            int Nghihoc = 0;
            if (CheckBox_Phai.Checked)
            {
                phai = 1;
            }
            if (dANGHIHOCCheckBox.Checked)
            {
                Nghihoc = 1;
            }    
            try
            {
                String Malop = ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["MaLop"].ToString();
                sv = new SinhVienClass(TextBox_MaSV.Text.Trim(), TextBox_Ho.Text.Trim(), TextBox_Ten.Text.Trim(), phai.ToString(), dIACHITextBox.Text.Trim(), DateEdit_NgaySinh.DateTime.ToString("yyyy/MM/dd"), Nghihoc.ToString(), Malop);
            }
            catch { }
            
        }

        private void barButtonDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bds_DangKy.Count > 0)
            {
                XtraMessageBox.Show("Không thể xóa sinh viên đã đăng ký lớp tín chỉ.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa sinh viên này?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    position = bdsSINHVIEN.Position;
                    bdsSINHVIEN.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.ConnStr;
                    this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                    this.bdsSINHVIEN.ResetCurrentItem();

                    undoStack.Push(string.Format("INSERT INTO SINHVIEN([MASV],[HO],[TEN],[PHAI],[DIACHI],[NGAYSINH],[MALOP],[DANGHIHOC],[PASSWORD])VALUES(N'{0}',N'{1}',N'{2}',{3},N'{4}','{5}','{6}',{7},N'')", sv.maSV, sv.ho, sv.ten, sv.phai, sv.diaChi, sv.ngaySinh,sv.maLop,sv.daNghiHoc));
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show("Lỗi xóa sinh viên .\nMã lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                    //LopForm_Load(sender, e);
                    LoadData();
                }
                barButtonDelete.Enabled = bdsSINHVIEN.Count > 0;
                barButtonUndo.Enabled = undoStack.Count > 0;
            }


        }
    }
}
