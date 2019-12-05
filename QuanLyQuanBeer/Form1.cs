using QuanLyQuanBeer.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class Form1 : Form
    {
        BindingSource listSP = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            XemHoaDon();
        }

        void XemHoaDon()
        {
            DataTable danhSachThongTinHoaDon = MenuDAO.Instance.GetListSP(1);
            // dtgvHoaDon.DataSource = listSP;
            listSP.DataSource = MenuDAO.Instance.GetListSP(1);
        }

        private void DtgvHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DtgvHoaDon_SelectionChanged(object sender, EventArgs e)
        {
            /*if (dtgvHoaDon.SelectedCells.Count > 0)
            {
                int selectedrowindex = dtgvHoaDon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvHoaDon.Rows[selectedrowindex];
                string a = Convert.ToString(selectedRow.Cells["SoLuong"].Value);
                string b = Convert.ToString(selectedRow.Cells["TenSanPham"].Value);
                int SL = int.Parse(a);
                int idSP = SanPhamDAO.Instance.GetIDByTenSP(b);
                ThongTinHoaDonDAO.Instance.UpdateSL(SL,100,idSP);
            }*/
        }
    }
}
