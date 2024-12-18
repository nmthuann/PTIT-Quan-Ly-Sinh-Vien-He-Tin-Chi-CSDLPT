﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLDSV_TC.forms
{
    public partial class frmDangKyLTC : Form
    {
        private string maKhoa = "";
        private string maSV = Program.username.ToUpper();
        // private int viTri = 0;
        // private bool flagLoadData = true;

        private BindingSource bdsDSLopTinchi_temp = new BindingSource();
        private BindingSource bdsDSLTC_SVDADANGKY_temp = new BindingSource();
        List<int> maLTCList = new List<int>();


        public frmDangKyLTC()
        {
            InitializeComponent();
            LayThongTinSV();
        }

        private void frmDangKyLTC_Load(object sender, EventArgs e)
        {
            qLDSV_TCDataSet.EnforceConstraints = false;
            this.dS_GIANGVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_GIANGVIENTableAdapter.Fill(this.qLDSV_TCDataSet.DS_GIANGVIEN);
        }

        // Lấy thông tin sinh viên
        private void LayThongTinSV()
        {
            try
            {
                DataTable dt = new DataTable();
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

        /**
         * mô tả: sẽ có 2 Table,
         *   1 là DS_LTC 
         * & 2 là DSLTC_SVDADANGKY
         */
        private void LoadDuLieuVaoDataGridView()
        {

            //  Lấy site ở hiện tại để biết ở site nào
            if (Program.mPhongBan == 0)
            {
                maKhoa = "CNTT";
            }
            else
            {
                maKhoa = "VT";
            }


            //  chứa dữ kiệu danh sách lớp tín chỉ
            string cmd_DSLOPTINCHI =
                "EXEC [dbo].[SP_DSLOPTINCHI] '"
                + maKhoa + "', '"
                + cmbNienKhoa.Text + "',"
                + int.Parse(speHocKy.Text);
            DataTable tableDSLopTinChi = Program.ExecSqlDataTable(cmd_DSLOPTINCHI);
            this.bdsDSLopTinchi_temp.DataSource = tableDSLopTinChi;

            this.dataGridView1.DataSource = tableDSLopTinChi;
            // this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataGridViewCheckBoxColumn dangKyColumn = new DataGridViewCheckBoxColumn();
            dangKyColumn.HeaderText = "Đăng Ký";
            dangKyColumn.Name = "colDangKy";
            dataGridView1.Columns.Add(dangKyColumn);



            // chứa dữ liệu danh sách lớp tín chỉ mà sinh viên đã đăng ký
            string cmd_SP_DSLTC_SVDADANGKY =
                "EXEC [dbo].[SP_DSLTC_SV_DADANGKY] '"
                + maSV + "', '"
                + cmbNienKhoa.Text + "',"
                + int.Parse(speHocKy.Text) + ",'"
                + maKhoa + "'";
            DataTable tableDSLTC_SV_DADANGKY = Program.ExecSqlDataTable(cmd_SP_DSLTC_SVDADANGKY);
            this.bdsDSLTC_SVDADANGKY_temp.DataSource = tableDSLTC_SV_DADANGKY;
            this.gc_DSLTC_SVDADANGKY.DataSource = this.bdsDSLTC_SVDADANGKY_temp;


            /**
             *  Đã lấy dc cái giá trị của cột MALTC -> lấy các mã đã lấy dc dò vào table DSLTC
             *  set Check Box DANG KY đã chọn ứng vs mã đã lấy dc
             * **/


            // lưu các mã LTC -> 
            foreach (DataRow row in tableDSLTC_SV_DADANGKY.Rows)
            {
                // Đảm bảo cột MaLTC tồn tại trong DataTable
                // và không bị null trước khi trích xuất giá trị.
                if (row["MALTC"] != DBNull.Value)
                {
                    string maLTC = row["MALTC"].ToString();
                    maLTCList.Add(int.Parse(maLTC));
                }
            }


            //  gán giá trị cho col DangKy
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Kiểm tra nếu dòng được gắn dữ liệu
                if (row.DataBoundItem is DataRowView dataRowView)
                {
                    DataRow dataRow = dataRowView.Row;

                    // Kiểm tra xem giá trị cột MALTC có trong danh sách maLTCList hay không
                    int maLTC = Convert.ToInt32(dataRow["MALTC"]);
                    bool isMaLTCPresent = maLTCList.Contains(maLTC);

                    // Gán giá trị true/false cho cột đăng ký
                    DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)row.Cells["colDangKy"];
                    checkBoxCell.Value = isMaLTCPresent; // true hoặc false
                }
            }
        }


        //    Hạn chế Cell Dirty Click
        void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }



        private void btnFilter_Click(object sender, EventArgs e)
        {
            /**
             * TODO: chưa fix được Click vào Filter nhiều lần
             */

            if (cmbNienKhoa.Text == "")
            {
                MessageBox.Show("Vui lòng Chọn Niên Khóa!");
                return;
            }

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();

            /**
             * Xóa Cột DK trong DataGridView
             * -> mỗi lần load sẽ add colDK
             * -> load lại phải xóa vì bị ghi đè
             */
            //if (dataGridView1.Columns.Contains("colDangKy"))
            //{
            //    dataGridView1.Columns.Remove("colDangKy");
            //}

            //  System.ArgumentException: 'Cannot clear this list.'

            try
            {
                LoadDuLieuVaoDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Load thông tin thất bại" +
                    ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // dataGridView1.CellValueChanged += new DataGridViewCellEventHandler(dataGridView1_CellValueChanged);
            // flagLoadData = true;
            btnXacNhan.Enabled = true;
            btnFilter.Enabled = false;
            MessageBox.Show("Nhấn Xác Nhận để hoàn tất!");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Hãy đảm bảo rằng chỉ xử lý khi giá trị thay đổi trong ô checkbox
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 &&
                dataGridView1.Columns[e.ColumnIndex].Name == "colDangKy")
            {
                // Lấy giá trị mới của ô checkbox
                bool newCheckBoxValue =
                    (bool)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                int maLTCCurrent =
                    Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MALTC"].Value);

                if (newCheckBoxValue)
                {
                    // xử lý khi ô checkbox được chọn (checked)
                    HandleCheckboxChecked(e, maLTCCurrent);
                    txtMaLTC.Text = maLTCCurrent.ToString();
                    dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                }
                else
                {
                    // xử lý khi ô checkbox bị bỏ chọn (unchecked)
                    HandleCheckboxUnchecked(e, maLTCCurrent);
                    txtMaLTC.Text = maLTCCurrent.ToString();
                    dataGridView1.CellValueChanged -= dataGridView1_CellValueChanged;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xác định xem người dùng đã nhấp chuột vào ô checkbox hay không
            if (
                e.RowIndex >= 0 &&
                e.ColumnIndex >= 0 &&
                dataGridView1.Columns[e.ColumnIndex] is DataGridViewCheckBoxColumn)
            {
                // Xử lý khi người dùng nhấp chuột vào ô checkbox
                dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
                ChuyenDoiTrangThaiCheckbox(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex]);
                
            }
            else if (e.RowIndex < 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Columns[e.ColumnIndex].HeaderText != "Đăng Ký")
                {
                    return;
                }
            }
        }

        private void ChuyenDoiTrangThaiCheckbox(DataGridViewCell cell)
        {
            // Thay đổi giá trị của ô checkbox (checked/unchecked)
            if (cell.Value == null) return; // dirty click
            cell.Value = !(bool)cell.Value;
            
        }


        //  false -> True
        private void HandleCheckboxChecked(DataGridViewCellEventArgs e, int maLTCCurrent)
        {

            // MessageBox.Show("Đã đăng ký");
            // Logic khi ô checkbox được chọn (checked)

            // check mã môn trùng
            string maMH = (dataGridView1.Rows[e.RowIndex].Cells["MAMH"].Value).ToString();
            int foundIndex = bdsDSLTC_SVDADANGKY_temp.Find("MAMH", maMH);
            if (foundIndex > -1)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = false;
                MessageBox.Show("Bạn đã đăng ký môn này rồi!");
            }
            else
            {
                int oldValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SVDADANGKY"].Value);

                // Giảm giá trị của ô "SVDADANGKY" đi 1
                dataGridView1.Rows[e.RowIndex].Cells["SVDADANGKY"].Value = oldValue + 1;

                DataRowView newRow = (DataRowView)bdsDSLTC_SVDADANGKY_temp.AddNew();

                int maLTC = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MALTC"].Value);
                newRow["MALTC"] = maLTC;

                // string maMH = (dataGridView1.Rows[e.RowIndex].Cells["MAMH"].Value).ToString();
                newRow["MAMH"] = maMH;

                //string maGV = (dataGridView1.Rows[e.RowIndex].Cells["MAGV"].Value).ToString();
                //newRow["MAGV"] = maGV;

                int nhom = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["NHOM"].Value);
                newRow["NHOM"] = nhom;
                newRow.EndEdit();
            }

        }


        //  true -> false
        private void HandleCheckboxUnchecked(DataGridViewCellEventArgs e, int maLTCCurrent)
        {
            // MessageBox.Show("Đã HỦY đăng ký");

            // Logic khi ô checkbox bị bỏ chọn (unchecked)

            int maLTCToRemove =
                Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["MALTC"].Value);
            int indexToRemove = -1; // khởi tạo giá trị xóa
            for (int i = 0; i < bdsDSLTC_SVDADANGKY_temp.Count; i++)
            {
                DataRowView rowView = (DataRowView)bdsDSLTC_SVDADANGKY_temp[i];
                int maLTC = Convert.ToInt32(rowView["MALTC"]);
                if (maLTC == maLTCToRemove)
                {
                    indexToRemove = i;
                    break;
                }
            }

            //  xóa theo index
            if (indexToRemove >= 0)
            {
                // int c = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SVDADANGKY"].Value);
                int oldValue = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SVDADANGKY"].Value);

                // Giảm giá trị của ô "SVDADANGKY" đi 1
                dataGridView1.Rows[e.RowIndex].Cells["SVDADANGKY"].Value = oldValue - 1;
                bdsDSLTC_SVDADANGKY_temp.RemoveAt(indexToRemove);
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //  if (!dataGridView1.Focused) return;  //  click ra ngoài return
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                txtMaLTC.Text = row.Cells[0].Value.ToString();
                txtMaMH.Text = row.Cells[1].Value.ToString();
                txtTenMH.Text = row.Cells[2].Value.ToString();
                txtHoTenGV.Text = row.Cells[4].Value.ToString();
            }
        }

        private void txtMaLTC_EditValueChanged(object sender, EventArgs e){ }



        private void cmbNienKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnFilter.Enabled = true;


            //// Lấy văn bản của mục được chọn trong ComboBox
            //string selectedText = cmbNienKhoa.SelectedItem.ToString();

            //// Trích xuất phần đầu của chuỗi để lấy năm bắt đầu (ví dụ: "2021" từ chuỗi "2021-2022")
            //string startYearString = selectedText.Split('-')[0];

            //// Chuyển đổi năm bắt đầu sang kiểu số nguyên (int)
            //int startYear;
            //if (int.TryParse(startYearString, out startYear))
            //{
            //    // Lấy năm hiện tại
            //    int currentYear = DateTime.Now.Year;

            //    // So sánh năm bắt đầu với năm hiện tại
            //    if (startYear == currentYear)
            //    {    
            //        // Bật nút Filter
            //        btnFilter.Enabled = true;
            //    }
            //    else
            //    {
            //        MessageBox.Show(
            //            "Ngoài thời gian đăng ký lớp tín chỉ.", 
            //            "Thông Báo", 
            //            MessageBoxButtons.OK, 
            //            MessageBoxIcon.Information);
            //    }
            //}
            //else
            //{
            //    // Xử lý lỗi nếu không chuyển đổi được chuỗi năm bắt đầu sang kiểu số nguyên
            //    MessageBox.Show("Lỗi: Không thể chuyển đổi năm bắt đầu của năm học thành số nguyên.");
            //}
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MALTC", typeof(int));
            DataRowView tmp;
            for (int i = 0; i < bdsDSLTC_SVDADANGKY_temp.Count; i++)
            {
                tmp = ((DataRowView)bdsDSLTC_SVDADANGKY_temp[i]);
                dt.Rows.Add(int.Parse(tmp["MALTC"].ToString()));
            }

            SqlParameter param = new SqlParameter();
            param.SqlDbType = SqlDbType.Structured;
            param.TypeName = "dbo.TYPE_CAPNHAT_DANGKY";
            param.ParameterName = "@DK";
            param.Value = dt;

            SqlParameter param2 = new SqlParameter();
            param2.SqlDbType = SqlDbType.NChar;
            param2.ParameterName = "@MASV";
            param2.Value = maSV;

            Program.KetNoi();

            SqlCommand cmd = new SqlCommand("SP_DANGKY_LTC", Program.conn);
            cmd.Parameters.Clear();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(param);
            cmd.Parameters.Add(param2);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ghi thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ghi thất bại: " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            List<int> maLTCCurentList = new List<int>();
            DataRowView tmp;
            for (int i = 0; i < bdsDSLTC_SVDADANGKY_temp.Count; i++)
            {
                tmp = ((DataRowView)bdsDSLTC_SVDADANGKY_temp[i]);
                maLTCCurentList.Add(int.Parse(tmp["MALTC"].ToString()));
            }

            HashSet<int> setCurrent = new HashSet<int>(maLTCCurentList);
            HashSet<int> setInit = new HashSet<int>(maLTCList);
            bool check = setCurrent.SetEquals(setInit);

            if (MessageBox.Show(
               "Bạn chắc chắn muốn thoát", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (!check)
                {
                    MessageBox.Show(
                        "Môn Học Đăng Ký của bạn có sự thay đổi, Vui Lòng ấn Xác nhận!", 
                        "Thông Báo", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    return;
                }
                this.Close();
            }
        }

        private void dataGridView1_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            {
                base.OnClick(e);
                e.Column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }

}