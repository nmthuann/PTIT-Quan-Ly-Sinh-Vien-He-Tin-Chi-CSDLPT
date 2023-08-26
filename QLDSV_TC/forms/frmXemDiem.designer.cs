
namespace QLDSV_TC.forms
{
    partial class frmXemDiem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbKhoa = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbMaSv = new System.Windows.Forms.Label();
            this.lbLop = new System.Windows.Forms.Label();
            this.lbHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NKHK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TENMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_CC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_GK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEM_CK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIEMTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbKhoa);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lbMaSv);
            this.panel1.Controls.Add(this.lbLop);
            this.panel1.Controls.Add(this.lbHoTen);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 148);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbKhoa
            // 
            this.lbKhoa.AutoSize = true;
            this.lbKhoa.Location = new System.Drawing.Point(644, 112);
            this.lbKhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKhoa.Name = "lbKhoa";
            this.lbKhoa.Size = new System.Drawing.Size(52, 17);
            this.lbKhoa.TabIndex = 10;
            this.lbKhoa.Text = "lbKhoa";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(512, 113);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Khoa";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(512, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 17);
            this.label11.TabIndex = 6;
            this.label11.Text = "Họ và Tên";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(512, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Mã Sinh Viên";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 87);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Lớp";
            // 
            // lbMaSv
            // 
            this.lbMaSv.AutoSize = true;
            this.lbMaSv.Location = new System.Drawing.Point(644, 34);
            this.lbMaSv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaSv.Name = "lbMaSv";
            this.lbMaSv.Size = new System.Drawing.Size(56, 17);
            this.lbMaSv.TabIndex = 3;
            this.lbMaSv.Text = "lbMaSV";
            // 
            // lbLop
            // 
            this.lbLop.AutoSize = true;
            this.lbLop.Location = new System.Drawing.Point(644, 87);
            this.lbLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLop.Name = "lbLop";
            this.lbLop.Size = new System.Drawing.Size(43, 17);
            this.lbLop.TabIndex = 2;
            this.lbLop.Text = "lbLop";
            // 
            // lbHoTen
            // 
            this.lbHoTen.AutoSize = true;
            this.lbHoTen.Location = new System.Drawing.Point(644, 62);
            this.lbHoTen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbHoTen.Name = "lbHoTen";
            this.lbHoTen.Size = new System.Drawing.Size(62, 17);
            this.lbHoTen.TabIndex = 1;
            this.lbHoTen.Text = "lbHoTen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông Tin Sinh Viên";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 148);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1067, 406);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NKHK,
            this.TENMH,
            this.DIEM_CC,
            this.DIEM_GK,
            this.DIEM_CK,
            this.DIEMTK});
            this.gridView1.DetailHeight = 1593;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.NKHK, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // NKHK
            // 
            this.NKHK.Caption = "NIÊN KHÓA -  HỌC KỲ";
            this.NKHK.FieldName = "NKHK";
            this.NKHK.FilterMode = DevExpress.XtraGrid.ColumnFilterMode.DisplayText;
            this.NKHK.MinWidth = 117;
            this.NKHK.Name = "NKHK";
            this.NKHK.SortMode = DevExpress.XtraGrid.ColumnSortMode.Custom;
            this.NKHK.Visible = true;
            this.NKHK.VisibleIndex = 0;
            this.NKHK.Width = 427;
            // 
            // TENMH
            // 
            this.TENMH.Caption = "Tên môn học";
            this.TENMH.FieldName = "TENMH";
            this.TENMH.MinWidth = 117;
            this.TENMH.Name = "TENMH";
            this.TENMH.Visible = true;
            this.TENMH.VisibleIndex = 0;
            this.TENMH.Width = 427;
            // 
            // DIEM_CC
            // 
            this.DIEM_CC.Caption = "Điểm chuyên cần";
            this.DIEM_CC.FieldName = "DIEM_CC";
            this.DIEM_CC.MinWidth = 117;
            this.DIEM_CC.Name = "DIEM_CC";
            this.DIEM_CC.Visible = true;
            this.DIEM_CC.VisibleIndex = 1;
            this.DIEM_CC.Width = 427;
            // 
            // DIEM_GK
            // 
            this.DIEM_GK.Caption = "Điểm giữa kỳ";
            this.DIEM_GK.FieldName = "DIEM_GK";
            this.DIEM_GK.MinWidth = 117;
            this.DIEM_GK.Name = "DIEM_GK";
            this.DIEM_GK.Visible = true;
            this.DIEM_GK.VisibleIndex = 2;
            this.DIEM_GK.Width = 427;
            // 
            // DIEM_CK
            // 
            this.DIEM_CK.Caption = "Điểm cuối kỳ";
            this.DIEM_CK.FieldName = "DIEM_CK";
            this.DIEM_CK.MinWidth = 117;
            this.DIEM_CK.Name = "DIEM_CK";
            this.DIEM_CK.Visible = true;
            this.DIEM_CK.VisibleIndex = 3;
            this.DIEM_CK.Width = 427;
            // 
            // DIEMTK
            // 
            this.DIEMTK.Caption = "Điểm TK";
            this.DIEMTK.FieldName = "DIEMTK";
            this.DIEMTK.MinWidth = 117;
            this.DIEMTK.Name = "DIEMTK";
            this.DIEMTK.UnboundExpression = "Round([DIEM_CC] * 0.1 + [DIEM_GK] * 0.3 + [DIEM_CK] * 0.6, 1)";
            this.DIEMTK.Visible = true;
            this.DIEMTK.VisibleIndex = 4;
            this.DIEMTK.Width = 427;
            // 
            // frmXemDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmXemDiem";
            this.Text = "frmXemDiem";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbKhoa;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbMaSv;
        private System.Windows.Forms.Label lbLop;
        private System.Windows.Forms.Label lbHoTen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn NKHK;
        private DevExpress.XtraGrid.Columns.GridColumn TENMH;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_CC;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_GK;
        private DevExpress.XtraGrid.Columns.GridColumn DIEM_CK;
        private DevExpress.XtraGrid.Columns.GridColumn DIEMTK;
    }
}