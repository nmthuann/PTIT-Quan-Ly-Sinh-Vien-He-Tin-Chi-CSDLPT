using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDSV_TC.forms
{
    public partial class frmLopHoc : Form
    {
        private int positionSV = -1;
        private int vitri;
        private string maKhoa = "";
        private String catcheTenLOP = "";  // giữ lại tên lớp lúc ấn edit
        public frmLopHoc()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lOPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLOP.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void frmLopHoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.DANGKY' table. You can move, or remove it, as needed.
            
            qLDSV_TCDataSet.EnforceConstraints = false;

            this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
            this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

            this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

            //this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;

            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);

            Program.bindingSource.Filter = "TENCN not LIKE 'Tra cứu học phí%'  ";
            // maKhoa = ((DataRowView)bdsLTC[0])["MAKHOA"].ToString(); // có thể lỗi???
            cmbKhoa.DataSource = Program.bindingSource;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.serverName;

            if (cmbKhoa.DisplayMember.ToString() == "Viễn Thông")
            {
                maKhoa = "VT";
            }
            maKhoa = "CNTT";

            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }

            if (bdsLOP.Count > 0)
            {
                btnXoa.Enabled = btnSua.Enabled = panelFormSV.Enabled = true;
            }
        }

        private bool checkSV()
        {
            DataRowView dt = (DataRowView)bdsSV[positionSV];
            if (dt["MASV"].ToString().Trim() == "")
            {
                MessageBox.Show("Mã sinh viên không được để trống", "", MessageBoxButtons.OK);
                return false;
            }
            if (dt["HO"].ToString().Trim() == "")
            {
                MessageBox.Show("Họ không được thiếu!", "", MessageBoxButtons.OK);

                return false;
            }
            if (dt["TEN"].ToString().Trim() == "")
            {
                MessageBox.Show("Tên không được thiếu!", "", MessageBoxButtons.OK);
                return false;
            }

            if (dt["PHAI"].ToString() == "")
            {
                MessageBox.Show("Vui Lòng Chọn Phái!", "", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

            private void lOPBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

   
        // Thêm sau khi hoàn thành tài khoản có quyền KHOA
        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbKhoa.SelectedValue.ToString() == "System.Data.DataRowView")
                return;

            Program.serverName = cmbKhoa.SelectedValue.ToString();
            if (cmbKhoa.SelectedIndex != Program.mPhongBan)
            {
                Program.mlogin = Program.remoteLogin;
                Program.password = Program.remotePass;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }

            if (Program.KetNoi() == 0)
            {
                MessageBox.Show("Lỗi kết nối về site khác mới", "", MessageBoxButtons.OK);
            }
            else
            {
                if (cmbKhoa.DisplayMember.ToString() == "Viễn Thông")
                {
                    maKhoa = "VT";
                }

                maKhoa = "CNTT";

                this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);

                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

                this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
                this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);


            }
        }

        private void btnADDSV_Click(object sender, EventArgs e)
        {
            qLDSV_TCDataSet.SINHVIEN.DANGHIHOCColumn.DefaultValue = false;
            qLDSV_TCDataSet.SINHVIEN.PHAIColumn.DefaultValue = false;
            qLDSV_TCDataSet.SINHVIEN.PASSWORDColumn.DefaultValue = Program.PasswordSinhVien;
            bdsSV.AddNew();
            positionSV = bdsSV.Count - 1;
            

            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ed = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ed.MaxValue = DateTime.Now.AddYears(-5);
            colNGAYSINH.ColumnEdit = ed;

            btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            btnADDSV.Enabled = btnDeleteSV.Enabled = btnEditSV.Enabled = false;
            // cbKhoa.Enabled = lOPGridControl.Enabled = false;
            btnUndoSV.Enabled = btnSaveSV.Enabled = true;
            // flagmodeSV = "ADDSV"; use for undo
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsLOP.AddNew();
            try
            {
                Console.WriteLine("aaaaa" + maKhoa);
                txtKhoa.Text = maKhoa;
            }
            catch

            {
                bdsLOP.CancelEdit();
                MessageBox.Show("Lỗi kết nối server!");
                return;
            }

            vitri = bdsLOP.Position;
            panelControl2.Enabled = true;
            cmbKhoa.Enabled = false;

            //flagmodeClass = "ADDCLASS";
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled  = true;
            // btnPH.Enabled = true;
            lOPGridControl.Enabled = panelFormSV.Enabled = false;
            txtMALOP.Enabled = true;

        }

        // cài đặt valitate cho các cell được chỉ định
        private void gridView2_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (gridView2.FocusedColumn.FieldName == "MASV")
            {
                bool match = Regex.IsMatch(e.Value.ToString().ToUpper(), "[NB][0-9][0-9][A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9]");
                if (!match || e.Value.ToString().Length != 10)
                {
                    e.ErrorText = "Mã sinh viên bạn nhập không đúng định dạng \n Ví dụ: N19DCCN001";
                    e.Valid = false;
                }
                else
                {
                    e.Value = e.Value.ToString().ToUpper();
                }
            }
        }


        // set up Không cho phép chỉnh sửa Các cell của 1 row khi bắt gặp các trường hợp nếu TRUE:
        // + Vị trí(row đã được lưu) đang thao tác bị thay đổi (ví dụ: khi user nhấp vào row khác) 
        // + Khi user nhấp vào cell có field MALOP
        // + Đang Thêm mới mà click vào cell có field DANGHIHOC
        // + Đang Sửa mà mà click vào cell có field MASV
        private void gridView2_ShowingEditor(object sender, CancelEventArgs e)
        {
            // positionSV default = -1
            if (bdsSV.Position != positionSV || gridView2.FocusedColumn.FieldName == "MALOP"
         //      || (gridView2.FocusedColumn.FieldName == "DANGHIHOC" && flagmodeSV.Equals("ADDSV"))
           //    || (gridView2.FocusedColumn.FieldName == "MASV" && flagmodeSV.Equals("EDITSV"))
               )
                e.Cancel = true;
          
        }

        private void btnEditSV_Click(object sender, EventArgs e)
        {
            positionSV = bdsSV.Position;
            // flagmodeSV = "EDITSV";

            DevExpress.XtraEditors.Repository.RepositoryItemDateEdit ed = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            ed.MaxValue = DateTime.Now.AddYears(-5);
            colNGAYSINH.ColumnEdit = ed;

            btnSaveSV.Enabled = btnUndoSV.Enabled = true;
            btnADDSV.Enabled = btnDeleteSV.Enabled = btnEditSV.Enabled = false;
            btnThem.Enabled = btnGhi.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
            // cbKhoa.Enabled = lOPGridControl.Enabled = false;
        }

        private void btnDeleteSV_Click(object sender, EventArgs e)
        {
            string masv = "";
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show("Không thể xóa sinh viên này vì sinh viên đã đăng kí lớp tín chỉ", "", MessageBoxButtons.OK);
                return;
            }


            if (MessageBox.Show("Bạn có thật sự muốn xóa sinh viên khỏi lớp học này ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    masv = ((DataRowView)bdsSV[bdsSV.Position])["MASV"].ToString(); // use for Undo
                    bdsSV.RemoveCurrent();
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa sinh vieen: " + ex.Message, "", MessageBoxButtons.OK);
                    this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);
                    bdsSV.Position = bdsSV.Find("MASV", masv);
                    return;
                }
            }
        }

        private void dANGKYBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveSV_Click(object sender, EventArgs e)
        {
            if (checkSV() == true)
            {
                try
                {
                    bdsSV.EndEdit();
                    bdsSV.ResetCurrentItem();
                    // flagmodeSV = "";
                    this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.sINHVIENTableAdapter.Update(this.qLDSV_TCDataSet.SINHVIEN);
                }
                catch (Exception ex)
                {
                    // flagmodeSV = "ADDSV";
                    MessageBox.Show("Lỗi ghi sinh viên: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }

                 lOPGridControl.Enabled =true;
                // cbKhoa.Enabled = true;
                positionSV = -1;

                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                btnADDSV.Enabled = true;
                btnUndoSV.Enabled = btnSaveSV.Enabled = false;
                btnDeleteSV.Enabled = btnEditSV.Enabled = true;
            }
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String malop = "";
            if (bdsSV.Count > 0)
            {
                MessageBox.Show("Không thể xóa lớp vì đã có sinh viên", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn chắc chắn muốn xóa lớp học?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    malop = ((DataRowView)bdsLOP[bdsLOP.Position])["MALOP"].ToString();
                    bdsLOP.RemoveCurrent();
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa lớp, bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.lOPTableAdapter.Fill(this.qLDSV_TCDataSet.LOP);
                    bdsLOP.Position = bdsLOP.Find("MALOP", malop);
                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsLOP.Position;
            panelControl2.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnGhi.Enabled = true; 
                //btnPH.Enabled = true;
            cmbKhoa.Enabled = false;
            txtMALOP.Enabled = false;
            // flagmodeClass = "EDITCLASS";
            catcheTenLOP = txtTenLop.Text.Trim();

            lOPGridControl.Enabled = panelFormSV.Enabled = false;
            txtMALOP.Enabled = true;
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (checkClass())
            {
                try
                {
                    bdsLOP.EndEdit();
                    bdsLOP.ResetCurrentItem();
                    //flagmodeClass = "!" + flagmodeClass;
                    this.lOPTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.lOPTableAdapter.Update(this.qLDSV_TCDataSet.LOP);


                }
                catch (Exception ex)
                {
                    //flagmodeClass = flagmodeClass.Substring(1);
                    MessageBox.Show("Lỗi ghi lớp: " + ex.Message, "", MessageBoxButtons.OK);
                    return;
                }
                lOPGridControl.Enabled = panelFormSV.Enabled = true;
                btnThem.Enabled = true;
                btnGhi.Enabled = false;
                    //btnPH.Enabled = false;
                panelControl2.Enabled = false;
                cmbKhoa.Enabled = true;
                btnXoa.Enabled = btnSua.Enabled = panelFormSV.Enabled = true;
                catcheTenLOP = "";
            }
        }

        private bool checkClass()
        {
            if (txtMALOP.Text.Trim() == "")
            {
                MessageBox.Show("Mã lớp học không được để trống!", "", MessageBoxButtons.OK);
                txtMALOP.Focus();
                return false;
            }
            if (txtTenLop.Text.Trim() == "")
            {
                MessageBox.Show("Tên lớp học không được để trống!", "", MessageBoxButtons.OK);
                txtTenLop.Focus();
                return false;
            }
            if (txtKhoaHoc.Text.Trim() == "")
            {
                MessageBox.Show("Khóa học không được để trống!", "", MessageBoxButtons.OK);
                txtKhoaHoc.Focus();
                return false;
            }

            return true;
        }

        // khi row trong gridview bị thay đổi sẽ kích hoạt NÚT thêm xóa
        private void gridView2_RowCountChanged(object sender, EventArgs e)
        {
            //if (bdsSV.Count > 0 && !flagmodeSV.Equals("ADDSV"))
            if (bdsSV.Count > 0)
                btnDeleteSV.Enabled = btnEditSV.Enabled = true;
            else
                btnDeleteSV.Enabled = btnEditSV.Enabled = false;
        }

        private void btnUndoSV_Click(object sender, EventArgs e)
        {
            if (btnADDSV.Enabled == false && btnEditSV.Enabled == false)
            {
                bdsSV.CancelEdit();
                //bdsSV.RemoveCurrent();
                this.sINHVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sINHVIENTableAdapter.Fill(this.qLDSV_TCDataSet.SINHVIEN);

                btnADDSV.Enabled = btnEditSV.Enabled = btnDeleteSV.Enabled = true;
                btnUndoSV.Enabled = btnSaveSV.Enabled = false;
            }
        }
    }
}
