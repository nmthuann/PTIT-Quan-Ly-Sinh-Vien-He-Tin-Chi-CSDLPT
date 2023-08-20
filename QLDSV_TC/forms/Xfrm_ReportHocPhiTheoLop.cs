using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;
using QLDSV_TC.Reports;


namespace QLDSV_TC.forms
{
    public partial class Xfrm_ReportHocPhiTheoLop : Form
    {
        public Xfrm_ReportHocPhiTheoLop()
        {
            InitializeComponent();
        }

        private void Xfrm_ReportHocPhiTheoLop_Load(object sender, EventArgs e)
        {

        }
        private String tenkhoa = "";

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            if (tbMaLop.Text.Length > 10)
            {
                MessageBox.Show("Mã lớp không hợp lệ.", "Thông Báo", MessageBoxButtons.OK);
                tbMaLop.Focus();
            }
            else
            {

                try
                {
                    string cmd = "exec SP3_GETKHOA_BYLOP '" + tbMaLop.Text.Trim() + "'";
                    DataTable dt = Program.ExecSqlDataTable(cmd);
                    tenkhoa = dt.Rows[0][0].ToString();
                    Report_HocPhiTheoLop rpt = new Report_HocPhiTheoLop(tbMaLop.Text, cbNIENKHOA.Text, int.Parse(cbHOCKY.Text));
                    rpt.lbKHOA.Text = "KHOA : " + tenkhoa.ToUpper();
                    rpt.lbMALOP.Text = "Mã Lớp: " + tbMaLop.Text.ToUpper();
                    ReportPrintTool print = new ReportPrintTool(rpt);
                    print.ShowPreviewDialog();

                }
                catch
                {
                    MessageBox.Show("Thông tin lớp học không hợp lệ.", "Thông Báo", MessageBoxButtons.OK);
                    tbMaLop.Focus();
                }

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
