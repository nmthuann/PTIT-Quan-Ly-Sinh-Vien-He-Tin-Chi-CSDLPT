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
    public partial class frmBangDiemHetMonLTC : Form
    {
        public frmBangDiemHetMonLTC()
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


            // TODO: This line of code loads data into the 'qLDSV_TC_DataSet.MONHOC' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'qLDSV_TC_DataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_TC_DataSet.MONHOC);

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
            string nienKhoa = cmbNienKhoa.Text.Trim();
            int hocKy = int.Parse(speHocKy.Text);
            string maMH = txtMaMH.Text.Trim();
            int nhom = int.Parse(speNhom.Text);
            string maKhoa = txtMaKhoa.Text.Trim();

            
            
            Report_BangDiemMonHocLTC rpt = new Report_BangDiemMonHocLTC(
                nienKhoa, 
                hocKy,
                maMH,
                nhom
                //maKhoa
                );

            
            rpt.xrlbKhoaValue.Text = cmbKhoa.Text.Trim();
            rpt.xrlbNienKhoaValue.Text = cmbNienKhoa.Text;
            rpt.xrlbHocKyValue.Text = speHocKy.Text;
            rpt.xrlbMonHoc.Text = cmbTenMH.Text.Trim();
            rpt.xrlbNhom.Text = speNhom.Text;


            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtMaMH_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTenMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtMaMH.Text = cmbTenMH.SelectedValue.ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
