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
    public partial class Xfrm_BangDiem_TongKetLop : Form
    {
        public Xfrm_BangDiem_TongKetLop()
        {
            InitializeComponent();
            if (Program.mGroup == "PGV")
                cbKhoa.Enabled = true;
        }

     
        

        private void Xfrm_BangDiem_TongKetLop_Load(object sender, EventArgs e)
        {
            Program.bindingSource.Filter = "TENCN not LIKE 'Tra cứu học phí%'  ";
            cbKhoa.DataSource = Program.bindingSource;
            cbKhoa.DisplayMember = "TENCN";
            cbKhoa.ValueMember = "TENSERVER";
            cbKhoa.SelectedIndex = Program.mPhongBan;

            qLDSV_TCDataSet.EnforceConstraints = false;
            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

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
            else
            {
                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            Report_BangDiem_TongKet_Lop rpt = new Report_BangDiem_TongKet_Lop(this.cbMaLop.ToString());
            rpt.lbLop.Text = "Lớp" + cbMaLop.Text + "- Niên khóa" + ((DataRowView)bdsLop[bdsLop.Position])["KHOAHOC"].ToString();
            rpt.lbKhoa.Text = "Khoa " + cbKhoa.Text;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
