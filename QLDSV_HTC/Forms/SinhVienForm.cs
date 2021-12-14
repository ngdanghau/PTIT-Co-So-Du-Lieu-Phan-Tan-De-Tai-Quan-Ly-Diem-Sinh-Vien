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
    public partial class SinhVienForm : DevExpress.XtraEditors.XtraForm
    {
        private int position = -1;
        private int position2 = -1;
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
        private Boolean CheckMaSV(String maSV)
        {
            String query = String.Format("EXEC sp_KiemTraMaSV @MaSV = {0}", maSV);
            int check = Program.ExecSqlNonQuery(query);
            if (check == 1)
                return true;
            return false;
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
                    = cmbKhoa.Enabled
                    //= panelControl1.Enabled
                    = !value;

                barButtonHuy.Enabled
                    = barButtonSave.Enabled
                    = panelControl3.Enabled
                    = TextBox_MaSV.ReadOnly
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
                    = cmbKhoa.Enabled
                    //= panelControl1.Enabled
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
            pASSWORDTextEdit.Visible
            = dANGHIHOCCheckBox.Visible
            = NghiHoc_Label.Visible
            = false;
            barButtonDelete.Enabled = barButtonEdit.Enabled = bdsSINHVIEN.Count > 0;
            
            if(position2 > 0 )
            {
                if(position2 <= lOPBindingSource.Count)
                lOPBindingSource.Position = position2;           
            }

            if(position > 0 )
            {
                if (position <= bdsSINHVIEN.Count)
                    bdsSINHVIEN.Position = position;
                else
                    bdsSINHVIEN.Position = position = 0;
            }

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
            if(barButtonUndo.Enabled)
            {
                String message = "Dữ liệu bạn vừa sửa sẽ không thể hoàn tác! Bạn có xác nhận thoát.";
                DialogResult dr = XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No) return;
            }else if(barButtonHuy.Enabled)
            {
                String message = "Dữ liệu bạn đang sửa sẽ bị hủy! Bạn có xác nhận thoát.";
                DialogResult dr = XtraMessageBox.Show(message, "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.No) return;
            }
            
            this.Close();
        }


        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            position = bdsSINHVIEN.Position;
            position2 = lOPBindingSource.Position;
            state = "add";  
            SetButtonState(true);
            TextBox_MaSV.Focus();
            bdsSINHVIEN.AddNew();
            CheckBox_Phai.Checked = false;
        }

        private void barButtonSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //check các dk của dữ liệu đưa vào
            if (!ValidateForm()) return;
            if (state == "add" && CheckMaSV(TextBox_MaSV.Text) )
            {
                TextBox_MaSV.Focus();
                return;
            }
            dANGHIHOCCheckBox.Checked = false; // SET DA NGHI HOC = FALSE
            pASSWORDTextEdit.Text = "123456";
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
            position2 = lOPBindingSource.Position;
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
            position = 0;
            position2 = 0;
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
            
            if (XtraMessageBox.Show("Bạn có thực sự muốn xóa sinh viên này?", "Xác nhận.", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (bds_DangKy.Count > 0)
                {
                    try
                    {
                        position = bdsSINHVIEN.Position;
                        position2 = lOPBindingSource.Position;
                        ((DataRowView)bdsSINHVIEN[bdsSINHVIEN.Position])["DANGHIHOC"] = true;
                        
                        bdsSINHVIEN.EndEdit();
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.ConnStr;
                        this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                        this.bdsSINHVIEN.ResetCurrentItem();
                        undoStack.Push(string.Format("UPDATE SINHVIEN SET [DANGHIHOC] ='False' WHERE [MASV] = '{0}'",TextBox_MaSV.Text ));
                        
                        XtraMessageBox.Show("Sinh viên đã được thay đổi thành đã nghỉ học, do đã đăng ký lớp tín chỉ nên không thể xóa.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa sinh viên .\nMã lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        //LopForm_Load(sender, e);
                        LoadData();
                    }
                }
                else
                {
                    try
                    {
                        position = bdsSINHVIEN.Position;
                        position2 = lOPBindingSource.Position;
                        bdsSINHVIEN.RemoveCurrent();
                        this.sINHVIENTableAdapter.Connection.ConnectionString = Program.ConnStr;
                        this.sINHVIENTableAdapter.Update(this.dS.SINHVIEN);
                        this.bdsSINHVIEN.ResetCurrentItem();

                        undoStack.Push(string.Format("INSERT INTO SINHVIEN([MASV],[HO],[TEN],[PHAI],[DIACHI],[NGAYSINH],[MALOP],[DANGHIHOC],[PASSWORD])VALUES(N'{0}',N'{1}',N'{2}',{3},N'{4}','{5}','{6}',{7},N'123456')", sv.maSV, sv.ho, sv.ten, sv.phai, sv.diaChi, sv.ngaySinh, sv.maLop, sv.daNghiHoc));
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Lỗi xóa sinh viên .\nMã lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK);
                        //LopForm_Load(sender, e);
                        LoadData();
                    }
                }
                LoadData();
                barButtonDelete.Enabled = bdsSINHVIEN.Count > 0;
                barButtonUndo.Enabled = undoStack.Count > 0;
            }


        }

        private void GC_Lop_Click(object sender, EventArgs e)
        {

        }

       

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(bdsSINHVIEN.Count>0)
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
        }
    }
}
