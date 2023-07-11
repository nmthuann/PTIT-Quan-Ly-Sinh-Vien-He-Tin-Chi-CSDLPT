
namespace QLDSV_TC.forms
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.barButtonLopHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonMonHoc = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonLopTinChi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonNhapDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDangKyLTC = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonXemDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonXemHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDangNhap = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonTaoTaiKhoan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonHuongDan = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDSLopTinChi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDSSVDangKyLTC = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonBangDiemMH = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonPhieuDiem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonDSDongHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonBangDiemTongKet = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonLopHoc,
            this.barButtonMonHoc,
            this.barButtonLopTinChi,
            this.barButtonNhapDiem,
            this.barButtonDangKyLTC,
            this.barButtonXemDiem,
            this.barButtonXemHocPhi,
            this.barButtonDangNhap,
            this.barButtonTaoTaiKhoan,
            this.barButtonDangXuat,
            this.barButtonHuongDan,
            this.barButtonDSLopTinChi,
            this.barButtonDSSVDangKyLTC,
            this.barButtonBangDiemMH,
            this.barButtonPhieuDiem,
            this.barButtonDSDongHocPhi,
            this.barButtonBangDiemTongKet});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 22;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(1138, 193);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupQuanLy});
            this.ribbonPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage1.ImageOptions.Image")));
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản Lý";
            // 
            // ribbonPageGroupQuanLy
            // 
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barButtonLopHoc);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barButtonMonHoc);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barButtonLopTinChi);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barButtonNhapDiem);
            this.ribbonPageGroupQuanLy.Name = "ribbonPageGroupQuanLy";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 689);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1138, 30);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage2.ImageOptions.Image")));
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Báo cáo";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonDSLopTinChi);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonDSSVDangKyLTC);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonBangDiemMH);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonPhieuDiem);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonDSDongHocPhi);
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonBangDiemTongKet);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage3.ImageOptions.Image")));
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Sinh Viên";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonDangKyLTC);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonXemDiem);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonXemHocPhi);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPage4.ImageOptions.Image")));
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Hệ thống";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonDangNhap);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonTaoTaiKhoan);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonDangXuat);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonHuongDan);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // barButtonLopHoc
            // 
            this.barButtonLopHoc.Caption = "Lớp học";
            this.barButtonLopHoc.Id = 1;
            this.barButtonLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonLopHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonLopHoc.Name = "barButtonLopHoc";
            // 
            // barButtonMonHoc
            // 
            this.barButtonMonHoc.Caption = "Môn học";
            this.barButtonMonHoc.Id = 2;
            this.barButtonMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonMonHoc.Name = "barButtonMonHoc";
            // 
            // barButtonLopTinChi
            // 
            this.barButtonLopTinChi.Caption = "Lớp tín chỉ";
            this.barButtonLopTinChi.Id = 3;
            this.barButtonLopTinChi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonLopTinChi.Name = "barButtonLopTinChi";
            // 
            // barButtonNhapDiem
            // 
            this.barButtonNhapDiem.Caption = "Nhập điểm";
            this.barButtonNhapDiem.Id = 4;
            this.barButtonNhapDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonNhapDiem.Name = "barButtonNhapDiem";
            // 
            // barButtonDangKyLTC
            // 
            this.barButtonDangKyLTC.Caption = "Đăng lý lớp tín chỉ";
            this.barButtonDangKyLTC.Id = 5;
            this.barButtonDangKyLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image1")));
            this.barButtonDangKyLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage1")));
            this.barButtonDangKyLTC.Name = "barButtonDangKyLTC";
            // 
            // barButtonXemDiem
            // 
            this.barButtonXemDiem.Caption = "Xem Điểm";
            this.barButtonXemDiem.Id = 6;
            this.barButtonXemDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image1")));
            this.barButtonXemDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage1")));
            this.barButtonXemDiem.Name = "barButtonXemDiem";
            // 
            // barButtonXemHocPhi
            // 
            this.barButtonXemHocPhi.Caption = "Xem Học Phí";
            this.barButtonXemHocPhi.Id = 7;
            this.barButtonXemHocPhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage1")));
            this.barButtonXemHocPhi.Name = "barButtonXemHocPhi";
            // 
            // barButtonDangNhap
            // 
            this.barButtonDangNhap.Caption = "Đăng nhập";
            this.barButtonDangNhap.Id = 8;
            this.barButtonDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage1")));
            this.barButtonDangNhap.Name = "barButtonDangNhap";
            // 
            // barButtonTaoTaiKhoan
            // 
            this.barButtonTaoTaiKhoan.Caption = "Tạo Tài Khoản";
            this.barButtonTaoTaiKhoan.Id = 9;
            this.barButtonTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonTaoTaiKhoan.Name = "barButtonTaoTaiKhoan";
            // 
            // barButtonDangXuat
            // 
            this.barButtonDangXuat.Caption = "Đăng Xuất";
            this.barButtonDangXuat.Id = 10;
            this.barButtonDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonDangXuat.Name = "barButtonDangXuat";
            // 
            // barButtonHuongDan
            // 
            this.barButtonHuongDan.Caption = "Hướng dẫn";
            this.barButtonHuongDan.Id = 11;
            this.barButtonHuongDan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonHuongDan.Name = "barButtonHuongDan";
            // 
            // barButtonDSLopTinChi
            // 
            this.barButtonDSLopTinChi.Caption = "Danh Sách Lớp Tín Chỉ";
            this.barButtonDSLopTinChi.Id = 12;
            this.barButtonDSLopTinChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image2")));
            this.barButtonDSLopTinChi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage2")));
            this.barButtonDSLopTinChi.Name = "barButtonDSLopTinChi";
            // 
            // barButtonDSSVDangKyLTC
            // 
            this.barButtonDSSVDangKyLTC.Caption = "Danh Sách Sinh Viên Đăng Ký Lớp Tín Chỉ";
            this.barButtonDSSVDangKyLTC.Id = 13;
            this.barButtonDSSVDangKyLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image2")));
            this.barButtonDSSVDangKyLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage2")));
            this.barButtonDSSVDangKyLTC.Name = "barButtonDSSVDangKyLTC";
            // 
            // barButtonBangDiemMH
            // 
            this.barButtonBangDiemMH.Caption = "Bảng Điểm Môn Học";
            this.barButtonBangDiemMH.Id = 14;
            this.barButtonBangDiemMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonBangDiemMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.LargeImage")));
            this.barButtonBangDiemMH.Name = "barButtonBangDiemMH";
            // 
            // barButtonPhieuDiem
            // 
            this.barButtonPhieuDiem.Caption = "Phiếu Điểm";
            this.barButtonPhieuDiem.Id = 15;
            this.barButtonPhieuDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonPhieuDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.LargeImage")));
            this.barButtonPhieuDiem.Name = "barButtonPhieuDiem";
            // 
            // barButtonDSDongHocPhi
            // 
            this.barButtonDSDongHocPhi.Caption = "Danh Sách Đóng Học Phí";
            this.barButtonDSDongHocPhi.Id = 16;
            this.barButtonDSDongHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.Image")));
            this.barButtonDSDongHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem5.ImageOptions.LargeImage")));
            this.barButtonDSDongHocPhi.Name = "barButtonDSDongHocPhi";
            // 
            // barButtonBangDiemTongKet
            // 
            this.barButtonBangDiemTongKet.Caption = "Bảng Điểm Tổng Kết";
            this.barButtonBangDiemTongKet.Id = 17;
            this.barButtonBangDiemTongKet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.Image")));
            this.barButtonBangDiemTongKet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem6.ImageOptions.LargeImage")));
            this.barButtonBangDiemTongKet.Name = "barButtonBangDiemTongKet";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 719);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN TÍN CHỈ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonLopHoc;
        private DevExpress.XtraBars.BarButtonItem barButtonMonHoc;
        private DevExpress.XtraBars.BarButtonItem barButtonLopTinChi;
        private DevExpress.XtraBars.BarButtonItem barButtonNhapDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonDangKyLTC;
        private DevExpress.XtraBars.BarButtonItem barButtonXemDiem;
        private DevExpress.XtraBars.BarButtonItem barButtonXemHocPhi;
        private DevExpress.XtraBars.BarButtonItem barButtonDangNhap;
        private DevExpress.XtraBars.BarButtonItem barButtonTaoTaiKhoan;
        private DevExpress.XtraBars.BarButtonItem barButtonDangXuat;
        private DevExpress.XtraBars.BarButtonItem barButtonHuongDan;
        private DevExpress.XtraBars.BarButtonItem barButtonDSLopTinChi;
        private DevExpress.XtraBars.BarButtonItem barButtonDSSVDangKyLTC;
        private DevExpress.XtraBars.BarButtonItem barButtonBangDiemMH;
        private DevExpress.XtraBars.BarButtonItem barButtonPhieuDiem;
        private DevExpress.XtraBars.BarButtonItem barButtonDSDongHocPhi;
        private DevExpress.XtraBars.BarButtonItem barButtonBangDiemTongKet;
    }
}