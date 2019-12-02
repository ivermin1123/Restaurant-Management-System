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

        public void XuatHoaDon(int maHD, int tenban)
        {
            DataTable dt = new DataTable();
            dt = MenuDAO.Instance.GetListSP1(_idBan);
            //ReportParameter[] param = new ReportParameter[2];
            //param[0] = new ReportParameter("InvoiceNo", invoice.InvoiceNo);
            //param[1] = new ReportParameter("DeliveryDateStr", string.Format("Ngày " + invoice.DeliveryDate.ToString("dd/MM/yyyy")));
            //this.reportViewer1.LocalReport.SetParameters(param);
            this.reportViewer1.LocalReport.ReportPath = "rptHoaDon.rdlc";
            if (dt.Rows.Count>0)
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
