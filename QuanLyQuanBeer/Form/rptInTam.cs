using Microsoft.Reporting.WinForms;
using QuanLyQuanBeer.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class rptInTam : Form
    {
        private int _idBan;
        public rptInTam(int idBan)
        {
            InitializeComponent();
            _idBan = idBan;
        }

        private void RptInTam_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        public void XuatHoaDon(int maHD, string tenban,string NhanVien, string ThanhTien,DateTime? GioVao,string VAT,string ThanhToan)
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.Instance.GetListSP1(_idBan);
            this.reportViewer1.LocalReport.ReportPath = @"../../rptInTam.rdlc";
            ReportParameter[] param = new ReportParameter[7];
            param[0] = new ReportParameter("Ban", tenban);
            param[1] = new ReportParameter("MaHD", "HD"+maHD.ToString());
            param[2] = new ReportParameter("NhanVien", NhanVien);
            param[3] = new ReportParameter("ThanhTien", ThanhTien +" VND");
            param[4] = new ReportParameter("GioVao", GioVao.ToString());
            param[5] = new ReportParameter("VAT", VAT + " VND");
            param[6] = new ReportParameter("ThanhToan", ThanhToan + " VND");
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
