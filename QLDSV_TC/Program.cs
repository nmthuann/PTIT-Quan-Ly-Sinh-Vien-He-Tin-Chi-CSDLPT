using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDSV_TC
{
    static class Program
    {
        /**
         * 
         * 
         *
         */

        // public static Cấu hình hệ thống
        // Thay đổi đường dẫn datasource của tôi thành đg dẫn của bạn 
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlCommand sqlcmd = new SqlCommand();
        public static SqlDataReader myReader;
        public static String constrPublisher =
            "Data Source=MT-LAPTOP-ESHFI;Initial Catalog=QLDSV_TC;User ID=sa;Password=123456";
        
        public static BindingSource bindingSource = new BindingSource();//dùng để giữ ds phân mảnh khi login
        public static String database = "QLDSV_TC";

        //  public static Login Server
        public static String serverName = "";
        public static String username = ""; 
        public static String mlogin = "";
        public static String password = "";

        public static String remoteLogin = "HTKN"; //kết nối site khác
        public static String remotePass = "123456"; //kết nối site khác

        public static String mloginDN = ""; //loginname hiện tại
        public static String passwordDN = "";//pass hiện tại



        //  public static nhóm quyền Sinh viên
        public static String LoginSinhVien = "SV";
        public static String PasswordSinhVien = "123456";


        //  public static Thông tin Login
        public static String mMaDangNhap = "";
        public static String mHoten = "";
        public static String mGroup = ""; //  PGV || KHOA || PKT || SV



        // public static khác 
        public static int mPhongBan = 0;//khoa cntt hay vt
        public static int chiPhi = 480000;  //tiền học/1 tín



        //  public static cho Winform
        public static forms.frmMain frmMain;
        public static forms.frmDangNhap frmDangNhap;
        public static forms.frmLopTinChi frmLopTinChi;
        public static forms.frmMonHoc frmMonHoc;
        public static forms.frmDangKyLTC frmDangKyLTC;
        public static forms.frmDanhSachLTC frmDanhSachLTC;
        public static forms.frmDanhSachSVDaDangKyLTC frmDanhSachSVDaDangKyLTC;
        public static forms.frmBangDiemHetMonLTC frmBangDiemHetMonLTC;
        public static forms.frmDongHocPhi frmDongHocPhi;
        public static forms.frmNhapDiem frmNhapDiem;
        public static forms.frmXemDiem frmXemDiem;
        public static forms.frmLopHoc frmLopHoc;

        public static forms.Xfrm_BangDiem_TongKetLop Xfrm_BangDiem_TongKetLop;
        public static forms.Xfrm_ReportHocPhiTheoLop Xfrm_ReportHocPhiTheoLop;
        public static forms.Xfrm_Report_BangDiemSV Xfrm_Report_BangDiemSV;

        
        //  public static Function 
        /**
         *  1. KetNoi(): int
         *  2. ExecSqlDataReader(String cmd): SqlDataReader
         *  3. ExecSqlDataTable (String cmd): DataTable
         *  4. ExecSqlNonQuery(String strLenh): int
         *  5. ...
         */


        /**
         * @return trả về 1 nếu thành công
         *         trả về 0 nếu thất bại
         */
        public static int KetNoi()
        { // bool flag=true

            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = 
                    "Data Source=" + Program.serverName + ";Initial Catalog=" +
                       Program.database + ";User ID=" +
                       Program.mlogin + ";password=" + Program.password;

                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();

                return 1;
            }

            catch (Exception e)
            {
                //if (flag == true)
                //{
                    MessageBox.Show(
                    "Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " +
                    e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                //}
                return 0;
                //MessageBox.Show(
                //    "Lỗi kết nối cơ sở dữ liệu.\nXem lại tài khoản và mật khẩu.\n " +
                //    e.Message, "", MessageBoxButtons.OK);
                ////Console.WriteLine(e.Message);
                //return 0;
            }
        }


        /**
         * ExecSqlDataTable thực hiện câu lệnh mà dữ liệu trả về có thể
         * xem - thêm - xóa - sửa tùy ý
         */
        public static SqlDataReader ExecSqlDataReader(String strLenh) {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            if (Program.conn.State == ConnectionState.Closed)
                Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); 
                return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message,"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }


        /**
         * ExecSqlDataTable thực hiện câu lệnh mà dữ liệu trả về có thể
         * xem - thêm - xóa - sửa tùy ý
         */
        public static DataTable ExecSqlDataTable(String cmd) {
            DataTable dt = new DataTable();
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            SqlDataAdapter da = new SqlDataAdapter(cmd, conn);
            da.Fill(dt);
            conn.Close();
            return dt;
        }


        /**
         * Cập nhật trên một stored procedure 
         * và không trả về giá trị 
         */
        public static int ExecSqlNonQuery(String strlenh) {
            SqlCommand Sqlcmd = new SqlCommand(strlenh, conn);
            Sqlcmd.CommandType = CommandType.Text;
            Sqlcmd.CommandTimeout = 600;// 10 phut
            if (conn.State == ConnectionState.Closed) conn.Open();
            try
            {
                Sqlcmd.ExecuteNonQuery(); conn.Close();
                return 0;
            }
            catch (SqlException ex)
            {
                if (ex.Message.Contains("Error converting data type varchar to int"))
                    MessageBox.Show(
                            "Bạn format Cell lại cột \"Ngày Thi\" qua kiểu Number hoặc mở File Excel.", 
                            "Thông báo", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning
                        );
                else MessageBox.Show(ex.Message);
                conn.Close();
                return ex.State;

            }
        }



            /// <summary>
            /// The main entry point for the application.
            /// </summary>
            [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //// Program.frmMain = new forms.frmMain();
            //Program.frmDangNhap = new forms.frmDangNhap();
            //// frmMain.enalbleButtonsInit();
            //Application.Run(frmDangNhap);

            frmMain = new forms.frmMain();
            // frmMain.enalbleButtonsInit();
            //frmDangNhap = new forms.frmDangNhap();
            //Application.Run(frmDangNhap);

            Application.Run(frmMain);

        }


    }
}
