
namespace QLDSV_TC.forms
{
    partial class frmLopTinChi
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label mAKHOALabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label lbHocKy;
            System.Windows.Forms.Label mAGVLabel;
            System.Windows.Forms.Label mAMHLabel;
            System.Windows.Forms.Label sOSVTOITHIEULabel;
            System.Windows.Forms.Label nHOMLabel;
            System.Windows.Forms.Label mAGVLabel1;
            System.Windows.Forms.Label mAMHLabel1;
            System.Windows.Forms.Label hUYLOPLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLopTinChi));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barThanhNutLenh = new DevExpress.XtraBars.Bar();
            this.btnThem = new DevExpress.XtraBars.BarButtonItem();
            this.btnXoa = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnSua = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnGhi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.btnThoat = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControlThongTinLTC = new DevExpress.XtraEditors.PanelControl();
            this.cbHuyLop = new System.Windows.Forms.CheckBox();
            this.bdsLTC = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet = new QLDSV_TC.QLDSV_TCDataSet();
            this.txtMaMonHoc = new DevExpress.XtraEditors.TextEdit();
            this.txtMaGiangVien = new DevExpress.XtraEditors.TextEdit();
            this.speNhom = new DevExpress.XtraEditors.SpinEdit();
            this.speSoSVToiThieu = new DevExpress.XtraEditors.SpinEdit();
            this.cmbTenMonHoc = new System.Windows.Forms.ComboBox();
            this.vDSMONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TCDataSet_LTC = new QLDSV_TC.QLDSV_TCDataSet_LTC();
            this.cmbTenGV = new System.Windows.Forms.ComboBox();
            this.vDSGIANGVIENBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.speHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.txtMaKhoa = new DevExpress.XtraEditors.TextEdit();
            this.labelThongTinLTC = new System.Windows.Forms.Label();
            this.cmbeNienKhoa = new DevExpress.XtraEditors.ComboBoxEdit();
            this.bdsGiangVien = new System.Windows.Forms.BindingSource(this.components);
            this.bdsMonHoc = new System.Windows.Forms.BindingSource(this.components);
            this.vDSGIANGVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LTCTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager();
            this.lOPTINCHIGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridViewLTC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMALTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNIENKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOCKY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNHOM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAGV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHOA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOSVTOITHIEU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHUYLOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gIANGVIENTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.GIANGVIENTableAdapter();
            this.mONHOCTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter();
            this.v_DS_GIANGVIENTableAdapter = new QLDSV_TC.QLDSV_TCDataSet_LTCTableAdapters.V_DS_GIANGVIENTableAdapter();
            this.v_DS_MONHOCTableAdapter = new QLDSV_TC.QLDSV_TCDataSet_LTCTableAdapters.V_DS_MONHOCTableAdapter();
            this.bdsDangKy = new System.Windows.Forms.BindingSource(this.components);
            this.dANGKYTableAdapter = new QLDSV_TC.QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter();
            mAKHOALabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            lbHocKy = new System.Windows.Forms.Label();
            mAGVLabel = new System.Windows.Forms.Label();
            mAMHLabel = new System.Windows.Forms.Label();
            sOSVTOITHIEULabel = new System.Windows.Forms.Label();
            nHOMLabel = new System.Windows.Forms.Label();
            mAGVLabel1 = new System.Windows.Forms.Label();
            mAMHLabel1 = new System.Windows.Forms.Label();
            hUYLOPLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlThongTinLTC)).BeginInit();
            this.panelControlThongTinLTC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMonHoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGiangVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speNhom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSoSVToiThieu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSMONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet_LTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSGIANGVIENBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbeNienKhoa.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSGIANGVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).BeginInit();
            this.SuspendLayout();
            // 
            // mAKHOALabel
            // 
            mAKHOALabel.AutoSize = true;
            mAKHOALabel.Location = new System.Drawing.Point(126, 88);
            mAKHOALabel.Name = "mAKHOALabel";
            mAKHOALabel.Size = new System.Drawing.Size(39, 17);
            mAKHOALabel.TabIndex = 16;
            mAKHOALabel.Text = "Khoa";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Location = new System.Drawing.Point(696, 84);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(69, 17);
            nIENKHOALabel.TabIndex = 17;
            nIENKHOALabel.Text = "Niên Khóa";
            // 
            // lbHocKy
            // 
            lbHocKy.AutoSize = true;
            lbHocKy.Location = new System.Drawing.Point(126, 140);
            lbHocKy.Name = "lbHocKy";
            lbHocKy.Size = new System.Drawing.Size(52, 17);
            lbHocKy.TabIndex = 18;
            lbHocKy.Text = "Học Kỳ";
            // 
            // mAGVLabel
            // 
            mAGVLabel.AutoSize = true;
            mAGVLabel.Location = new System.Drawing.Point(696, 186);
            mAGVLabel.Name = "mAGVLabel";
            mAGVLabel.Size = new System.Drawing.Size(71, 17);
            mAGVLabel.TabIndex = 20;
            mAGVLabel.Text = "Giảng Viên";
            // 
            // mAMHLabel
            // 
            mAMHLabel.AutoSize = true;
            mAMHLabel.Location = new System.Drawing.Point(696, 230);
            mAMHLabel.Name = "mAMHLabel";
            mAMHLabel.Size = new System.Drawing.Size(62, 17);
            mAMHLabel.TabIndex = 21;
            mAMHLabel.Text = "Môn Học";
            // 
            // sOSVTOITHIEULabel
            // 
            sOSVTOITHIEULabel.AutoSize = true;
            sOSVTOITHIEULabel.Location = new System.Drawing.Point(120, 271);
            sOSVTOITHIEULabel.Name = "sOSVTOITHIEULabel";
            sOSVTOITHIEULabel.Size = new System.Drawing.Size(103, 17);
            sOSVTOITHIEULabel.TabIndex = 22;
            sOSVTOITHIEULabel.Text = "Số SV Tối Thiểu";
            // 
            // nHOMLabel
            // 
            nHOMLabel.AutoSize = true;
            nHOMLabel.Location = new System.Drawing.Point(697, 139);
            nHOMLabel.Name = "nHOMLabel";
            nHOMLabel.Size = new System.Drawing.Size(45, 17);
            nHOMLabel.TabIndex = 23;
            nHOMLabel.Text = "Nhóm";
            // 
            // mAGVLabel1
            // 
            mAGVLabel1.AutoSize = true;
            mAGVLabel1.Location = new System.Drawing.Point(126, 186);
            mAGVLabel1.Name = "mAGVLabel1";
            mAGVLabel1.Size = new System.Drawing.Size(92, 17);
            mAGVLabel1.TabIndex = 24;
            mAGVLabel1.Text = "Mã Giảng Viên";
            // 
            // mAMHLabel1
            // 
            mAMHLabel1.AutoSize = true;
            mAMHLabel1.Location = new System.Drawing.Point(126, 228);
            mAMHLabel1.Name = "mAMHLabel1";
            mAMHLabel1.Size = new System.Drawing.Size(83, 17);
            mAMHLabel1.TabIndex = 25;
            mAMHLabel1.Text = "Mã Môn Học";
            // 
            // hUYLOPLabel
            // 
            hUYLOPLabel.AutoSize = true;
            hUYLOPLabel.Location = new System.Drawing.Point(696, 271);
            hUYLOPLabel.Name = "hUYLOPLabel";
            hUYLOPLabel.Size = new System.Drawing.Size(60, 17);
            hUYLOPLabel.TabIndex = 26;
            hUYLOPLabel.Text = "Hủy Lớp";
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barThanhNutLenh});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnXoa,
            this.btnSua,
            this.btnReload,
            this.btnGhi,
            this.btnThoat,
            this.btnUndo,
            this.btnThem});
            this.barManager1.MainMenu = this.barThanhNutLenh;
            this.barManager1.MaxItemId = 12;
            // 
            // barThanhNutLenh
            // 
            this.barThanhNutLenh.BarName = "Main menu";
            this.barThanhNutLenh.DockCol = 0;
            this.barThanhNutLenh.DockRow = 0;
            this.barThanhNutLenh.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barThanhNutLenh.FloatLocation = new System.Drawing.Point(126, 407);
            this.barThanhNutLenh.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThem),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnXoa),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnSua),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnUndo),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnReload),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGhi),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnThoat)});
            this.barThanhNutLenh.OptionsBar.MinHeight = 30;
            this.barThanhNutLenh.OptionsBar.MultiLine = true;
            this.barThanhNutLenh.OptionsBar.UseWholeRow = true;
            this.barThanhNutLenh.Text = "Main menu";
            // 
            // btnThem
            // 
            this.btnThem.Caption = "Thêm";
            this.btnThem.Enabled = false;
            this.btnThem.Id = 11;
            this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
            this.btnThem.Name = "btnThem";
            this.btnThem.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnThem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThem_ItemClick);
            // 
            // btnXoa
            // 
            this.btnXoa.Caption = "Xóa";
            this.btnXoa.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnXoa.Enabled = false;
            this.btnXoa.Id = 1;
            this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnXoa_ItemClick);
            // 
            // btnSua
            // 
            this.btnSua.Caption = "Sửa";
            this.btnSua.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnSua.Enabled = false;
            this.btnSua.Id = 2;
            this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
            this.btnSua.Name = "btnSua";
            this.btnSua.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSua_ItemClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục hồi";
            this.btnUndo.Enabled = false;
            this.btnUndo.Id = 10;
            this.btnUndo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUndo.ImageOptions.SvgImage")));
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnUndo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUndo_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Reload";
            this.btnReload.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnReload.Enabled = false;
            this.btnReload.Id = 3;
            this.btnReload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReload.ImageOptions.SvgImage")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // btnGhi
            // 
            this.btnGhi.Caption = "Ghi";
            this.btnGhi.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnGhi.Enabled = false;
            this.btnGhi.Id = 4;
            this.btnGhi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGhi.ImageOptions.SvgImage")));
            this.btnGhi.Name = "btnGhi";
            this.btnGhi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGhi_ItemClick);
            // 
            // btnThoat
            // 
            this.btnThoat.Caption = "Thoát";
            this.btnThoat.CaptionAlignment = DevExpress.XtraBars.BarItemCaptionAlignment.Right;
            this.btnThoat.Id = 5;
            this.btnThoat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThoat.ImageOptions.SvgImage")));
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnThoat_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlTop.Size = new System.Drawing.Size(1523, 50);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1055);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlBottom.Size = new System.Drawing.Size(1523, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 50);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 1005);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1523, 50);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 1005);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbKhoa);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 50);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1523, 81);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKhoa.Enabled = false;
            this.cmbKhoa.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(191, 35);
            this.cmbKhoa.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(610, 29);
            this.cmbKhoa.TabIndex = 3;
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "KHOA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelControlThongTinLTC
            // 
            this.panelControlThongTinLTC.Controls.Add(hUYLOPLabel);
            this.panelControlThongTinLTC.Controls.Add(this.cbHuyLop);
            this.panelControlThongTinLTC.Controls.Add(mAMHLabel1);
            this.panelControlThongTinLTC.Controls.Add(this.txtMaMonHoc);
            this.panelControlThongTinLTC.Controls.Add(this.txtMaGiangVien);
            this.panelControlThongTinLTC.Controls.Add(mAGVLabel1);
            this.panelControlThongTinLTC.Controls.Add(nHOMLabel);
            this.panelControlThongTinLTC.Controls.Add(this.speNhom);
            this.panelControlThongTinLTC.Controls.Add(sOSVTOITHIEULabel);
            this.panelControlThongTinLTC.Controls.Add(this.speSoSVToiThieu);
            this.panelControlThongTinLTC.Controls.Add(mAMHLabel);
            this.panelControlThongTinLTC.Controls.Add(this.cmbTenMonHoc);
            this.panelControlThongTinLTC.Controls.Add(mAGVLabel);
            this.panelControlThongTinLTC.Controls.Add(this.cmbTenGV);
            this.panelControlThongTinLTC.Controls.Add(lbHocKy);
            this.panelControlThongTinLTC.Controls.Add(this.speHocKy);
            this.panelControlThongTinLTC.Controls.Add(nIENKHOALabel);
            this.panelControlThongTinLTC.Controls.Add(mAKHOALabel);
            this.panelControlThongTinLTC.Controls.Add(this.txtMaKhoa);
            this.panelControlThongTinLTC.Controls.Add(this.labelThongTinLTC);
            this.panelControlThongTinLTC.Controls.Add(this.cmbeNienKhoa);
            this.panelControlThongTinLTC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlThongTinLTC.Enabled = false;
            this.panelControlThongTinLTC.Location = new System.Drawing.Point(0, 713);
            this.panelControlThongTinLTC.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.panelControlThongTinLTC.Name = "panelControlThongTinLTC";
            this.panelControlThongTinLTC.Size = new System.Drawing.Size(1523, 342);
            this.panelControlThongTinLTC.TabIndex = 8;
            // 
            // cbHuyLop
            // 
            this.cbHuyLop.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.bdsLTC, "HUYLOP", true));
            this.cbHuyLop.Location = new System.Drawing.Point(811, 264);
            this.cbHuyLop.Name = "cbHuyLop";
            this.cbHuyLop.Size = new System.Drawing.Size(104, 24);
            this.cbHuyLop.TabIndex = 27;
            this.cbHuyLop.UseVisualStyleBackColor = true;
            // 
            // bdsLTC
            // 
            this.bdsLTC.DataMember = "LOPTINCHI";
            this.bdsLTC.DataSource = this.qLDSV_TCDataSet;
            // 
            // qLDSV_TCDataSet
            // 
            this.qLDSV_TCDataSet.DataSetName = "QLDSV_TCDataSet";
            this.qLDSV_TCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMaMonHoc
            // 
            this.txtMaMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "MAMH", true));
            this.txtMaMonHoc.Location = new System.Drawing.Point(246, 224);
            this.txtMaMonHoc.MenuManager = this.barManager1;
            this.txtMaMonHoc.Name = "txtMaMonHoc";
            this.txtMaMonHoc.Properties.ReadOnly = true;
            this.txtMaMonHoc.Size = new System.Drawing.Size(125, 22);
            this.txtMaMonHoc.TabIndex = 26;
            this.txtMaMonHoc.EditValueChanged += new System.EventHandler(this.txtMaMonHoc_EditValueChanged);
            // 
            // txtMaGiangVien
            // 
            this.txtMaGiangVien.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "MAGV", true));
            this.txtMaGiangVien.Location = new System.Drawing.Point(246, 180);
            this.txtMaGiangVien.MenuManager = this.barManager1;
            this.txtMaGiangVien.Name = "txtMaGiangVien";
            this.txtMaGiangVien.Properties.ReadOnly = true;
            this.txtMaGiangVien.Size = new System.Drawing.Size(125, 22);
            this.txtMaGiangVien.TabIndex = 25;
            this.txtMaGiangVien.EditValueChanged += new System.EventHandler(this.txtMaGiangVien_EditValueChanged);
            // 
            // speNhom
            // 
            this.speNhom.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "NHOM", true));
            this.speNhom.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speNhom.Location = new System.Drawing.Point(811, 132);
            this.speNhom.MenuManager = this.barManager1;
            this.speNhom.Name = "speNhom";
            this.speNhom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speNhom.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.speNhom.Properties.MaxValue = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.speNhom.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speNhom.Size = new System.Drawing.Size(55, 24);
            this.speNhom.TabIndex = 24;
            // 
            // speSoSVToiThieu
            // 
            this.speSoSVToiThieu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "SOSVTOITHIEU", true));
            this.speSoSVToiThieu.EditValue = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.speSoSVToiThieu.Location = new System.Drawing.Point(246, 267);
            this.speSoSVToiThieu.MenuManager = this.barManager1;
            this.speSoSVToiThieu.Name = "speSoSVToiThieu";
            this.speSoSVToiThieu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speSoSVToiThieu.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.speSoSVToiThieu.Size = new System.Drawing.Size(125, 24);
            this.speSoSVToiThieu.TabIndex = 23;
            // 
            // cmbTenMonHoc
            // 
            this.cmbTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vDSMONHOCBindingSource, "TENMH", true));
            this.cmbTenMonHoc.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vDSMONHOCBindingSource, "MAMH", true));
            this.cmbTenMonHoc.DataSource = this.vDSMONHOCBindingSource;
            this.cmbTenMonHoc.DisplayMember = "TENMH";
            this.cmbTenMonHoc.FormattingEnabled = true;
            this.cmbTenMonHoc.Location = new System.Drawing.Point(811, 227);
            this.cmbTenMonHoc.Name = "cmbTenMonHoc";
            this.cmbTenMonHoc.Size = new System.Drawing.Size(239, 24);
            this.cmbTenMonHoc.TabIndex = 22;
            this.cmbTenMonHoc.ValueMember = "MAMH";
            this.cmbTenMonHoc.SelectedIndexChanged += new System.EventHandler(this.cmbTenMonHoc_SelectedIndexChanged);
            // 
            // vDSMONHOCBindingSource
            // 
            this.vDSMONHOCBindingSource.DataMember = "V_DS_MONHOC";
            this.vDSMONHOCBindingSource.DataSource = this.qLDSV_TCDataSet_LTC;
            // 
            // qLDSV_TCDataSet_LTC
            // 
            this.qLDSV_TCDataSet_LTC.DataSetName = "QLDSV_TCDataSet_LTC";
            this.qLDSV_TCDataSet_LTC.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbTenGV
            // 
            this.cmbTenGV.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vDSGIANGVIENBindingSource1, "HOTEN", true));
            this.cmbTenGV.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bdsLTC, "MAGV", true));
            this.cmbTenGV.DataSource = this.vDSGIANGVIENBindingSource1;
            this.cmbTenGV.DisplayMember = "HOTEN";
            this.cmbTenGV.FormattingEnabled = true;
            this.cmbTenGV.Location = new System.Drawing.Point(811, 179);
            this.cmbTenGV.Name = "cmbTenGV";
            this.cmbTenGV.Size = new System.Drawing.Size(239, 24);
            this.cmbTenGV.TabIndex = 21;
            this.cmbTenGV.ValueMember = "MAGV";
            this.cmbTenGV.SelectedIndexChanged += new System.EventHandler(this.cmbTenGV_SelectedIndexChanged);
            // 
            // vDSGIANGVIENBindingSource1
            // 
            this.vDSGIANGVIENBindingSource1.DataMember = "V_DS_GIANGVIEN";
            this.vDSGIANGVIENBindingSource1.DataSource = this.qLDSV_TCDataSet_LTC;
            // 
            // speHocKy
            // 
            this.speHocKy.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "HOCKY", true));
            this.speHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speHocKy.Location = new System.Drawing.Point(246, 134);
            this.speHocKy.MenuManager = this.barManager1;
            this.speHocKy.Name = "speHocKy";
            this.speHocKy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.speHocKy.Properties.Mask.BeepOnError = true;
            this.speHocKy.Properties.MaxValue = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.speHocKy.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speHocKy.Size = new System.Drawing.Size(125, 24);
            this.speHocKy.TabIndex = 19;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "MAKHOA", true));
            this.txtMaKhoa.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsLTC, "MAKHOA", true));
            this.txtMaKhoa.Location = new System.Drawing.Point(246, 84);
            this.txtMaKhoa.MenuManager = this.barManager1;
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Properties.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(125, 22);
            this.txtMaKhoa.TabIndex = 17;
            // 
            // labelThongTinLTC
            // 
            this.labelThongTinLTC.AutoSize = true;
            this.labelThongTinLTC.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThongTinLTC.Location = new System.Drawing.Point(399, 25);
            this.labelThongTinLTC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelThongTinLTC.Name = "labelThongTinLTC";
            this.labelThongTinLTC.Size = new System.Drawing.Size(226, 23);
            this.labelThongTinLTC.TabIndex = 16;
            this.labelThongTinLTC.Text = " Thông Tin Lớp Tín Chỉ";
            this.labelThongTinLTC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbeNienKhoa
            // 
            this.cmbeNienKhoa.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsLTC, "NIENKHOA", true));
            this.cmbeNienKhoa.Location = new System.Drawing.Point(811, 81);
            this.cmbeNienKhoa.MenuManager = this.barManager1;
            this.cmbeNienKhoa.Name = "cmbeNienKhoa";
            this.cmbeNienKhoa.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbeNienKhoa.Size = new System.Drawing.Size(125, 22);
            this.cmbeNienKhoa.TabIndex = 18;
            // 
            // bdsGiangVien
            // 
            this.bdsGiangVien.DataMember = "FK_LOPTINCHI_GIANGVIEN";
            this.bdsGiangVien.DataSource = this.bdsLTC;
            // 
            // bdsMonHoc
            // 
            this.bdsMonHoc.DataMember = "FK_LOPTINCHI_MONHOC";
            this.bdsMonHoc.DataSource = this.bdsLTC;
            // 
            // LTCTableAdapter
            // 
            this.LTCTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = this.LTCTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.QLDSV_TCDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // lOPTINCHIGridControl
            // 
            this.lOPTINCHIGridControl.DataSource = this.bdsLTC;
            this.lOPTINCHIGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lOPTINCHIGridControl.Location = new System.Drawing.Point(0, 131);
            this.lOPTINCHIGridControl.MainView = this.gridViewLTC;
            this.lOPTINCHIGridControl.MenuManager = this.barManager1;
            this.lOPTINCHIGridControl.Name = "lOPTINCHIGridControl";
            this.lOPTINCHIGridControl.Size = new System.Drawing.Size(1523, 582);
            this.lOPTINCHIGridControl.TabIndex = 13;
            this.lOPTINCHIGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLTC});
            // 
            // gridViewLTC
            // 
            this.gridViewLTC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMALTC,
            this.colNIENKHOA,
            this.colHOCKY,
            this.colMAMH,
            this.colNHOM,
            this.colMAGV,
            this.colMAKHOA,
            this.colSOSVTOITHIEU,
            this.colHUYLOP});
            this.gridViewLTC.GridControl = this.lOPTINCHIGridControl;
            this.gridViewLTC.Name = "gridViewLTC";
            // 
            // colMALTC
            // 
            this.colMALTC.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMALTC.FieldName = "MALTC";
            this.colMALTC.MinWidth = 25;
            this.colMALTC.Name = "colMALTC";
            this.colMALTC.OptionsColumn.AllowEdit = false;
            this.colMALTC.OptionsColumn.ReadOnly = true;
            this.colMALTC.Visible = true;
            this.colMALTC.VisibleIndex = 0;
            this.colMALTC.Width = 94;
            // 
            // colNIENKHOA
            // 
            this.colNIENKHOA.FieldName = "NIENKHOA";
            this.colNIENKHOA.MinWidth = 25;
            this.colNIENKHOA.Name = "colNIENKHOA";
            this.colNIENKHOA.Visible = true;
            this.colNIENKHOA.VisibleIndex = 1;
            this.colNIENKHOA.Width = 94;
            // 
            // colHOCKY
            // 
            this.colHOCKY.FieldName = "HOCKY";
            this.colHOCKY.MinWidth = 25;
            this.colHOCKY.Name = "colHOCKY";
            this.colHOCKY.Visible = true;
            this.colHOCKY.VisibleIndex = 2;
            this.colHOCKY.Width = 94;
            // 
            // colMAMH
            // 
            this.colMAMH.FieldName = "MAMH";
            this.colMAMH.MinWidth = 25;
            this.colMAMH.Name = "colMAMH";
            this.colMAMH.Visible = true;
            this.colMAMH.VisibleIndex = 3;
            this.colMAMH.Width = 94;
            // 
            // colNHOM
            // 
            this.colNHOM.FieldName = "NHOM";
            this.colNHOM.MinWidth = 25;
            this.colNHOM.Name = "colNHOM";
            this.colNHOM.Visible = true;
            this.colNHOM.VisibleIndex = 4;
            this.colNHOM.Width = 94;
            // 
            // colMAGV
            // 
            this.colMAGV.FieldName = "MAGV";
            this.colMAGV.MinWidth = 25;
            this.colMAGV.Name = "colMAGV";
            this.colMAGV.Visible = true;
            this.colMAGV.VisibleIndex = 5;
            this.colMAGV.Width = 94;
            // 
            // colMAKHOA
            // 
            this.colMAKHOA.FieldName = "MAKHOA";
            this.colMAKHOA.MinWidth = 25;
            this.colMAKHOA.Name = "colMAKHOA";
            this.colMAKHOA.Visible = true;
            this.colMAKHOA.VisibleIndex = 6;
            this.colMAKHOA.Width = 94;
            // 
            // colSOSVTOITHIEU
            // 
            this.colSOSVTOITHIEU.FieldName = "SOSVTOITHIEU";
            this.colSOSVTOITHIEU.MinWidth = 25;
            this.colSOSVTOITHIEU.Name = "colSOSVTOITHIEU";
            this.colSOSVTOITHIEU.Visible = true;
            this.colSOSVTOITHIEU.VisibleIndex = 7;
            this.colSOSVTOITHIEU.Width = 94;
            // 
            // colHUYLOP
            // 
            this.colHUYLOP.FieldName = "HUYLOP";
            this.colHUYLOP.MinWidth = 25;
            this.colHUYLOP.Name = "colHUYLOP";
            this.colHUYLOP.Visible = true;
            this.colHUYLOP.VisibleIndex = 8;
            this.colHUYLOP.Width = 94;
            // 
            // gIANGVIENTableAdapter
            // 
            this.gIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_GIANGVIENTableAdapter
            // 
            this.v_DS_GIANGVIENTableAdapter.ClearBeforeFill = true;
            // 
            // v_DS_MONHOCTableAdapter
            // 
            this.v_DS_MONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // bdsDangKy
            // 
            this.bdsDangKy.DataMember = "FK_DANGKY_LOPTINCHI";
            this.bdsDangKy.DataSource = this.bdsLTC;
            // 
            // dANGKYTableAdapter
            // 
            this.dANGKYTableAdapter.ClearBeforeFill = true;
            // 
            // frmLopTinChi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1523, 1055);
            this.Controls.Add(this.lOPTINCHIGridControl);
            this.Controls.Add(this.panelControlThongTinLTC);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLopTinChi";
            this.Text = "Lớp Tín Chỉ";
            this.Load += new System.EventHandler(this.frmLopTinChi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlThongTinLTC)).EndInit();
            this.panelControlThongTinLTC.ResumeLayout(false);
            this.panelControlThongTinLTC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaMonHoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaGiangVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speNhom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speSoSVToiThieu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSMONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TCDataSet_LTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSGIANGVIENBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbeNienKhoa.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsGiangVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsMonHoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vDSGIANGVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPTINCHIGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsDangKy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar barThanhNutLenh;

        private DevExpress.XtraBars.BarLargeButtonItem btnXoa;
        private DevExpress.XtraBars.BarLargeButtonItem btnSua;
        private DevExpress.XtraBars.BarLargeButtonItem btnReload;
        private DevExpress.XtraBars.BarLargeButtonItem btnGhi;
        private DevExpress.XtraBars.BarLargeButtonItem btnThoat;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControlThongTinLTC;
        private System.Windows.Forms.Label labelThongTinLTC;
        private QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter lOPTINCHITableAdapter;
        private System.Windows.Forms.BindingSource bdsLTC;
        private QLDSV_TCDataSet qLDSV_TCDataSet;
        private QLDSV_TCDataSetTableAdapters.LOPTINCHITableAdapter LTCTableAdapter;
        private QLDSV_TCDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl lOPTINCHIGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLTC;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraGrid.Columns.GridColumn colMALTC;
        private DevExpress.XtraGrid.Columns.GridColumn colNIENKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colHOCKY;
        private DevExpress.XtraGrid.Columns.GridColumn colMAMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNHOM;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHOA;
        private DevExpress.XtraGrid.Columns.GridColumn colSOSVTOITHIEU;
        private DevExpress.XtraGrid.Columns.GridColumn colHUYLOP;
        private DevExpress.XtraEditors.SpinEdit speHocKy;
        private DevExpress.XtraEditors.TextEdit txtMaKhoa;
        private DevExpress.XtraEditors.SpinEdit speNhom;
        private DevExpress.XtraEditors.SpinEdit speSoSVToiThieu;
        private DevExpress.XtraEditors.TextEdit txtMaMonHoc;
        private DevExpress.XtraEditors.TextEdit txtMaGiangVien;
        private System.Windows.Forms.CheckBox cbHuyLop;
        private DevExpress.XtraEditors.ComboBoxEdit cmbeNienKhoa;
        private System.Windows.Forms.BindingSource bdsGiangVien;
        private QLDSV_TCDataSetTableAdapters.GIANGVIENTableAdapter gIANGVIENTableAdapter;
        private System.Windows.Forms.BindingSource bdsMonHoc;
        private QLDSV_TCDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private DevExpress.XtraBars.BarButtonItem btnThem;
        internal System.Windows.Forms.ComboBox cmbTenGV;
        private System.Windows.Forms.BindingSource vDSGIANGVIENBindingSource;
        private QLDSV_TCDataSet_LTC qLDSV_TCDataSet_LTC;
        private QLDSV_TCDataSet_LTCTableAdapters.V_DS_GIANGVIENTableAdapter v_DS_GIANGVIENTableAdapter;
        private System.Windows.Forms.BindingSource vDSMONHOCBindingSource;
        private QLDSV_TCDataSet_LTCTableAdapters.V_DS_MONHOCTableAdapter v_DS_MONHOCTableAdapter;
        internal System.Windows.Forms.ComboBox cmbTenMonHoc;
        private System.Windows.Forms.BindingSource vDSGIANGVIENBindingSource1;
        private System.Windows.Forms.BindingSource bdsDangKy;
        private QLDSV_TCDataSetTableAdapters.DANGKYTableAdapter dANGKYTableAdapter;
    }
}