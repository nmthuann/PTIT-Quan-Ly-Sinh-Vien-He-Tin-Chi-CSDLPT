using DevExpress.XtraBars;
using DevExpress.XtraReports.UI;
using QLDSV_TC.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.forms
{
    public partial class Xfrm_Report_BangDiemSV : Form
    {
        public Xfrm_Report_BangDiemSV()
        {
            InitializeComponent();
        }

        private void Xfrm_Report_BangDiemSV_Load(object sender, EventArgs e)
        {
            Program.bindingSource.Filter = "TENCN not LIKE 'Tra cứu học phí%'  ";
            cbKhoa.DataSource = Program.bindingSource;
            cbKhoa.DisplayMember = "TENCN";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mPhongBan;
            if (Program.mGroup == "PGV")
                cbKhoa.Enabled = true;
        }

        private void cbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.serverName = cbKhoa.SelectedValue.ToString();
            if (cbKhoa.SelectedIndex != Program.mPhongBan)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePass;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (tbMaSV.Text.Length > 10)
            {
                MessageBox.Show("Mã sinh viên không hợp lệ.", "Thông Báo", MessageBoxButtons.OK);
                tbMaSV.Focus();
            }
            else
            {
                try
                {

                    Report_PhieuDiemTheoSinhVien rpt = new Report_PhieuDiemTheoSinhVien(tbMaSV.Text);
                    rpt.lbTD.Text = "KHOA " + cbKhoa.Text.ToUpper();
                    rpt.lbSV.Text = "Bảng Điểm Sinh Viên: " + tbMaSV.Text;

                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Sinh viên không tồn tại \n " + ex.Message);
                    tbMaSV.Focus();
                }

            }
        }

        private void tbMaSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
