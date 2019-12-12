using QuanLyQuanBeer.DAO;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
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
        private string _tenAnh;

        public fSuaSP(string tenSP, double gia, int idLoai, int maSP, string donVi, string danhMuc, string loaiSP, string tenAnh)
        {
            InitializeComponent();
            _tenSP = tenSP; _gia = gia; _idLoai = idLoai; _maSP = maSP; _donVi = donVi; _danhMuc = danhMuc; _loaiSP = loaiSP; _tenAnh = tenAnh;
            txbTenSP1.Text = _tenSP;
            txbGia.Text = _gia.ToString();
            txbDonVi.Text = _donVi;
            txbLoaiSP.Text = _loaiSP;
            txbDanhMuc.Text = _danhMuc;
            if (_tenAnh == string.Empty)
                _tenAnh = "Khongcohinhanh.jpg";
            ptbHienThiAnh.Image = Image.FromFile(@"..//..//..//Pic Food/" + _tenAnh);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static string LocDau(string s)
        {
            // Hàm chuyển có dấu thành không dấu và xóa khoảng trắng
            // VD : "Cá lóc kho tộ" => "Calockhocto"
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').Replace(" ", string.Empty);
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            string TenSanPham = txbTenSP1.Text;
            double Gia = Convert.ToDouble(txbGia.Text);
            string DonVi = txbDonVi.Text;
            if (txbTenSP1.Text == string.Empty || txbGia.Text == string.Empty)
                MessageBox.Show("Bạn phải nhập đủ!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (txbDuongDan.Text == string.Empty)
                    MessageBox.Show("Vui lòng chọn hình ảnh", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    string somestring = txbDuongDan.Text;
                    string newstring = somestring.Substring(somestring.Length - 4, 4);
                    string tenAnh = LocDau(TenSanPham) + newstring;
                    if (SanPhamDAO.Instance.capNhatSP(TenSanPham, DonVi, Gia, _idLoai, _maSP, tenAnh))
                    {
                        File.Copy(txbDuongDan.Text, Path.Combine(@"..//..//..//Pic Food/", Path.GetFileName(tenAnh)), true);
                        MessageBox.Show("Cập nhật thành công!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
        }

        private void BtChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;;*.png;) | *.jpg; *.jpeg; *.gif; *.bmp;*.png;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txbDuongDan.Text = open.FileName;
                ptbHienThiAnh.Image = new Bitmap(open.FileName);
                ptbHienThiAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}