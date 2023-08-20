
namespace QLDSV_TC.forms
{
    partial class Xfrm_ReportHocPhiTheoLop
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
            System.Windows.Forms.Label mALOPLabel;
            System.Windows.Forms.Label nIENKHOALabel;
            System.Windows.Forms.Label hOCKYLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Xfrm_ReportHocPhiTheoLop));
            this.label2 = new System.Windows.Forms.Label();
            this.tbMaLop = new DevExpress.XtraEditors.TextEdit();
            this.cbNIENKHOA = new DevExpress.XtraEditors.TextEdit();
            this.cbHOCKY = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            mALOPLabel = new System.Windows.Forms.Label();
            nIENKHOALabel = new System.Windows.Forms.Label();
            hOCKYLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaLop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNIENKHOA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHOCKY.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel
            // 
            mALOPLabel.AutoSize = true;
            mALOPLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel.Location = new System.Drawing.Point(134, 94);
            mALOPLabel.Name = "mALOPLabel";
            mALOPLabel.Size = new System.Drawing.Size(72, 20);
            mALOPLabel.TabIndex = 41;
            mALOPLabel.Text = "Mã Lớp:";
            // 
            // nIENKHOALabel
            // 
            nIENKHOALabel.AutoSize = true;
            nIENKHOALabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nIENKHOALabel.Location = new System.Drawing.Point(115, 131);
            nIENKHOALabel.Name = "nIENKHOALabel";
            nIENKHOALabel.Size = new System.Drawing.Size(91, 20);
            nIENKHOALabel.TabIndex = 43;
            nIENKHOALabel.Text = "Niên Khóa:";
            // 
            // hOCKYLabel
            // 
            hOCKYLabel.AutoSize = true;
            hOCKYLabel.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOCKYLabel.Location = new System.Drawing.Point(134, 168);
            hOCKYLabel.Name = "hOCKYLabel";
            hOCKYLabel.Size = new System.Drawing.Size(70, 20);
            hOCKYLabel.TabIndex = 45;
            hOCKYLabel.Text = "Học Kỳ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 27);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nhập Thông Tin Lớp Học:";
            // 
            // tbMaLop
            // 
            this.tbMaLop.Location = new System.Drawing.Point(212, 91);
            this.tbMaLop.Name = "tbMaLop";
            this.tbMaLop.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaLop.Properties.Appearance.Options.UseFont = true;
            this.tbMaLop.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbMaLop.Properties.Mask.EditMask = "[A-Z 0-9 -]{0,10}";
            this.tbMaLop.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.tbMaLop.Properties.Mask.ShowPlaceHolders = false;
            this.tbMaLop.Size = new System.Drawing.Size(400, 26);
            this.tbMaLop.TabIndex = 42;
            // 
            // cbNIENKHOA
            // 
            this.cbNIENKHOA.Location = new System.Drawing.Point(212, 128);
            this.cbNIENKHOA.Name = "cbNIENKHOA";
            this.cbNIENKHOA.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNIENKHOA.Properties.Appearance.Options.UseFont = true;
            this.cbNIENKHOA.Properties.Mask.EditMask = "[0-9 -]{9}";
            this.cbNIENKHOA.Properties.Mask.IgnoreMaskBlank = false;
            this.cbNIENKHOA.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.cbNIENKHOA.Properties.Mask.ShowPlaceHolders = false;
            this.cbNIENKHOA.Size = new System.Drawing.Size(175, 26);
            this.cbNIENKHOA.TabIndex = 44;
            // 
            // cbHOCKY
            // 
            this.cbHOCKY.Location = new System.Drawing.Point(212, 165);
            this.cbHOCKY.Name = "cbHOCKY";
            this.cbHOCKY.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHOCKY.Properties.Appearance.Options.UseFont = true;
            this.cbHOCKY.Properties.Mask.EditMask = "[1-4]";
            this.cbHOCKY.Properties.Mask.IgnoreMaskBlank = false;
            this.cbHOCKY.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.cbHOCKY.Properties.Mask.ShowPlaceHolders = false;
            this.cbHOCKY.Size = new System.Drawing.Size(154, 26);
            this.cbHOCKY.TabIndex = 46;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.SlateBlue;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.simpleButton4.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton4.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton4.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(231, 233);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(81, 34);
            this.simpleButton4.TabIndex = 56;
            this.simpleButton4.Text = "In Ấn";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.Red;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton2.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton2.ImageOptions.SvgImage")));
            this.simpleButton2.Location = new System.Drawing.Point(448, 233);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(81, 34);
            this.simpleButton2.TabIndex = 57;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // Xfrm_ReportHocPhiTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.cbHOCKY);
            this.Controls.Add(hOCKYLabel);
            this.Controls.Add(this.cbNIENKHOA);
            this.Controls.Add(nIENKHOALabel);
            this.Controls.Add(this.tbMaLop);
            this.Controls.Add(mALOPLabel);
            this.Controls.Add(this.label2);
            this.Name = "Xfrm_ReportHocPhiTheoLop";
            this.Text = "In Học Phí Theo Lớp";
            this.Load += new System.EventHandler(this.Xfrm_ReportHocPhiTheoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbMaLop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbNIENKHOA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbHOCKY.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit tbMaLop;
        private DevExpress.XtraEditors.TextEdit cbNIENKHOA;
        private DevExpress.XtraEditors.TextEdit cbHOCKY;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}