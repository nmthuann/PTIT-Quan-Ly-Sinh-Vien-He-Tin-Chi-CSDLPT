using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
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
    public partial class frmDongHocPhi : Form
    {


        private String maSV = "";
        private int positionHocPhi = -1;
        private int viTriCTHocPhi = -1;


        public frmDongHocPhi()
        {
            InitializeComponent();
        }


        // Lấy thông tin sinh viên
        private void LayThongTinSV()
        {
            try
            {

                DataTable dt = new DataTable();
                maSV = txtMaSV.Text;

                string cmd = "EXEC dbo.SP_LAYTHONGTINSINHVIEN '" + maSV + "'";
                dt = Program.ExecSqlDataTable(cmd);

                lbMaSV.Text = maSV;
                lbTenSV.Text = dt.Rows[0]["HoTen"].ToString();
                lbMaLopTenLop.Text = dt.Rows[0]["MaLop"].ToString() + "(" + dt.Rows[0]["TenLop"].ToString() + ")";
                lbTenKhoa.Text = dt.Rows[0]["TenKhoa"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show(
                    "Không thể load thông tin của bạn trong server" +
                    e.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadDuLieuHocPhi()
        {
            try
            {
                LayThongTinSV();
                this.sP_THONGTINDONGHOCPHITableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_THONGTINDONGHOCPHITableAdapter.Fill(
                    this.qLDSV_TCDataSet_HocPhi.SP_THONGTINDONGHOCPHI, maSV);
                hocPhiGridControl.DataSource = bdsThongTinDongHocPhi;

                btnThem.Enabled = true;
                if (bdsThongTinDongHocPhi.Count == 0)
                {
                    btnSua.Enabled = btnXoa.Enabled = false;
                  
                    gc_CT_DongHocPhi.Enabled = false;
                    return;
                }
                bdsThongTinDongHocPhi.Position = 0;
                LoadCTDongHocPhi();
      
                gc_CT_DongHocPhi.Enabled = true;


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                bdsThongTinDongHocPhi.DataSource = null;
                bds_CT_DongHocPhi.DataSource = null;
                lbTenSV.Text = null;
                lbMaLopTenLop.Text = null;
                // panelContent.Enabled = false;
                txtMaSV.Focus();
                btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
                maSV = null;
                viTriCTHocPhi= -1;

                return;
            }

        }

        private void LoadCTDongHocPhi()
        {
            positionHocPhi = bdsThongTinDongHocPhi.Position;
            String nienkhoa = ((DataRowView)bdsThongTinDongHocPhi[positionHocPhi])["NIENKHOA"].ToString();
            String hocky = ((DataRowView)bdsThongTinDongHocPhi[positionHocPhi])["HOCKY"].ToString();

            this.sP_CT_DONGHOCPHI_MASVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_CT_DONGHOCPHI_MASVTableAdapter.Fill(
                this.qLDSV_TCDataSet_HocPhi.SP_CT_DONGHOCPHI_MASV, maSV, nienkhoa, int.Parse(hocky));
            gc_CT_DongHocPhi.DataSource = bds_CT_DongHocPhi;

            if (bds_CT_DongHocPhi.Count > 0)
                btnSua.Enabled = btnXoa.Enabled = false;
            else
                btnSua.Enabled = btnXoa.Enabled = true;
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            LoadDuLieuHocPhi();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            viTriCTHocPhi = bds_CT_DongHocPhi.Position;
            bds_CT_DongHocPhi.AddNew();

            //  Enable Button
            btnGhi.Enabled =  btnUndo.Enabled =  true;
            btnThem.Enabled = btnXoa.Enabled = false;
            // gv_CT_DongHocPhi.Enable = True
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }


        private void gv_CT_DongHocPhi_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gv_CT_DongHocPhi.FocusedColumn.FieldName == "SOTIENDONG")
            {
                GridColumn hocPhiCol = gridViewHocPhi.Columns["HOCPHI"];
                GridColumn soTienDaDongCol = gridViewHocPhi.Columns["SOTIENDONG"];
                GridColumn tienDongCol = gv_CT_DongHocPhi.Columns["SOTIENDONG"];

                // double dongTienDong = 0;
                int hocPhi =
                    Convert.ToInt32(gridViewHocPhi.GetRowCellValue(gridViewHocPhi.FocusedRowHandle, hocPhiCol));
                int soTienDaDong =
                    Convert.ToInt32(gridViewHocPhi.GetRowCellValue(gridViewHocPhi.FocusedRowHandle, soTienDaDongCol));
                
                int tienDong = 
                    Convert.ToInt32(gv_CT_DongHocPhi.GetRowCellValue(gv_CT_DongHocPhi.FocusedRowHandle, tienDongCol));

                int checkCanDong = hocPhi - soTienDaDong;
                if (checkCanDong < tienDong)
                {
                    e.Valid = false;
                    e.ErrorText = "So Tien Dong khong hop Le!" + checkCanDong;
                }
                //else
                //{
                //    e.Valid = true;
                //    MessageBox.Show(" Thành công !");
                //}
            }
        }

        private void gv_CT_DongHocPhi_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            MessageBox.Show("Giá trị không hợp lệ: " + e.Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gv_CT_DongHocPhi_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

        }

        private void gv_CT_DongHocPhi_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }
    }
}
