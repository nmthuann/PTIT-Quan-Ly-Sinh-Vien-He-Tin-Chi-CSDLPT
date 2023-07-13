using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.forms
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        //public object s { get; internal set; }

        public frmMain()
        {
            InitializeComponent();
            enalbleButtonsInit();
            // enalbleButtonsAfterLogin();
            
        }


        private Form CheckExists(Type ftype) {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }


        private void barButtonDangNhap_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form f = this.CheckExists(typeof(frmDangNhap));
            if (f != null)
            {
                f.Activate();
            }
            else
            {
                frmDangNhap form = new frmDangNhap();
                form.MdiParent = this;
                form.Show();
                
            }
        }


        public void enalbleButtonsInit()
        {
            barButtonDangNhap.Enabled = true;
            barButtonHuongDan.Enabled = true;
            barButtonDangXuat.Enabled = false;
            barButtonTaoTaiKhoan.Enabled = false;
            barButtonThongTinCaNhan.Enabled = false;
        }


        public void enalbleButtonsAfterLogin()
        {
            barButtonDangXuat.Enabled = true;
            if (Program.mGroup.Equals("PGV"))
            {
                //ribbonQuanLyKhoa_PGV.Visible = true;
                //ribbonQuanLyKhoa_PGV.Enabled = true;
                //reportPagePGV_Khoa.Visible = true;
                //reportPagePGV_Khoa.Enabled = true;
                //barBtnTaoLogin.Enabled = true;
                ribbonPageQuanLy.Visible = true;
                //ribbonPageGroupQuanLy.Visible = true;
            }
            else if ((Program.mGroup.Equals("KHOA")))
            {
                //ribbonQuanLyKhoa_PGV.Visible = true;
                //ribbonQuanLyKhoa_PGV.Enabled = true;
                //reportPagePGV_Khoa.Visible = true;
                //reportPagePGV_Khoa.Enabled = true;
                //barBtnTaoLogin.Enabled = true;
                ribbonPageQuanLy.Visible = true;
                ribbonPageGroupQuanLy.Visible = true;
                // ribbon.SelectedPage = ribbonPageQuanLy;
            }
            else if (Program.mGroup.Equals("SINHVIEN"))
            {
                //ribbonPageSinhVien.Visible = true;
                //ribbonPageBaoCao.Visible = false;
                //ribbonPageQuanLy.Visible = false;
                //barBtnTaoLogin.Visibility = BarItemVisibility.Never;
                ribbon.SelectedPage = ribbonPageSinhVien;
            }
            else if (Program.mGroup.Equals("PKT"))
            {
                //ribbonQuanLyPKT.Visible = true;
                //ribbonQuanLyPKT.Enabled = true;
                //reportPagePKT.Visible = true;
                //reportPagePKT.Enabled = true;
                //barBtnTaoLogin.Enabled = true;
            }
        }

        public void enalbleButtonsInRibbonPageHeThong()
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void barButtonHuongDan_ItemClick(object sender, ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng HƯỚNG DẪN chưa hoàn thành!");
        }

        private void toolStripStatusMa_Click(object sender, EventArgs e)
        {

        }

        public void toolStripStatusHoVaTen_Click(object sender, EventArgs e)
        {

        }

        public void toolStripStatusVaiTro_Click(object sender, EventArgs e)
        {

        }

        private void barButtonDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                foreach (Form frm in this.MdiChildren)
                    frm.Close();
                //Program.frmM.Dispose();
                //Program.frmLogin.Visible = true;
                Program.bindingSource.RemoveFilter();
                // Program.frmMain.loadAgain();
                barButtonDangXuat.Enabled = false;
                ribbonPageQuanLy.Visible = false;

            }
        }
    }



}