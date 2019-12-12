using Microsoft.Reporting.WinForms;
using QuanLyQuanBeer.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class rptBC : Form
    {
        private int _idBan;

        public rptBC(int idBan)
        {
            InitializeComponent();
            this._idBan = idBan;
        }

        private void rptBC_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        public void XuatHoaDon(int maHD, string tenban, string NhanVien, DateTime? GioVao, DateTime? GioRa)
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.Instance.GetListSP2(_idBan);
            this.reportViewer1.LocalReport.ReportPath = @"../../rptBC.rdlc";
            ReportParameter[] param = new ReportParameter[5];
            param[0] = new ReportParameter("Ban", tenban);
            param[1] = new ReportParameter("maHD", "HD" + maHD.ToString());
            param[2] = new ReportParameter("GioVao", GioVao.ToString());
            param[3] = new ReportParameter("TN", NhanVien);
            param[4] = new ReportParameter("GioRa", GioRa.ToString());
            this.reportViewer1.LocalReport.SetParameters(param);
            if (dt.Rows.Count > 0)
            {
                ReportDataSource rds = new ReportDataSource();
                rds.Name = "dsBill";
                rds.Value = dt;
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(rds);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}