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
                barButtonTaoTaiKhoan.Enabled = true;
                barButtonThongTinCaNhan.Enabled = true;
                barButtonDangNhap.Enabled = false;
                ribbonPageQuanLy.Visible = true;
                ribbonPageGroupQuanLy.Enabled = true;
                ribbonPageBaoCao.Visible = true;
                ribbonPageGroupBaoCao.Enabled = true;
                barButtonLopTinChi.Enabled = true;
                barButtonDSLopTinChi.Enabled = true;
                barButtonDSSVDangKyLTC.Enabled = true;
                barButtonBangDiemMH.Enabled = true;
            }
            else if ((Program.mGroup.Equals("KHOA")))
            {
                barButtonTaoTaiKhoan.Enabled = true;
                barButtonThongTinCaNhan.Enabled = true;
                barButtonDangNhap.Enabled = false;
                ribbonPageQuanLy.Visible = true;
                ribbonPageGroupQuanLy.Enabled = true;
                barButtonLopTinChi.Enabled = true;
                barButtonDSSVDangKyLTC.Enabled = true;
                barButtonBangDiemMH.Enabled = true;

            }
            else if (Program.mGroup.Equals("SV"))
            {
                barButtonThongTinCaNhan.Enabled = true;
                barButtonThongTinCaNhan.Enabled = true;
                barButtonDangNhap.Enabled = false;
                ribbonPageSinhVien.Visible = true;
                ribbonPageGroupSinhVien.Enabled = true;
                barButtonDangKyLTC.Enabled = true;
                
            }
            else if (Program.mGroup.Equals("PKT"))
            {
                
                barButtonTaoTaiKhoan.Enabled = true;
                barButtonThongTinCaNhan.Enabled = true;
                barButtonDangNhap.Enabled = false;
                ribbonPageQuanLy.Visible = true;
                ribbonPageGroupQuanLy.Enabled = true;
                barButtonLopTinChi.Enabled = false;
                ribbonPageBaoCao.Visible = true;
                ribbonPageGroupBaoCao.Enabled = true;
                
                ribbonPageKeToan.Visible = true;
                ribbonPageGroupKeToan.Visible = true;
                barButtonHocPhi.Enabled = true;
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
                Program.bindingSource.RemoveFilter();
                enalbleButtonsInit();
                ribbonPageQuanLy.Visible = false;
                barButtonDangNhap.Enabled = true;
                Program.frmMain.toolStripStatusMa.Text = "Mã: ";
                Program.frmMain.toolStripStatusHoVaTen.Text = "Họ và Tên: ";
                Program.frmMain.toolStripStatusVaiTro.Text = "Vai trò: ";

            }

            //DialogResult dialog = XtraMessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo!", MessageBoxButtons.YesNo);
            //if (dialog == DialogResult.Yes)
            //{
            //    foreach (Form frm in this.MdiChildren)
            //        frm.Close();
            //    Program.frmMain.Dispose();
            //    Program.frmDangNhap.Visible = true;
            //    Program.bindingSource.RemoveFilter();
            //    Program.frmDangNhap.loadAgain();

            //}
        }

        private void barButtonLopTinChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.frmLopTinChi));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmLopTinChi = new frmLopTinChi();
                Program.frmLopTinChi.MdiParent = this;
                Program.frmLopTinChi.Show();
            }
        }

        private void barButtonMonHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.frmMonHoc));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmMonHoc = new frmMonHoc();
                Program.frmMonHoc.MdiParent = this;
                Program.frmMonHoc.Show();
            }
        }

        private void barButtonDangKyLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.frmDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmDangKyLTC = new frmDangKyLTC();
                Program.frmDangKyLTC.MdiParent = this;
                Program.frmDangKyLTC.Show();
            }
        }

        private void barButtonDSLopTinChi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.frmDanhSachLTC));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmDanhSachLTC = new frmDanhSachLTC();
                Program.frmDanhSachLTC.MdiParent = this;
                Program.frmDanhSachLTC.Show();
            }
        }

        private void barButtonDSSVDangKyLTC_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.frmDanhSachSVDaDangKyLTC));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmDanhSachSVDaDangKyLTC = new frmDanhSachSVDaDangKyLTC();
                Program.frmDanhSachSVDaDangKyLTC.MdiParent = this;
                Program.frmDanhSachSVDaDangKyLTC.Show();
            }
        }

        private void barButtonBangDiemMH_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.frmBangDiemHetMonLTC));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmBangDiemHetMonLTC = new frmBangDiemHetMonLTC();
                Program.frmBangDiemHetMonLTC.MdiParent = this;
                Program.frmBangDiemHetMonLTC.Show();
            }
        }

        private void barButtonHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.frmDongHocPhi));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmDongHocPhi = new frmDongHocPhi();
                Program.frmDongHocPhi.MdiParent = this;
                Program.frmDongHocPhi.Show();
            }
        }

        private void barButtonBangDiemTongKet_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.Xfrm_BangDiem_TongKetLop));
            if (frm != null) frm.Activate();
            else
            {
                Program.Xfrm_BangDiem_TongKetLop = new Xfrm_BangDiem_TongKetLop();
                Program.Xfrm_BangDiem_TongKetLop.MdiParent = this;
                Program.Xfrm_BangDiem_TongKetLop.Show();
            }
        }

        private void barButtonNhapDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.frmNhapDiem));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmNhapDiem = new frmNhapDiem();
                Program.frmNhapDiem.MdiParent = this;
                Program.frmNhapDiem.Show();
            }
        }

        private void barButtonDSDongHocPhi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.Xfrm_ReportHocPhiTheoLop));
            if (frm != null) frm.Activate();
            else
            {
                Program.Xfrm_ReportHocPhiTheoLop = new Xfrm_ReportHocPhiTheoLop();
                Program.Xfrm_ReportHocPhiTheoLop.MdiParent = this;
                Program.Xfrm_ReportHocPhiTheoLop.Show();
            }
        }

        private void barButtonXemDiem_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.frmXemDiem));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmXemDiem = new frmXemDiem();
                Program.frmXemDiem.MdiParent = this;
                Program.frmXemDiem.Show();
            }
        }

        private void barButtonLopHoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = CheckExists(typeof(forms.frmLopHoc));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmLopHoc = new frmLopHoc();
                Program.frmLopHoc.MdiParent = this;
                Program.frmLopHoc.Show();
            }
        }
    }



}