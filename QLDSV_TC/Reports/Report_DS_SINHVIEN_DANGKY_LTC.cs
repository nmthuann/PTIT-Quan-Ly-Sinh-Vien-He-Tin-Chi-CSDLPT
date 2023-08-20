using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC.Reports
{
    public partial class Report_DS_SINHVIEN_DANGKY_LTC : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_DS_SINHVIEN_DANGKY_LTC(
            string nienKhoa, 
            int hocKy, 
            string maMH,
            int nhom,
            string maKhoa
        ) {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = nienKhoa;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = hocKy;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = maMH;
            this.sqlDataSource1.Queries[0].Parameters[3].Value = nhom;
            this.sqlDataSource1.Queries[0].Parameters[4].Value = maKhoa;
            this.sqlDataSource1.Fill();
        }

    }
}
