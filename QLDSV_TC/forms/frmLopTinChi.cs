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
    public partial class frmLopTinChi : Form
    {
        private int viTri = 0;
        private string maKhoa = "";
        //  bool DangThem = false;

        public frmLopTinChi()
        {
            InitializeComponent();
        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {

            qLDSV_TCDataSet.EnforceConstraints = false;


            //this.dS_GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.dS_GIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet.DS_GIANGVIEN);
            //this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            //this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);

            this.LTCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LTCTableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);



            cmbTenMonHoc.DataSource = Program.ExecSqlDataTable("SELECT * FROM MONHOC");
            cmbTenMonHoc.DisplayMember = "TENMH";
            cmbTenMonHoc.ValueMember = "MAMH";

            cmbTenGV.DataSource = Program.ExecSqlDataTable("SELECT MAGV, TENGV = HO + ' ' + TEN FROM GIANGVIEN");
            cmbTenGV.DisplayMember = "TENGV";
            cmbTenGV.ValueMember = "MAGV";



            Program.bindingSource.Filter = "TENCN not LIKE 'Tra cứu học phí%'  ";
            maKhoa = ((DataRowView)bdsLTC[0])["MAKHOA"].ToString(); // có thể lỗi???
            cmbKhoa.DataSource = Program.bindingSource;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.serverName;



            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnReload.Enabled = true;
                btnXoa.Enabled = true;
            }
            if (Program.mGroup == "KHOA")
            {
                cmbKhoa.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnReload.Enabled = true;
                btnXoa.Enabled = true;
            }
            if (Program.mGroup == "PKT")// PKT
            {
                btnReload.Enabled = true;
                btnThoat.Enabled = true;
                // panelControlThongTinLTC.Enabled = false;
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = btnGhi.Enabled = false;
            }
        }



        private void lOPTINCHIBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsLTC.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }


        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            /**
             * Tại sao giữ lại vị trí -> phục vụ cho chức năng phục hồi
             */
            viTri = bdsLTC.Position;
            panelControlThongTinLTC.Enabled = true;
            cmbKhoa.Enabled = false;
            // DangThem = true;

            bdsLTC.AddNew();
            maKhoa = ((DataRowView)bdsLTC[0])["MAKHOA"].ToString(); // có thể lỗi???
            txtMaKhoa.Text = maKhoa.Trim();
            cbHuyLop.Checked = false;
            // cmbTenMonHoc.SelectedIndex = -1;
            // cmbTenGV.SelectedIndex = 0;
            // cmbTenMonHoc.SelectedIndex = 0;
            // this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;


            // Liên kết dữ liệu vào ComboBox
            //cmbTenMonHoc.DataSource = mONHOCBindingSource;
            //cmbTenMonHoc.DisplayMember = "TENMH";
            //cmbTenMonHoc.ValueMember = "MAMH";

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
        }


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
                // qLDSV_TCDataSet.EnforceConstraints = false;
                // qLDSV_TCDataSet_LTC.EnforceConstraints = false;
                //if (cmbKhoa.DisplayMember.ToString() == "Viễn thông")
                //{
                //    maKhoa = "VT";
                //}
                //if (cmbKhoa.DisplayMember.ToString() == "Công nghệ thông tin")
                //{
                //    maKhoa = "CNTT";
                //}

                maKhoa = ((DataRowView)bdsLTC[0])["MAKHOA"].ToString(); // chắc phải viết SP ở lỗi này
                //this.dS_GIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet.DS_GIANGVIEN);
                this.LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LTCTableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            }

            if (bdsLTC.Count == 0)
                btnXoa.Enabled = btnSua.Enabled = false;
            else
                btnXoa.Enabled = btnSua.Enabled = true;
        }



        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(
                "Bạn chắc chắn muốn thoát", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (btnGhi.Enabled == true) //  có thể đang thêm - sửa nhưng thoát vội?
                {
                    bdsLTC.CancelEdit();
                }
                
                this.Close();
            }

        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //MessageBox.Show("Chức năng chưa hoàn thành?");
            if (bdsDangKy.Count > 0)
            {
                MessageBox.Show(
                    "Không thể xóa lớp tín chỉ vì đã có sinh viên đăng kí ",
                    "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show(
                "Bạn chắc chắn muốn xóa lớp tín chỉ?",
                "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsLTC.RemoveCurrent(); // sẽ tìm hiểu bổ sung Hàm Find()
                    /**
                     * ý tưởng: cancle Edit 
                     *  ** chưa ghi
                     *  ** stack
                     *  ** Remove Current + Adapter.Update = xóa (thiếu Adapter.Update -> chỉ xóa ở bds)
                     *  ** call Fill ở catch (try-catch tức xóa bị lỗi) 
                     *  ** => đưa con trỏ đến mẫu tin xóa -> nếu không trỏ nhảy về đầu
                     *  ** xóa lỗi ở đâu báo lỗi ở đó
                     *  ** Find chỉ tìm dc ở khóa chính
                     */
                    this.LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.LTCTableAdapter.Update(this.qLDSV_TCDataSet.LOPTINCHI); // mở ở đây ra mới xóa dc trong csdl
                    if (bdsLTC.Count == 0) // xóa đến nào k còn thì thôi!
                        btnXoa.Enabled = btnSua.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.LTCTableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
                    /*bdsLTC.Position = bdsLTC.Find("MaLTC", maLTC);*/
                    return;
                }
            }
        }


        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //MessageBox.Show("Chức năng chưa hoàn thành?");
            viTri = bdsLTC.Position;
            if (bdsDangKy.Count > 0)
            {
                //MessageBox.Show(
                //    "Không thể sửa lớp tín chỉ vì đã có sinh viên đăng kí ",
                //    "", MessageBoxButtons.OK);
                //return;
                cmbeNienKhoa.Enabled = speHocKy.Enabled = speNhom.Enabled = cmbTenMonHoc.Enabled = false;
            }

            panelControlThongTinLTC.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            cmbKhoa.Enabled = false;
            cbHuyLop.Enabled = true;
            // DangThem = true;
        }



        // chưa có thêm stack
        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //MessageBox.Show("Chức năng chưa hoàn thành?");
            bdsLTC.CancelEdit();
            this.LTCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LTCTableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            // thêm thì không sửa, sửa thì không thêm
            if (btnThem.Enabled == false) bdsLTC.Position = viTri; // đang sửa
            lOPTINCHIGridControl.Enabled = true;
            panelControlThongTinLTC.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            if (bdsLTC.Count == 0)
            {
                btnXoa.Enabled = btnSua.Enabled = false;
            }

        }


        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //MessageBox.Show("Chức năng chưa hoàn thành?");
            try
            {
                this.LTCTableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                        "Lỗi Reload, Reload thất bại!" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }


        // check dữ kiệu đầu vào
        private bool CheckInput()
        {
            if (cmbeNienKhoa.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng điền niên khóa!", "", MessageBoxButtons.OK);
                cmbeNienKhoa.Focus();
                return false;
            }
            if (speHocKy.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn học kỳ!", "", MessageBoxButtons.OK);
                speHocKy.Focus();
                return false;
            }

            if (cmbTenMonHoc.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn môn học!", "", MessageBoxButtons.OK);
                cmbTenMonHoc.Focus();
                return false;
            }
            if (cmbTenGV.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn giáo viên!", "", MessageBoxButtons.OK);
                cmbTenGV.Focus();
                return false;
            }
            if (speNhom.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng chọn nhóm!", "", MessageBoxButtons.OK);
                speNhom.Focus();
                return false;
            }

            if (speSoSVToiThieu.Text.Trim() == "")
            {
                MessageBox.Show("vui lòng nhập số sinh viên tối thiểu!", "", MessageBoxButtons.OK);
                speSoSVToiThieu.Focus();
                return false;
            }
            //if (cbHuyLop.Checked)
            //{
            //    if (bdsDangKy.Count > 0)
            //    {
            //        MessageBox.Show(
            //            "Không thể xóa hủy lớp tín chỉ vì đã có sinh viên đăng kí ",
            //            "", MessageBoxButtons.OK);
            //        return false;
            //    }    
            //}

            return true;
        }


        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            // DangThem = false;
            // MessageBox.Show("Chức năng chưa hoàn thành?");
            bool check = CheckInput();
            if (check == false)
                return;

            try
            {
                bdsLTC.EndEdit();
                bdsLTC.ResetCurrentItem();
                // this.LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LTCTableAdapter.Update(this.qLDSV_TCDataSet.LOPTINCHI);
                lOPTINCHIGridControl.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi vào CSDL: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnThoat.Enabled = btnReload.Enabled = true;
            btnGhi.Enabled = btnUndo.Enabled = false;
            panelControlThongTinLTC.Enabled = false;
            if (Program.mGroup == "PGV")
            {
                cmbKhoa.Enabled = true;
            }

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lOPTINCHIGridControl_Click(object sender, EventArgs e)
        {

        }

        private void panelControlThongTinLTC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenGV.SelectedValue != null)
                mAGVTextEdit.Text = cmbTenGV.SelectedValue.ToString();
        }

        private void cmbTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenMonHoc.SelectedValue != null)
                mAMHTextEdit.Text = cmbTenMonHoc.SelectedValue.ToString();
        }

        //private void mAGVTextEdit_EditValueChanged(object sender, EventArgs e)
        //{
        //    if ( mAGVTextEdit.Text != null)
        //    {
        //        cmbTenGV.SelectedValue = cmbTenGV.Text;
        //    }
        //}
    }
}
