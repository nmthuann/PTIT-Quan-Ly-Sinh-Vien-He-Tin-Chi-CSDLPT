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

        public frmLopTinChi()
        {
            InitializeComponent();
        }

        private void frmLopTinChi_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.DANGKY' table. You can move, or remove it, as needed.
            
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet2.V_DS_GIANGVIEN' table. You can move, or remove it, as needed.

            qLDSV_TCDataSet.EnforceConstraints = false;
            qLDSV_TCDataSet_LTC.EnforceConstraints = false;

            this.LTCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.LTCTableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);

            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.GIANGVIEN' table. You can move, or remove it, as needed.
            this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet.GIANGVIEN);
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet.LOPTINCHI' table. You can move, or remove it, as needed.

            this.dANGKYTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dANGKYTableAdapter.Fill(this.qLDSV_TCDataSet.DANGKY);


            // this.v_DS_MONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_MONHOCTableAdapter.Fill(this.qLDSV_TCDataSet_LTC.V_DS_MONHOC);
            //// TODO: This line of code loads data into the 'qLDSV_TCDataSet_LTC.V_DS_GIANGVIEN' table. You can move, or remove it, as needed.
            // this.v_DS_GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.v_DS_GIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet_LTC.V_DS_GIANGVIEN);


            Program.bindingSource.Filter = "TENCN not LIKE 'Tra cứu học phí%'  ";
            maKhoa = ((DataRowView)bdsLTC[0])["MAKHOA"].ToString(); // có thể lỗi???
            cmbKhoa.DataSource = Program.bindingSource;
            cmbKhoa.DisplayMember = "TENCN";
            cmbKhoa.ValueMember = "TENSERVER";
            cmbKhoa.SelectedValue = Program.serverName;
           

            cmbTenMonHoc.SelectedValue = ((DataRowView)bdsMonHoc[0])["MAMH"].ToString();

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
                
                //cmbKhoa.Enabled = true;
                //btnReload.Enabled = true;
                panelControlThongTinLTC.Enabled = false;
                
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
            bdsLTC.AddNew();
            txtMaKhoa.Text = maKhoa;
            cbHuyLop.Checked = false;
            cmbTenGV.SelectedIndex = 0;
            cmbTenMonHoc.SelectedIndex = 0;
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
                if (cmbKhoa.DisplayMember.ToString() == "Viễn Thông")
                {
                    maKhoa = "VT";
                }
                maKhoa = "CNTT";
                // maKhoa = ((DataRowView)bdsLTC[0])["MAKHOA"].ToString(); // chắc phải viết SP ở lỗi này
                this.LTCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.LTCTableAdapter.Fill(this.qLDSV_TCDataSet.LOPTINCHI);

                //this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);

                //this.gIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
                //this.gIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet.GIANGVIEN);

                //this.v_DS_MONHOCTableAdapter.Fill(this.qLDSV_TCDataSet_LTC.V_DS_MONHOC);
                //this.v_DS_GIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet_LTC.V_DS_GIANGVIEN);
               
            }

            if (bdsLTC.Count == 0)
                btnXoa.Enabled = btnSua.Enabled = false;
            else
                btnXoa.Enabled = btnSua.Enabled = true;
        }


        private void cmbTenGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenGV.SelectedValue != null)
                txtMaGiangVien.Text = cmbTenGV.SelectedValue.ToString();
        }


        private void txtMaGiangVien_EditValueChanged(object sender, EventArgs e)
        {

        }


        private void cmbTenMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTenMonHoc.SelectedValue != null)
                txtMaMonHoc.Text = cmbTenMonHoc.SelectedValue.ToString();
        }


        private void txtMaMonHoc_EditValueChanged(object sender, EventArgs e)
        {
            if (txtMaMonHoc.Text != null)
            {
                cmbTenMonHoc.SelectedValue = txtMaMonHoc.Text;
            }
        }


        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show(
                "Bạn chắc chắn muốn thoát", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
            
        }


        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng chưa hoàn thành?");
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
                    // this.LTCTableAdapter.Update(this.qLDSV_TCDataSet.LOPTINCHI); // mở ở đây ra mới xóa dc trong csdl
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
            MessageBox.Show("Chức năng chưa hoàn thành?");
            viTri = bdsLTC.Position;
            panelControlThongTinLTC.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = btnReload.Enabled = false;
            btnGhi.Enabled = btnUndo.Enabled = true;
            cmbKhoa.Enabled = false;
            cbHuyLop.Enabled = true;
        }



        // chưa có thêm stack
        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng chưa hoàn thành?");
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
            MessageBox.Show("Chức năng chưa hoàn thành?");
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
            return true;
        }


        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng chưa hoàn thành?");
            bool check = CheckInput();
            if (check == false)
                return;

            try
            {
                bdsLTC.EndEdit();
                bdsLTC.ResetCurrentItem();
                this.LTCTableAdapter.Connection.ConnectionString = Program.connstr;
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
        }



    }
}
