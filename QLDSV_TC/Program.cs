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

        //  public static Cấu hình hệ thống
        public static SqlConnection conn = new SqlConnection();
        public static String connstr;
        public static SqlCommand sqlcmd = new SqlCommand();
        public static SqlDataReader myReader;
        public static String constr_publisher = 
            "Data Source=MT-LAPTOP-ESHFI;Initial Catalog=QLDSV_TC;User ID=sa;Password=123456";
        public static BindingSource bdsDSPM = new BindingSource();//dùng để giữ ds phân mảnh khi login
        public static String database = "QLDSV_TC";

        //  public static Login Server
        public static String serverName = "";
        public static String username = ""; 
        public static String mlogin = "";
        public static String password = "";

        public static String remoteLogin = "HTKN"; //kết nối site khác
        public static String remotePass = "123456"; //kết nối site khác
        
        //public static String mloginDN = ""; //loginname hiện tại
        //public static String passDN = "";//pass hiện tại
        


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


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new forms.frmMain());
        }


    }
}
