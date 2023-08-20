
namespace QLDSV_TC.forms
{
    partial class frmDanhSachLTC
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
            this.speHocKy = new DevExpress.XtraEditors.SpinEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.lbNiemKhoa = new System.Windows.Forms.Label();
            this.cmbKhoa = new System.Windows.Forms.ComboBox();
            this.dANHSACHKHOABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSV_TC_DataSet = new QLDSV_TC.QLDSV_TC_DataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lbBaoCao = new System.Windows.Forms.Label();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.dANHSACHKHOATableAdapter = new QLDSV_TC.QLDSV_TC_DataSetTableAdapters.DANHSACHKHOATableAdapter();
            this.tableAdapterManager = new QLDSV_TC.QLDSV_TC_DataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.speHocKy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHSACHKHOABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TC_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // speHocKy
            // 
            this.speHocKy.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speHocKy.Location = new System.Drawing.Point(710, 89);
            this.speHocKy.Margin = new System.Windows.Forms.Padding(4);
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
            this.speHocKy.Size = new System.Drawing.Size(70, 24);
            this.speHocKy.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(646, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Học Kỳ:";
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Items.AddRange(new object[] {
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024"});
            this.cmbNienKhoa.Location = new System.Drawing.Point(465, 89);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(132, 24);
            this.cmbNienKhoa.TabIndex = 22;
            // 
            // lbNiemKhoa
            // 
            this.lbNiemKhoa.AutoSize = true;
            this.lbNiemKhoa.Location = new System.Drawing.Point(381, 92);
            this.lbNiemKhoa.Name = "lbNiemKhoa";
            this.lbNiemKhoa.Size = new System.Drawing.Size(78, 17);
            this.lbNiemKhoa.TabIndex = 21;
            this.lbNiemKhoa.Text = "Niên Khóa:";
            // 
            // cmbKhoa
            // 
            this.cmbKhoa.DataSource = this.dANHSACHKHOABindingSource;
            this.cmbKhoa.DisplayMember = "TENKHOA";
            this.cmbKhoa.FormattingEnabled = true;
            this.cmbKhoa.Location = new System.Drawing.Point(79, 89);
            this.cmbKhoa.Name = "cmbKhoa";
            this.cmbKhoa.Size = new System.Drawing.Size(185, 24);
            this.cmbKhoa.TabIndex = 25;
            this.cmbKhoa.ValueMember = "MAKHOA";
            this.cmbKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbKhoa_SelectedIndexChanged);
            // 
            // dANHSACHKHOABindingSource
            // 
            this.dANHSACHKHOABindingSource.DataMember = "DANHSACHKHOA";
            this.dANHSACHKHOABindingSource.DataSource = this.qLDSV_TC_DataSet;
            // 
            // qLDSV_TC_DataSet
            // 
            this.qLDSV_TC_DataSet.DataSetName = "QLDSV_TC_DataSet";
            this.qLDSV_TC_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Khoa:";
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.White;
            this.btnPreview.Location = new System.Drawing.Point(298, 174);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(114, 50);
            this.btnPreview.TabIndex = 27;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThoat.Location = new System.Drawing.Point(418, 174);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(114, 50);
            this.btnThoat.TabIndex = 28;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // lbBaoCao
            // 
            this.lbBaoCao.AutoSize = true;
            this.lbBaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBaoCao.Location = new System.Drawing.Point(200, 19);
            this.lbBaoCao.Name = "lbBaoCao";
            this.lbBaoCao.Size = new System.Drawing.Size(416, 32);
            this.lbBaoCao.TabIndex = 29;
            this.lbBaoCao.Text = "XEM DANH SÁCH LỚP TÍN CHỈ";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(270, 93);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.ReadOnly = true;
            this.txtMaKhoa.Size = new System.Drawing.Size(105, 22);
            this.txtMaKhoa.TabIndex = 30;
            // 
            // dANHSACHKHOATableAdapter
            // 
            this.dANHSACHKHOATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.DANGKYTableAdapter = null;
            this.tableAdapterManager.DS_GIANGVIENTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = null;
            this.tableAdapterManager.LOPTINCHITableAdapter = null;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLDSV_TC.QLDSV_TC_DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDanhSachLTC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 294);
            this.Controls.Add(this.txtMaKhoa);
            this.Controls.Add(this.lbBaoCao);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbKhoa);
            this.Controls.Add(this.speHocKy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(this.lbNiemKhoa);
            this.Name = "frmDanhSachLTC";
            this.Text = "frmDanhSachLTC";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDanhSachLTC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.speHocKy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dANHSACHKHOABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSV_TC_DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SpinEdit speHocKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private System.Windows.Forms.Label lbNiemKhoa;
        private System.Windows.Forms.ComboBox cmbKhoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lbBaoCao;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private QLDSV_TC_DataSet qLDSV_TC_DataSet;
        private System.Windows.Forms.BindingSource dANHSACHKHOABindingSource;
        private QLDSV_TC_DataSetTableAdapters.DANHSACHKHOATableAdapter dANHSACHKHOATableAdapter;
        private QLDSV_TC_DataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}