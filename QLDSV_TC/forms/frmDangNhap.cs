using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.forms
{
    public partial class frmDangNhap : Form
    {

        private SqlConnection connPublisher = new SqlConnection();
        private void getDanhSachPhanManh(String cmd)
        {
            //  check trạng thái Publisher
            if (connPublisher.State == ConnectionState.Closed)
            {
                connPublisher.Open();
            }
            DataTable dataTable = new DataTable();
            SqlDataAdapter  sqlDataAdapter = new SqlDataAdapter(cmd, connPublisher);
            sqlDataAdapter.Fill(dataTable);

            connPublisher.Close();
            Program.bindingSource.DataSource = dataTable;

            cmbPhongBan.DataSource = Program.bindingSource;
            cmbPhongBan.DisplayMember = "TENCN";
            cmbPhongBan.ValueMember = "TENSERVER";

        }

        public frmDangNhap()
        {
            InitializeComponent();
        }


        //private Form CheckExists(Type ftype)
        //{
        //    foreach (Form f in this.MdiChildren)
        //        if (f.GetType() == ftype)
        //            return f;
        //    return null;
        //}

        private void cmbPhongBan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private int KetNoiCoSoDuLieuGoc()
        {
            if (connPublisher != null && connPublisher.State == ConnectionState.Open)
                connPublisher.Close();
            try
            {
                connPublisher.ConnectionString = Program.constrPublisher;
                connPublisher.Open();
                return 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(
                       "Lỗi kết nối đến CSDL \n" + e.Message,
                       "Lỗi",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return 0;
            }
        }


        private void checkBoxHienPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHienPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            if (KetNoiCoSoDuLieuGoc() == 0)
                return;
            getDanhSachPhanManh("SELECT * FROM V_DS_PHANMANH");
            cmbPhongBan.SelectedIndex = 0;
            //cmbPhongBan.SelectedIndex = 1;
            //cmbPhongBan.SelectedIndex = 2;
            Program.serverName = cmbPhongBan.SelectedValue.ToString();
        }


        /// <summary>
        /// Phương thức xử lý sau khi click Btn Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            /**
             * B1: Check dữ liệu nhập vào
             * B2: Thực hiện Connect
             *  2.1 truy cập vào hệ thống với vai trò Sinh Viên
             *      - Sinh viên truy cập cùng 1 tài khoản Login "SV" trong CSDL (mức CSDL).
             *      -> truy cập vào Server thì dùng chung (login, password)
             *      - Call câu lệnh truy vấn để (mMaDangNhap, password) 
             *      -> để xác thực SV (mỗi SV chỉ có 1 mã SV) trong hệ thống (mức ứng dụng).
             *  2.2 truy cập vào hệ thống với vai trò Giảng Viên
             *      - GV được cấp một tài khoản login vào Server đã được phân quyền đúng với 
             *      quyền hạn sử dụng.
             * B3: Lấy Các thông tin cá nhân cần thiết phục vụ cho việc hiển thị
             *  - Mã
             *  - Họ Tên
             *  - Vai trò
             */
            
            // B1
            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show (
                        "Tài khoản và mật khẩu không được bỏ trống. Vui lòng nhập lại", 
                        "Thông báo", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning
                    );
                return;
            }


            // B2: 
            Program.mlogin = txtUsername.Text.Trim();
            Program.password = txtPassword.Text.Trim();
            Program.mPhongBan = cmbPhongBan.SelectedIndex;
            Program.serverName = cmbPhongBan.SelectedValue.ToString();

            // login - SV
            if (cbVaiTro.Checked)  
            {
               
                Program.mlogin = Program.LoginSinhVien; // LoginSinhVIen = SV
                Program.password = Program.PasswordSinhVien;
                
                if(Program.KetNoi() == 1) // the connection is successfull!
                {
                    Program.mMaDangNhap = txtUsername.Text.Trim();
                    Program.password = txtPassword.Text.Trim();

                    // Program.conn.Open();
                    string query =
                        "SELECT * " +
                        "FROM SINHVIEN WHERE " +
                        "MaSV = '" + Program.mMaDangNhap + "' AND PASSWORD = '" + Program.password + "'";
                    SqlDataReader check = Program.ExecSqlDataReader(query);
                    if (!check.HasRows)
                    {
                        Program.conn.Close();
                        MessageBox.Show(
                            "Sinh Viên đăng nhập thất bại", "", MessageBoxButtons.OK);
                        return;
                    }
                    else
                    {
                        Program.conn.Close();

                        String statement =
                        "EXEC SP_THONGTINDANGNHAP'" +
                        Program.mMaDangNhap + "', 'SV'";
                        Program.myReader = Program.ExecSqlDataReader(statement);
                    }
                   
                }
            }
            // login - GV
            else
            {
                Program.mlogin = txtUsername.Text.Trim();
                Program.password = txtPassword.Text.Trim();
                Program.mloginDN = Program.mlogin;
                Program.passwordDN = Program.password;
                if (Program.KetNoi() == 0) return;
                String statement =
                "EXEC SP_THONGTINDANGNHAP'" +
                Program.mlogin + "', 'GV'";
                Program.myReader = Program.ExecSqlDataReader(statement);
            }


            //  B3:
            if (Program.myReader == null) return;
            Program.myReader.Read();
            try
            {
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {  
                    MessageBox.Show(
                            "Login không có quyền truy cập dữ liệu. Vui lòng kiểm tra lại", 
                            "Thông báo", 
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Warning
                        );
                    return;
                }
                Program.mHoten = Program.myReader.GetString(1);
                Program.mGroup = Program.myReader.GetString(2);
                Program.myReader.Close();

                this.Visible = false;
                // Program.frmMain = new frmMain();
               
                Program.frmMain.toolStripStatusMa.Text = "Mã: " + Program.username;
                Program.frmMain.toolStripStatusHoVaTen.Text = "Họ và tên: " + Program.mHoten;
                Program.frmMain.toolStripStatusVaiTro.Text = "Vai trò: " + Program.mGroup;
                Program.frmMain.enalbleButtonsAfterLogin();
                // Thread.Sleep(500);
                // Program.frmMain.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        "Tài khoản hoặc mật khẩu không hợp lệ sos\n Vui long kiem tra lại \n" + ex.Message, 
                        "Lỗi", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error
                    );
                return;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbVaiTro_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVaiTro.Checked)
            {
                lbTaiKhoan.Text = "Mã Sinh Viên";
            }
            else
            {
                lbTaiKhoan.Text = "Tài khoản";
            }
        }


        //public void loadAgain()
        //{
        //    cmbPhongBan.SelectedItem = Program.mGroup;
        //    Program.serverName = cmbPhongBan.SelectedValue.ToString();
        //    txtUsername.Text = null;
        //    txtPassword.Text = null;
        //    txtUsername.Focus();
        //}
    }
}
