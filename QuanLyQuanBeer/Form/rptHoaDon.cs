using QuanLyQuanBeer.DAO;
using System;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using System.Data;

namespace QuanLyQuanBeer
{
    public partial class rptHoaDon : Form
    {
        private int _idBan;
        public rptHoaDon(int idBan)
        {
            InitializeComponent();
            this._idBan = idBan;
        }

        private void RptHoaDon_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        public void XuatHoaDon(int maHD, string tenban, string NhanVien, string ThanhTien, DateTime? GioVao, string VAT, string ThanhToan,string TienKhachDua,string TienThua, DateTime? GioRa)
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.Instance.GetListSP1(_idBan);
            this.reportViewer1.LocalReport.ReportPath = @"../../rptHoaDon.rdlc";
            ReportParameter[] param = new ReportParameter[10];
            param[0] = new ReportParameter("Ban", tenban);
            param[1] = new ReportParameter("MaHD", "HD" + maHD.ToString());
            param[2] = new ReportParameter("GioVao", GioVao.ToString());
            param[3] = new ReportParameter("NhanVien", NhanVien);
            param[4] = new ReportParameter("GioRa", GioRa.ToString());
            param[5] = new ReportParameter("ThanhTien", ThanhTien + " VND");
            param[6] = new ReportParameter("VAT", VAT + " VND");
            param[7] = new ReportParameter("ThanhToan", ThanhToan + " VND");
            param[8] = new ReportParameter("TienKhachDua", TienKhachDua + " VND");
            param[9] = new ReportParameter("TienThua", TienThua + " VND");
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
