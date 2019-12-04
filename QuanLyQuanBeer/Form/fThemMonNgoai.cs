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
        private int _idBan;
        private string _TenBan;
        public fThemMonNgoai(int idHoaDon,int idBan,string TenBan)
        {
            InitializeComponent();
            _idHoaDon = idHoaDon;
            _idBan = idBan;
            _TenBan = TenBan;
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
                int idSP = SanPhamDAO.Instance.GetIDByTenSP(tenSP);
                double tongCong = double.Parse(txbThanhTien.Text);
                if (SanPhamDAO.Instance.GetTenSP(tenSP) == tenSP)
                {
                    if (BanDAO.Instance.GetTrangThaiBanBangIDBan(_idBan) == "Trống")
                    {
                        DialogResult kq = MessageBox.Show(_TenBan + " chưa có hóa đơn.\n Bạn có muốn tạo hóa đơn mới cho bàn này chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (kq == DialogResult.OK)
                        {
                            HoaDonDAO.Instance.InsertBill(_idBan, tongCong);
                            ThongTinHoaDonDAO.Instance.InsertBillInfo(HoaDonDAO.Instance.GetMaxIdBill(), idSP, soLuong);
                            BanDAO.Instance.UpdateTrangThaiBan(_idBan);
                        }
                    }
                    else
                    {
                        ThongTinHoaDonDAO.Instance.InsertBillInfo(_idHoaDon, idSP, soLuong);
                    }
                    this.Close();
                }
                else
                {
                    if (SanPhamDAO.Instance.ThemSP1(tenSP, donVi, donGia, 5))
                    {
                        int idSP1 = SanPhamDAO.Instance.GetIDByTenSP(tenSP);
                        if (BanDAO.Instance.GetTrangThaiBanBangIDBan(_idBan) == "Trống")
                        {
                            DialogResult kq = MessageBox.Show(_TenBan + " chưa có hóa đơn.\n Bạn có muốn tạo hóa đơn mới cho bàn này chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                            if (kq == DialogResult.OK)
                            {
                                
                                HoaDonDAO.Instance.InsertBill(_idBan, tongCong);
                                ThongTinHoaDonDAO.Instance.InsertBillInfo(HoaDonDAO.Instance.GetMaxIdBill(), idSP1, soLuong);
                                BanDAO.Instance.UpdateTrangThaiBan(_idBan);
                            }
                        }
                        else
                        {
                            ThongTinHoaDonDAO.Instance.InsertBillInfo(_idHoaDon, idSP1, soLuong);
                        }
                        this.Close();
                    }
                }
            }
        }

        private void TxbDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void TxbSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
    }
}
