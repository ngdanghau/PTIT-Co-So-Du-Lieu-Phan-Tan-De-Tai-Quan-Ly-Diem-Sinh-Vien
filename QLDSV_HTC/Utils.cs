using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    class Utils
    {
        public static bool ChangeServer(System.Windows.Forms.ComboBox cmbKhoa)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return false;
            // đoạn code hỗ trợ chuyển chi nhánh
            // ở chi nhánh A qua B thì dùng RemoteLogin,
            if (cmbKhoa.SelectedValue.ToString() != Program.AuthServerName)
            {
                Program.ServerLogin = Program.RemoteLogin;
                Program.ServerPassword = Program.RemotePassword;
            }
            else
            { // ở B về lại A dùng login ban đầu
                Program.ServerLogin = Program.AuthLogin;
                Program.ServerPassword = Program.AuthPassword;
            }

            Program.ServerName = cmbKhoa.SelectedValue.ToString();
            Program.MaKhoa = Utils.GetMaKhoa(cmbKhoa.Text);
            try
            {
                Program.KetNoi();
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "Lỗi kết nối!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static string GetMaKhoa(string tenkhoa)
        {
            string ShortName = "";
            Array.ForEach(tenkhoa.Split(' '), s => ShortName += s[0]);
            return ShortName;
        }

        public static void LoadComboBox(System.Windows.Forms.ComboBox cmbServer, Object dt)
        {
            try
            {
                DataTable datatable = (DataTable)dt;
                cmbServer.DataSource = datatable;
            }
            catch {
                cmbServer.DataSource = dt;
            }
            cmbServer.DisplayMember = "TENKHOA";
            cmbServer.ValueMember = "TENSERVER";
            cmbServer.SelectedIndex = 0;
        }
    }
}
