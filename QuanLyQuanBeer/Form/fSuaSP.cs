using QuanLyQuanBeer.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fSuaSP : Form
    {
        private string _tenSP;
        private double _gia;
        private int _idLoai;
        private int _maSP;
        private string _donVi;
        private string _danhMuc;
        private string _loaiSP;

        public fSuaSP(string tenSP, double gia, int idLoai, int maSP, string donVi, string danhMuc, string loaiSP)
        {
            InitializeComponent();
            _tenSP = tenSP; _gia = gia; _idLoai = idLoai; _maSP = maSP; _donVi = donVi; _danhMuc = danhMuc; _loaiSP = loaiSP;
            txbTenSP1.Text = _tenSP;
            txbGia.Text = _gia.ToString();
            txbDonVi.Text = _donVi;
            txbLoaiSP.Text = _loaiSP;
            txbDanhMuc.Text = _danhMuc;
        }


        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string TenSanPham = txbTenSP1.Text;
            double Gia = Convert.ToDouble(txbGia.Text);
            string DonVi = txbDonVi.Text;
            if (txbTenSP1.Text == "" || txbGia.Text == "")
                MessageBox.Show("Bạn phải nhập đủ!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (SanPhamDAO.Instance.capNhatSP(TenSanPham, DonVi, Gia, _idLoai, _maSP))
                {
                    MessageBox.Show("Cập nhật thành công!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }
    }
}
