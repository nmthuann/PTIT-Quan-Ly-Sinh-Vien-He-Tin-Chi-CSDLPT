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
        private int viTriHocPhi = -1;
        private int viTriChiTietHocPhi = -1;


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
                viTriChiTietHocPhi = -1;

                return;
            }

        }

        private void LoadCTDongHocPhi()
        {
            viTriHocPhi = bdsThongTinDongHocPhi.Position;
            String nienkhoa =
                ((DataRowView)bdsThongTinDongHocPhi[viTriHocPhi])["NIENKHOA"].ToString();
            String hocky =
                ((DataRowView)bdsThongTinDongHocPhi[viTriHocPhi])["HOCKY"].ToString();


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
            if (txtMaSV.Text.ToString() == "") return;
            LoadDuLieuHocPhi();
        }

        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int sotiencandong = int.Parse(((DataRowView)bdsThongTinDongHocPhi[viTriHocPhi])["SOTIENCANDONG"].ToString());
            if (sotiencandong == 0)
            {
                gc_CT_DongHocPhi.Enabled = false;
                MessageBox.Show("Sinh Viên đã đóng đủ học phí cho học kỳ này! ", "Lưu ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            gc_CT_DongHocPhi.Enabled = true;
            viTriChiTietHocPhi = bds_CT_DongHocPhi.Position;
            bds_CT_DongHocPhi.AddNew();

            //  Enable Button
            btnGhi.Enabled = btnUndo.Enabled = true;
            btnThem.Enabled = btnXoa.Enabled = false;
            // gv_CT_DongHocPhi.Enable = True
        }

        private void btnGhi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //this.sP_CT_DONGHOCPHI_MASVTableAdapter.Update(this.qLDSV_TCDataSet_HocPhi.SP_CT_DONGHOCPHI_MASV);
            DataRowView dt = (DataRowView)bds_CT_DongHocPhi[bds_CT_DongHocPhi.Position];
            String nienKhoa = nIENKHOATextEdit.Text;
            int hocKy = int.Parse(hOCKYSpinEdit.Text);
            DateTime ngayDong = Convert.ToDateTime(dt["NGAYDONG"].ToString());
            int sotiendong = int.Parse(dt["SOTIENDONG"].ToString());
            // object sotiendong = Convert.ToInt32(dt["SOTIENDONG"]);


            string cmd =
                "EXEC [dbo].[SP_DONG_HP] '"
                + maSV.ToUpper() + "' , '"
                + nienKhoa + "' , "
                + hocKy + " ,'"
                + ngayDong.ToString("MM/dd/yyyy") + "' ,"
                + sotiendong + "";

            // yyyy-MM-dd

            try
            {
                if (Program.ExecSqlNonQuery(cmd) != 0)
                    return;
                this.sP_CT_DONGHOCPHI_MASVTableAdapter.Connection.ConnectionString = Program.connstr;
                this.sP_CT_DONGHOCPHI_MASVTableAdapter.Fill(
                this.qLDSV_TCDataSet_HocPhi.SP_CT_DONGHOCPHI_MASV, maSV, nienKhoa, hocKy);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật học phí thất bại!\nLỗi: " + ex.Message);
            }
        }


    private void gv_CT_DongHocPhi_ValidatingEditor(object sender, BaseContainerValidateEditorEventArgs e)
        {
            if (gv_CT_DongHocPhi.FocusedColumn.FieldName == "SOTIENDONG")
            {
                GridColumn hocPhiCol = gridViewHocPhi.Columns["HOCPHI"];
                GridColumn soTienDaDongCol = gridViewHocPhi.Columns["SOTIENDADONG"];
                // GridColumn tienDongCol = gv_CT_DongHocPhi.Columns["SOTIENDONG"];

                // double dongTienDong = 0;
                int hocPhi =
                    Convert.ToInt32(gridViewHocPhi.GetRowCellValue(gridViewHocPhi.FocusedRowHandle, hocPhiCol));
                int soTienDaDong =
                    Convert.ToInt32(gridViewHocPhi.GetRowCellValue(gridViewHocPhi.FocusedRowHandle, soTienDaDongCol));

                //int tienDong = 
                //    Convert.ToInt32(gv_CT_DongHocPhi.GetRowCellValue(gv_CT_DongHocPhi.FocusedRowHandle, tienDongCol));

                int checkCanDong = hocPhi - soTienDaDong;

                int tien = 0;
                if (!Int32.TryParse(e.Value as String, out tien))
                {
                    e.Valid = false;
                    e.ErrorText = "So Tien Dong phải là số";
                }
                if (checkCanDong < int.Parse(e.Value as String))
                {
                    e.Valid = false;
                    e.ErrorText = "Số Tiền đóng vượt quá quy định!";
                }
            }
        }

        private void gv_CT_DongHocPhi_InvalidValueException(object sender, InvalidValueExceptionEventArgs e)
        {
            // MessageBox.Show("Giá trị không hợp lệ: " + e.Value.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            MessageBox.Show(this,e.ErrorText,"Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            e.ExceptionMode = ExceptionMode.NoAction;
        }

        private void gv_CT_DongHocPhi_ValidateRow(object sender, DevExpress.XtraGrid.Views.Base.ValidateRowEventArgs e)
        {

        }

        private void gv_CT_DongHocPhi_InvalidRowException(object sender, DevExpress.XtraGrid.Views.Base.InvalidRowExceptionEventArgs e)
        {
            e.ExceptionMode = ExceptionMode.NoAction;
        }


        //  sự kiện click vào Hàng THÔNG TIN HỌC PHÍ
        private void gridViewHocPhi_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            viTriHocPhi = bdsThongTinDongHocPhi.Position;
            string nienKhoa =
                ((DataRowView)bdsThongTinDongHocPhi[viTriHocPhi])["NIENKHOA"].ToString();
            string hocKy =
                ((DataRowView)bdsThongTinDongHocPhi[viTriHocPhi])["HOCKY"].ToString();
            string soTienCanDong =
                ((DataRowView)bdsThongTinDongHocPhi[viTriHocPhi])["SOTIENCANDONG"].ToString();

            //  Connect  -> để load dữ liệu chi tiết học phí
            this.sP_CT_DONGHOCPHI_MASVTableAdapter.Connection.ConnectionString = Program.connstr;
            this.sP_CT_DONGHOCPHI_MASVTableAdapter.Fill(
               this.qLDSV_TCDataSet_HocPhi.SP_CT_DONGHOCPHI_MASV, maSV, nienKhoa, int.Parse(hocKy));
            gc_CT_DongHocPhi.DataSource = bds_CT_DongHocPhi;
            if (int.Parse(soTienCanDong) == 0)
            {
                btnThem.Enabled = false;
                gv_CT_DongHocPhi.OptionsBehavior.ReadOnly = true;
            }
            else
            {
                gc_CT_DongHocPhi.Enabled = true;
                btnThem.Enabled = true;
                gv_CT_DongHocPhi.OptionsBehavior.ReadOnly = false;
            }
        }

        private void gv_CT_DongHocPhi_CellValueChanging(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (gv_CT_DongHocPhi.FocusedColumn.FieldName == "SOTIENDONG")
            {

                try
                {
                    GridColumn soTienCanDongCol = gridViewHocPhi.Columns["SOTIENCANDONG"];
                    object soTienCanDong = gridViewHocPhi.GetRowCellValue(0, soTienCanDongCol);
                    int update = Convert.ToInt32(soTienCanDong) - Convert.ToInt32(e.Value as String);
                    // gridViewHocPhi.SetRowCellValue(0, soTienCanDongCol, update);

                    if (update < 0)
                    {
                        sOTIENCANDONGSpinEdit.Text = "0";
                    }
                    else
                    {
                        sOTIENCANDONGSpinEdit.Text = update.ToString();
                    }
                    
                }
                catch (Exception ex)
                {
                    // ex.Message
                    MessageBox.Show(
                        this, ex.Message, "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
