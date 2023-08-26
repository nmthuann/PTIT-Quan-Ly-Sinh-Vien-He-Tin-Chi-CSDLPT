using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using QLDSV_TC.Reports;

namespace QLDSV_TC.forms
{
    public partial class frmDanhSachLTC : Form
    {
        public frmDanhSachLTC()
        {
            InitializeComponent();
        }

        private void frmDanhSachLTC_Load(object sender, EventArgs e)
        {
            qLDSV_TC_DataSet.EnforceConstraints = false;

            // TODO: This line of code loads data into the 'qLDSV_TC_DataSet.DANHSACHKHOA' table. You can move, or remove it, as needed.
            this.dANHSACHKHOATableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANHSACHKHOATableAdapter.Fill(this.qLDSV_TC_DataSet.DANHSACHKHOA);
            // TODO: This line of code loads data into the 'qLDSV_TC_DataSet.KHOA' table. You can move, or remove it, as needed.
           


            
        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaKhoa.Text = cmbKhoa.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
           
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            //  int manv = int.Parse(txtManv.Text);
            string maKhoa = txtMaKhoa.Text.Trim();
            string NienKhoa = cmbNienKhoa.Text.Trim();
            int HocKy = int.Parse(speHocKy.Text);
            Report_DanhSachLopTinChi rpt = new Report_DanhSachLopTinChi(maKhoa,NienKhoa,HocKy);

           // rpt.lblTieuDe.Text = “DANH SÁCH PHIẾU “ +cmbLoai.Text.ToUpper() + “ NHÂN VIÊN LẬP TRONG NĂM “ +cmbNam.Text;
            
            rpt.xrlbKhoaValue.Text = cmbKhoa.Text.Trim();
            rpt.xrlbNienKhoaValue.Text = cmbNienKhoa.Text;
            rpt.xrlbHocKyValue.Text = speHocKy.Text;
            rpt.xrlbTenGVLap.Text = Program.mHoten;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
