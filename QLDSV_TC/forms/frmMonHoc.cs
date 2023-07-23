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
    public partial class frmMonHoc : Form
    {

        private int viTri = 0;
        public frmMonHoc()
        {
            InitializeComponent();
        }

        private void mONHOCBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void frmMonHoc_Load(object sender, EventArgs e)
        {
        
            qLDSV_TCDataSet.EnforceConstraints = false;
            // TODO: This line of code loads data into the 'qLDSV_TCDataSet_MonHoc.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);

            panelControlMonHoc.Enabled = false;
            btnGhi.Enabled = false;
            btnReload.Enabled = true;

        }

        private void sOTIET_LTSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sOTIET_THSpinEdit_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void mONHOCGridControl_Click(object sender, EventArgs e)
        {
            
        }

        private bool CheckInput()
        {
            if (txtMaMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học!", "", MessageBoxButtons.OK);
                txtMaMH.Focus();
                return false;
            }
            if (spnSTLT.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số TC LT!", "", MessageBoxButtons.OK);
                spnSTLT.Focus();
                return false;
            }

            if (spnSTTH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập số TC TH!", "", MessageBoxButtons.OK);
                spnSTTH.Focus();
                return false;
            }
            if (txtTenMH.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên môn học!", "", MessageBoxButtons.OK);
                txtTenMH.Focus();
                return false;
            }

            if (spnSTLT.Value < 0)
            {
                MessageBox.Show("Số Tiết Lý Thuyết >= 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spnSTLT.Focus();
                return false;
            }
            if (spnSTTH.Value < 0)
            {
                MessageBox.Show("Số tiết thưc hành >= 0!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spnSTTH.Focus();
                return false;
            }

            if ((spnSTLT.Value + spnSTTH.Value) <= 0 || (spnSTLT.Value + spnSTTH.Value) % 15 != 0)
            {
                MessageBox.Show("Số Tiết LT + Số Tiết TH phải lơn hơn 0 và là bội số của 15 (1 tín chỉ)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                spnSTLT.Focus();
                return false;
            }


            return true;
        }

        void resetUI()
        {
            // reset UI
            btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = true;
            btnGhi.Enabled = false;
            panelControlMonHoc.Enabled = false;
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Console.WriteLine("Vi tri con tro chuot ne: " + bdsMH.Position);
            viTri = bdsMH.Position;
            bdsMH.AddNew();

            btnThem.Enabled = false;
            panelControlMonHoc.Enabled = true;
            btnGhi.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnReload.Enabled = false;
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //MessageBox.Show("Chức năng chưa hoàn thành?");
            // Chưa bắt ràng buộc KHÔNG CHO XÓA nếu môn học đã được mở Lớp tín chỉ

            if (MessageBox.Show(
                "Xóa môn học",
                "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsMH.RemoveCurrent();
                    this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.mONHOCTableAdapter.Update(this.qLDSV_TCDataSet.MONHOC);
                    if (bdsMH.Count == 0) 
                        btnXoa.Enabled = btnSua.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Bạn hãy xóa lại" + ex.Message, "", MessageBoxButtons.OK);
                    this.mONHOCTableAdapter.Fill(this.qLDSV_TCDataSet.MONHOC);

                    // lưu vị trí để Undo
                    //bdsMH.Position

                    return;
                }
            }
        }

        private void btnSua_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnGhi.Enabled = true;
            panelControlMonHoc.Enabled = true;
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng chưa hoàn thành?");
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng chưa hoàn thành?");
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            // Thoát form nếu cả 3 đều true
            if (btnThem.Enabled && btnSua.Enabled && btnXoa.Enabled)
            {
                if (MessageBox.Show(
                    "Bạn chắc chắn muốn thoát", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    this.Close();
                }
            }

            // Hủy thao tác đối với các Action còn lại
            bdsMH.CancelEdit();
            resetUI();



        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng chưa hoàn thành?");
            bool check = CheckInput();
            if (check == false)
                return;

            try
            {
                bdsMH.EndEdit();
                bdsMH.ResetCurrentItem();
                this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
                this.mONHOCTableAdapter.Update(this.qLDSV_TCDataSet.MONHOC);
                //lOPTINCHIGridControl.Enabled = true;
                Console.WriteLine("Ghi môn học thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi vào CSDL: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            resetUI();
            mONHOCGridControl.Enabled = true;
        }

        private void mONHOCBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsMH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLDSV_TCDataSet);

        }

        private void mONHOCBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
