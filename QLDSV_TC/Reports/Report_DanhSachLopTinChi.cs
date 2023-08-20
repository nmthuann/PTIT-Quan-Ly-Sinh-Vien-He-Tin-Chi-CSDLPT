using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace QLDSV_TC.Reports
{
    public partial class Report_DanhSachLopTinChi : DevExpress.XtraReports.UI.XtraReport
    {
        public Report_DanhSachLopTinChi(string maKhoa, string NienKhoa, int HocKy)
        {
            InitializeComponent();
            
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[7].Parameters[0].Value = maKhoa;
            this.sqlDataSource1.Queries[7].Parameters[1].Value = NienKhoa;
            this.sqlDataSource1.Queries[7].Parameters[2].Value = HocKy;
            this.sqlDataSource1.Fill();
        }

    }
}
