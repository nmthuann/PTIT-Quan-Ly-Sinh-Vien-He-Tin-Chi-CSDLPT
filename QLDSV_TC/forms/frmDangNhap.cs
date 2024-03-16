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
                MessageBox.Show("Lỗi kết nối\n" + e.Message);
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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            /**
             * B1: username + pass is rỗng
             * B2: check lại Connect
             * B3: 
             */

            if (txtUsername.Text.Trim() == "" || txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Tài khoản và mật khẩu không hợp lệ", "", MessageBoxButtons.OK);
                return;
            }


            /**
             * get dữ liệu
             */
            Program.mlogin = txtUsername.Text.Trim();
            Program.password = txtPassword.Text.Trim();
            Program.mPhongBan = cmbPhongBan.SelectedIndex;
            Program.serverName = cmbPhongBan.SelectedValue.ToString();

            if (cbVaiTro.Checked)  // login - SV
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
            else // login - GV
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

            

            if (Program.myReader == null) return;
            Program.myReader.Read();
            try
            {
                Program.username = Program.myReader.GetString(0);
                if (Convert.IsDBNull(Program.username))
                {
                    MessageBox.Show(
                        "Login không có quyền truy cập dữ liệu", "", MessageBoxButtons.OK);
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
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ sos\n Vui long kiem tra lại \n" + ex.Message, "", MessageBoxButtons.OK);
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
