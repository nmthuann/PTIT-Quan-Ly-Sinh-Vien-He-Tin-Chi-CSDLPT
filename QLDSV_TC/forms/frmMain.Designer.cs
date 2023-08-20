
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
            this.barButtonThongTinCaNhan = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticMa = new DevExpress.XtraBars.BarStaticItem();
            this.barButtonHocPhi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPageQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupQuanLy = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageKeToan = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupKeToan = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupBaoCao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupSinhVien = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStripThongTin = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusMa = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusHoVaTen = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusVaiTro = new System.Windows.Forms.ToolStripStatusLabel();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.toolStripContainer1.SuspendLayout();
            this.statusStripThongTin.SuspendLayout();
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
            this.barButtonBangDiemTongKet,
            this.barButtonThongTinCaNhan,
            this.barStaticMa,
            this.barButtonHocPhi});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(10);
            this.ribbon.MaxItemId = 29;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPageQuanLy,
            this.ribbonPageKeToan,
            this.ribbonPageBaoCao,
            this.ribbonPageSinhVien,
            this.ribbonPageHeThong});
            this.ribbon.Size = new System.Drawing.Size(1137, 193);
            // 
            // barButtonLopHoc
            // 
            this.barButtonLopHoc.Caption = "Lớp học";
            this.barButtonLopHoc.Id = 1;
            this.barButtonLopHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonLopHoc.ImageOptions.Image")));
            this.barButtonLopHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonLopHoc.ImageOptions.LargeImage")));
            this.barButtonLopHoc.Name = "barButtonLopHoc";
            this.barButtonLopHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLopHoc_ItemClick);
            // 
            // barButtonMonHoc
            // 
            this.barButtonMonHoc.Caption = "Môn học";
            this.barButtonMonHoc.Id = 2;
            this.barButtonMonHoc.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonMonHoc.ImageOptions.Image")));
            this.barButtonMonHoc.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonMonHoc.ImageOptions.LargeImage")));
            this.barButtonMonHoc.Name = "barButtonMonHoc";
            this.barButtonMonHoc.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonMonHoc_ItemClick);
            // 
            // barButtonLopTinChi
            // 
            this.barButtonLopTinChi.Caption = "Lớp tín chỉ";
            this.barButtonLopTinChi.Id = 3;
            this.barButtonLopTinChi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonLopTinChi.ImageOptions.SvgImage")));
            this.barButtonLopTinChi.Name = "barButtonLopTinChi";
            this.barButtonLopTinChi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonLopTinChi_ItemClick);
            // 
            // barButtonNhapDiem
            // 
            this.barButtonNhapDiem.Caption = "Nhập điểm";
            this.barButtonNhapDiem.Id = 4;
            this.barButtonNhapDiem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonNhapDiem.ImageOptions.SvgImage")));
            this.barButtonNhapDiem.Name = "barButtonNhapDiem";
            this.barButtonNhapDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonNhapDiem_ItemClick);
            // 
            // barButtonDangKyLTC
            // 
            this.barButtonDangKyLTC.Caption = "Đăng lý lớp tín chỉ";
            this.barButtonDangKyLTC.Id = 5;
            this.barButtonDangKyLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonDangKyLTC.ImageOptions.Image")));
            this.barButtonDangKyLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonDangKyLTC.ImageOptions.LargeImage")));
            this.barButtonDangKyLTC.Name = "barButtonDangKyLTC";
            this.barButtonDangKyLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDangKyLTC_ItemClick);
            // 
            // barButtonXemDiem
            // 
            this.barButtonXemDiem.Caption = "Xem Điểm";
            this.barButtonXemDiem.Id = 6;
            this.barButtonXemDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonXemDiem.ImageOptions.Image")));
            this.barButtonXemDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonXemDiem.ImageOptions.LargeImage")));
            this.barButtonXemDiem.Name = "barButtonXemDiem";
            this.barButtonXemDiem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonXemDiem_ItemClick);
            // 
            // barButtonXemHocPhi
            // 
            this.barButtonXemHocPhi.Caption = "Xem Học Phí";
            this.barButtonXemHocPhi.Id = 7;
            this.barButtonXemHocPhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonXemHocPhi.ImageOptions.SvgImage")));
            this.barButtonXemHocPhi.Name = "barButtonXemHocPhi";
            // 
            // barButtonDangNhap
            // 
            this.barButtonDangNhap.Caption = "Đăng nhập";
            this.barButtonDangNhap.Id = 8;
            this.barButtonDangNhap.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonDangNhap.ImageOptions.SvgImage")));
            this.barButtonDangNhap.Name = "barButtonDangNhap";
            this.barButtonDangNhap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDangNhap_ItemClick);
            // 
            // barButtonTaoTaiKhoan
            // 
            this.barButtonTaoTaiKhoan.Caption = "Tạo Tài Khoản";
            this.barButtonTaoTaiKhoan.Id = 9;
            this.barButtonTaoTaiKhoan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonTaoTaiKhoan.ImageOptions.SvgImage")));
            this.barButtonTaoTaiKhoan.Name = "barButtonTaoTaiKhoan";
            // 
            // barButtonDangXuat
            // 
            this.barButtonDangXuat.Caption = "Đăng Xuất";
            this.barButtonDangXuat.Id = 10;
            this.barButtonDangXuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonDangXuat.ImageOptions.SvgImage")));
            this.barButtonDangXuat.Name = "barButtonDangXuat";
            this.barButtonDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDangXuat_ItemClick);
            // 
            // barButtonHuongDan
            // 
            this.barButtonHuongDan.Caption = "Hướng dẫn";
            this.barButtonHuongDan.Id = 11;
            this.barButtonHuongDan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonHuongDan.ImageOptions.SvgImage")));
            this.barButtonHuongDan.Name = "barButtonHuongDan";
            this.barButtonHuongDan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHuongDan_ItemClick);
            // 
            // barButtonDSLopTinChi
            // 
            this.barButtonDSLopTinChi.Caption = "Danh Sách Lớp Tín Chỉ";
            this.barButtonDSLopTinChi.Id = 12;
            this.barButtonDSLopTinChi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonDSLopTinChi.ImageOptions.Image")));
            this.barButtonDSLopTinChi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonDSLopTinChi.ImageOptions.LargeImage")));
            this.barButtonDSLopTinChi.Name = "barButtonDSLopTinChi";
            this.barButtonDSLopTinChi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDSLopTinChi_ItemClick);
            // 
            // barButtonDSSVDangKyLTC
            // 
            this.barButtonDSSVDangKyLTC.Caption = "Danh Sách Sinh Viên Đăng Ký Lớp Tín Chỉ";
            this.barButtonDSSVDangKyLTC.Id = 13;
            this.barButtonDSSVDangKyLTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonDSSVDangKyLTC.ImageOptions.Image")));
            this.barButtonDSSVDangKyLTC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonDSSVDangKyLTC.ImageOptions.LargeImage")));
            this.barButtonDSSVDangKyLTC.Name = "barButtonDSSVDangKyLTC";
            this.barButtonDSSVDangKyLTC.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDSSVDangKyLTC_ItemClick);
            // 
            // barButtonBangDiemMH
            // 
            this.barButtonBangDiemMH.Caption = "Bảng Điểm Môn Học";
            this.barButtonBangDiemMH.Id = 14;
            this.barButtonBangDiemMH.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonBangDiemMH.ImageOptions.Image")));
            this.barButtonBangDiemMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonBangDiemMH.ImageOptions.LargeImage")));
            this.barButtonBangDiemMH.Name = "barButtonBangDiemMH";
            this.barButtonBangDiemMH.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonBangDiemMH_ItemClick);
            // 
            // barButtonPhieuDiem
            // 
            this.barButtonPhieuDiem.Caption = "Phiếu Điểm";
            this.barButtonPhieuDiem.Id = 15;
            this.barButtonPhieuDiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonPhieuDiem.ImageOptions.Image")));
            this.barButtonPhieuDiem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonPhieuDiem.ImageOptions.LargeImage")));
            this.barButtonPhieuDiem.Name = "barButtonPhieuDiem";
            // 
            // barButtonDSDongHocPhi
            // 
            this.barButtonDSDongHocPhi.Caption = "Danh Sách Đóng Học Phí";
            this.barButtonDSDongHocPhi.Id = 16;
            this.barButtonDSDongHocPhi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonDSDongHocPhi.ImageOptions.Image")));
            this.barButtonDSDongHocPhi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonDSDongHocPhi.ImageOptions.LargeImage")));
            this.barButtonDSDongHocPhi.Name = "barButtonDSDongHocPhi";
            this.barButtonDSDongHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonDSDongHocPhi_ItemClick);
            // 
            // barButtonBangDiemTongKet
            // 
            this.barButtonBangDiemTongKet.Caption = "Bảng Điểm Tổng Kết";
            this.barButtonBangDiemTongKet.Id = 17;
            this.barButtonBangDiemTongKet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonBangDiemTongKet.ImageOptions.Image")));
            this.barButtonBangDiemTongKet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonBangDiemTongKet.ImageOptions.LargeImage")));
            this.barButtonBangDiemTongKet.Name = "barButtonBangDiemTongKet";
            this.barButtonBangDiemTongKet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonBangDiemTongKet_ItemClick);
            // 
            // barButtonThongTinCaNhan
            // 
            this.barButtonThongTinCaNhan.Caption = "Thông tin cá nhân";
            this.barButtonThongTinCaNhan.Id = 22;
            this.barButtonThongTinCaNhan.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonThongTinCaNhan.ImageOptions.SvgImage")));
            this.barButtonThongTinCaNhan.Name = "barButtonThongTinCaNhan";
            // 
            // barStaticMa
            // 
            this.barStaticMa.Id = 26;
            this.barStaticMa.Name = "barStaticMa";
            // 
            // barButtonHocPhi
            // 
            this.barButtonHocPhi.Caption = "Học Phí";
            this.barButtonHocPhi.Id = 27;
            this.barButtonHocPhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonHocPhi.ImageOptions.SvgImage")));
            this.barButtonHocPhi.Name = "barButtonHocPhi";
            this.barButtonHocPhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonHocPhi_ItemClick);
            // 
            // ribbonPageQuanLy
            // 
            this.ribbonPageQuanLy.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupQuanLy});
            this.ribbonPageQuanLy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageQuanLy.ImageOptions.Image")));
            this.ribbonPageQuanLy.Name = "ribbonPageQuanLy";
            this.ribbonPageQuanLy.Text = "Quản Lý";
            this.ribbonPageQuanLy.Visible = false;
            // 
            // ribbonPageGroupQuanLy
            // 
            this.ribbonPageGroupQuanLy.Enabled = false;
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barButtonLopHoc);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barButtonMonHoc);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barButtonLopTinChi);
            this.ribbonPageGroupQuanLy.ItemLinks.Add(this.barButtonNhapDiem);
            this.ribbonPageGroupQuanLy.Name = "ribbonPageGroupQuanLy";
            // 
            // ribbonPageKeToan
            // 
            this.ribbonPageKeToan.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupKeToan});
            this.ribbonPageKeToan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageKeToan.ImageOptions.Image")));
            this.ribbonPageKeToan.Name = "ribbonPageKeToan";
            this.ribbonPageKeToan.Text = "Kế Toán";
            this.ribbonPageKeToan.Visible = false;
            // 
            // ribbonPageGroupKeToan
            // 
            this.ribbonPageGroupKeToan.ItemLinks.Add(this.barButtonHocPhi);
            this.ribbonPageGroupKeToan.Name = "ribbonPageGroupKeToan";
            this.ribbonPageGroupKeToan.Text = "Phòng Kế Toán";
            // 
            // ribbonPageBaoCao
            // 
            this.ribbonPageBaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupBaoCao});
            this.ribbonPageBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageBaoCao.ImageOptions.Image")));
            this.ribbonPageBaoCao.Name = "ribbonPageBaoCao";
            this.ribbonPageBaoCao.Text = "Báo cáo";
            this.ribbonPageBaoCao.Visible = false;
            // 
            // ribbonPageGroupBaoCao
            // 
            this.ribbonPageGroupBaoCao.Enabled = false;
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.barButtonDSLopTinChi);
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.barButtonDSSVDangKyLTC);
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.barButtonBangDiemMH);
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.barButtonPhieuDiem);
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.barButtonDSDongHocPhi);
            this.ribbonPageGroupBaoCao.ItemLinks.Add(this.barButtonBangDiemTongKet);
            this.ribbonPageGroupBaoCao.Name = "ribbonPageGroupBaoCao";
            // 
            // ribbonPageSinhVien
            // 
            this.ribbonPageSinhVien.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupSinhVien});
            this.ribbonPageSinhVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageSinhVien.ImageOptions.Image")));
            this.ribbonPageSinhVien.Name = "ribbonPageSinhVien";
            this.ribbonPageSinhVien.Text = "Sinh Viên";
            this.ribbonPageSinhVien.Visible = false;
            // 
            // ribbonPageGroupSinhVien
            // 
            this.ribbonPageGroupSinhVien.Enabled = false;
            this.ribbonPageGroupSinhVien.ItemLinks.Add(this.barButtonDangKyLTC);
            this.ribbonPageGroupSinhVien.ItemLinks.Add(this.barButtonXemDiem);
            this.ribbonPageGroupSinhVien.ItemLinks.Add(this.barButtonXemHocPhi);
            this.ribbonPageGroupSinhVien.Name = "ribbonPageGroupSinhVien";
            // 
            // ribbonPageHeThong
            // 
            this.ribbonPageHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPageHeThong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPageHeThong.ImageOptions.Image")));
            this.ribbonPageHeThong.Name = "ribbonPageHeThong";
            this.ribbonPageHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonDangNhap);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonThongTinCaNhan);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonTaoTaiKhoan);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonDangXuat);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonHuongDan);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(150, 150);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(150, 175);
            this.toolStripContainer1.TabIndex = 0;
            // 
            // statusStripThongTin
            // 
            this.statusStripThongTin.DataBindings.Add(new System.Windows.Forms.Binding("Name", global::QLDSV_TC.Properties.Settings.Default, "statusStripThongTin", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.statusStripThongTin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripThongTin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusMa,
            this.toolStripStatusHoVaTen,
            this.toolStripStatusVaiTro});
            this.statusStripThongTin.Location = new System.Drawing.Point(0, 693);
            this.statusStripThongTin.Name = global::QLDSV_TC.Properties.Settings.Default.statusStripThongTin;
            this.statusStripThongTin.Size = new System.Drawing.Size(1137, 26);
            this.statusStripThongTin.TabIndex = 2;
            this.statusStripThongTin.Text = "statusStrip1";
            // 
            // toolStripStatusMa
            // 
            this.toolStripStatusMa.AccessibleName = "toolStripStatusMa";
            this.toolStripStatusMa.Name = "toolStripStatusMa";
            this.toolStripStatusMa.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripStatusMa.Size = new System.Drawing.Size(33, 20);
            this.toolStripStatusMa.Text = "Mã:";
            this.toolStripStatusMa.Click += new System.EventHandler(this.toolStripStatusMa_Click);
            // 
            // toolStripStatusHoVaTen
            // 
            this.toolStripStatusHoVaTen.Name = "toolStripStatusHoVaTen";
            this.toolStripStatusHoVaTen.Size = new System.Drawing.Size(79, 20);
            this.toolStripStatusHoVaTen.Text = "Họ Và Tên:";
            this.toolStripStatusHoVaTen.Click += new System.EventHandler(this.toolStripStatusHoVaTen_Click);
            // 
            // toolStripStatusVaiTro
            // 
            this.toolStripStatusVaiTro.Name = "toolStripStatusVaiTro";
            this.toolStripStatusVaiTro.Size = new System.Drawing.Size(55, 20);
            this.toolStripStatusVaiTro.Text = "Vai trò:";
            this.toolStripStatusVaiTro.Click += new System.EventHandler(this.toolStripStatusVaiTro_Click);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Học Phí";
            this.barButtonItem2.Id = 27;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 719);
            this.Controls.Add(this.statusStripThongTin);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.Text = "QUẢN LÝ ĐIỂM SINH VIÊN TÍN CHỈ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStripThongTin.ResumeLayout(false);
            this.statusStripThongTin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageQuanLy;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupQuanLy;
        private DevExpress.XtraBars.BarButtonItem barButtonLopHoc;
        private DevExpress.XtraBars.BarButtonItem barButtonMonHoc;
        private DevExpress.XtraBars.BarButtonItem barButtonLopTinChi;
        private DevExpress.XtraBars.BarButtonItem barButtonNhapDiem;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupBaoCao;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupSinhVien;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageHeThong;
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
        private DevExpress.XtraBars.BarButtonItem barButtonThongTinCaNhan;
        private System.Windows.Forms.ToolStripStatusLabel MA;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private DevExpress.XtraBars.BarStaticItem barStaticMa;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStripThongTin;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusMa;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusHoVaTen;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusVaiTro;
        private DevExpress.XtraBars.BarButtonItem barButtonHocPhi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupKeToan;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        public DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageKeToan;
    }
}