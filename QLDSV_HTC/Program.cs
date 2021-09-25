using DevExpress.Skins;
using DevExpress.UserSkins;
using DevExpress.XtraEditors;
using QLDSV_HTC.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_HTC
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// // dùng để thực thi lệnh
        public static SqlCommand Sqlcmd = new SqlCommand();

        // tạo đối tượng kết nối Conn , kêt nối Database bằng mã lệnh
        public static SqlConnection Conn = new SqlConnection();

        // chuỗi kết nối connection string để kết nối với csdl , nó bước đầu tiên để thực hiện kết nối      
        public static string ConnStr;

        public static SqlDataReader MyReader;

        // Tên máy tính
        public static string DataSource = Environment.MachineName;

        // những dòng này dùng trong phần tạo connection string ở bên dưới
        public static string ServerName = string.Empty;
        public static string ServerLogin = string.Empty;
        public static string ServerPassword = string.Empty;

        // RemoteLogin này là remote dùng để hỗ trợ kết nối ra ngoài ví dụ trong quá trình đăng nhập nó sẽ rẽ qua server 2
        // để đăng nhập truy vấn dữ liệu thì nó dùng login này để kết nối(hay là tạo link server)
        // vì nó giống nhau trên các phân mảnh là HTKN nối nó sẽ gán cứng vào.
        public static string RemoteLogin = "HTKN";
        public static string RemotePassword = "123456";
        public static string Database = "QLDSV_TC";


        /**
         * Thông tin authentication 
         */
        public static string AuthUserID = string.Empty;
        public static string AuthLogin = string.Empty;
        public static string AuthPassword = string.Empty;
        public static string AuthGroup = string.Empty;
        public static string AuthHoten = string.Empty;


        /**
         * Thông tin Khoa đã đăng nhập (VT-CNTT-PKT)
         */
        public static string MaKhoa = "";

        //biến dùng để chứa danh sách các phân mảnh
        public static BindingSource Bds_Dspm = new BindingSource(); //giu DSPM khi dang nhap

        // lưu các đối tượng form Main và form Login để thực hiển xử lý nghiệp vụ chuyển đổi từ Main sang Login và ngược lại.
        public static MainForm MainForm;
        public static LoginForm LoginForm;

        // lưu danh sách các nhóm quyền
        public static string[] NhomQuyen = new string[4] { "PGV", "KHOA", "SV", "PKT" };

        // hàm thực hiện kết nối tới Database
        public static void KetNoi()
        {
            if (Program.Conn != null && Program.Conn.State == ConnectionState.Open)
                // đóng đối tượng kết nối
                Program.Conn.Close();


            Program.ConnStr = string.Format("Data Source={0};Initial Catalog={1};User ID={2};Password={3}", Program.ServerName, Program.Database, Program.ServerLogin, Program.ServerPassword);
            Program.Conn.ConnectionString = Program.ConnStr;

            // mở đối tượng kết nối
            Program.Conn.Open();
        }


        // ExecSqlDataReader tôc độ tải về nhanh hơn ExecSqlDataTable vì đối tượng nó chỉ quam tân chỉ select
        // chỉ duyệt 1 chiều từ trên xuống
        // vì vậy trong nghiệp vụ form báo cáo thì dùng datareader
        // https://youtu.be/z8pgdIbtV3E?t=3233

        public static SqlDataReader ExecSqlDataReader(string strLenh)
        {
            SqlDataReader myReader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.Conn);

            //xác định kiểu lệnh cho sqlcmd là kiểu text.
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
            try
            {
                myReader = sqlcmd.ExecuteReader();
                return myReader;
            }
            catch (SqlException ex)
            {
                Program.Conn.Close();
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // tải về cho phép xem xóa sửa ==> tốc độ tải chậm hơn cái ở trên
        // duyệt 2 chiều dưới lên
        // form nhập liệu thì dùng datatable.

        public static DataTable ExecSqlDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            if (Program.Conn.State == ConnectionState.Closed) Program.Conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, Conn);
            da.Fill(dt);
            Conn.Close();
            return dt;
        }


        public static int ExecSqlNonQuery(string strlenh)
        {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, Conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600; // 10 phut
            if (Conn.State == ConnectionState.Closed) Conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); 
                Conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(strlenh);
                XtraMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Conn.Close();
                return ex.State;
            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Program.LoginForm = new LoginForm();
            Application.Run(Program.LoginForm);
        }
    }
}
