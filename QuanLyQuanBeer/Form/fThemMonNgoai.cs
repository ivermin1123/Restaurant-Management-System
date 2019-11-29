using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanBeer.DAO
{
    public partial class fThemMonNgoai : Form
    {
        private int _idHoaDon;
        public fThemMonNgoai(int idHoaDon)
        {
            InitializeComponent();
            _idHoaDon = idHoaDon;
        }

        private void TxbSL_TextChanged(object sender, EventArgs e)
        {
            if (txbDonGia.Text == "")
                txbThanhTien.Text = String.Format("{0:0,0}",(double.Parse(txbSL.Text) * 0)).ToString();
            else
                txbThanhTien.Text = String.Format("{0:0,0}",(double.Parse(txbSL.Text) * double.Parse(txbDonGia.Text))).ToString();
        }

        private void TxbDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txbDonGia.Text == "")
                txbThanhTien.Text = String.Format("{0:0,0}",(double.Parse(txbSL.Text) * 0)).ToString();
            else
                txbThanhTien.Text = String.Format("{0:0,0}",(double.Parse(txbSL.Text) * double.Parse(txbDonGia.Text))).ToString();
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            if (txbDonGia.Text == "" || txbDonVi.Text == "" || txbSL.Text == "" || txbTenMon.Text == "")
                MessageBox.Show("Vui lòng nhập đầy đủ các trường !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                double donGia = double.Parse(txbDonGia.Text);
                string donVi = txbDonVi.Text;
                int soLuong = int.Parse(txbSL.Text);
                string tenSP = txbTenMon.Text;
                double tongCong = double.Parse(txbThanhTien.Text);
                if (SanPhamDAO.Instance.GetTenSP(tenSP) == tenSP)
                {
                    int idSP = SanPhamDAO.Instance.GetIDByTenSP(tenSP);
                    ThongTinHoaDonDAO.Instance.InsertBillInfo(_idHoaDon, idSP, soLuong);
                    this.Close();
                }
                else
                {
                    if (SanPhamDAO.Instance.ThemSP1(tenSP, donVi, donGia, 5))
                    {
                        int idSP = SanPhamDAO.Instance.GetIDByTenSP(tenSP);
                        ThongTinHoaDonDAO.Instance.InsertBillInfo(_idHoaDon, idSP, soLuong);
                        this.Close();
                    }
                }
                
            }
        }
    }
}
