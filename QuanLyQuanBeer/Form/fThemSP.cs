using QuanLyQuanBeer.DAO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fThemSP : Form
    {
        BindingSource listSP = new BindingSource();
        public fThemSP()
        {
            InitializeComponent();
            LoadAccount();
        }

        void LoadAccount()
        {
            //listSP.DataSource = SanPhamDAO.Instance.GetListSP();
            List<LoaiSanPhamDTO> danhSachLoaiSP = LoaiSanPhamDAO.Instance.GetListLoaiSP();
            cbxLoaiSP.DataSource = danhSachLoaiSP;
            cbxLoaiSP.DisplayMember = "TenLoaiSanPham";
        }

        public static string LocDau(string s)
        {
            // Hàm chuyển có dấu thành không dấu và xóa khoảng trắng
            // VD : "Cá lóc kho tộ" => "Calockhocto"
            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').Replace(" ", string.Empty);
        }

        private void BtThem_Click(object sender, EventArgs e)
        {

            if (txbTenSP1.Text == string.Empty || txbGia.Text == string.Empty || cbxLoaiSP.Text == string.Empty || txbDonVi.Text == string.Empty)
                MessageBox.Show("Bạn phải nhập đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (rdbtDoUong.Checked = false && rdbtKhac.Checked == false && rdbtMonAn.Checked == false)
                    MessageBox.Show("Bạn phải nhập đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    string TenSanPham = txbTenSP1.Text;
                    double Gia = Convert.ToDouble(txbGia.Text);
                    string DonVi = txbDonVi.Text;
                    // Chọn loại sản phẩm
                    LoaiSanPhamDTO loaisp = cbxLoaiSP.SelectedItem as LoaiSanPhamDTO;
                    int IDLoai = loaisp.ID;
                    if (SanPhamDAO.Instance.GetTenSP(TenSanPham) == TenSanPham)
                        MessageBox.Show("Đã có sản phẩm này", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        // abcdefgh.jpg
                        string somestring = txbDuongDan.Text;
                        string newstring = somestring.Substring(somestring.Length - 4, 4);// Lấy 4 ký tự cuối cùng của đường dẫn
                        string tenAnh = LocDau(TenSanPham) + newstring;
                        if (SanPhamDAO.Instance.ThemSP(TenSanPham, DonVi, Gia, IDLoai, tenAnh))
                        {
                            File.Copy(txbDuongDan.Text, Path.Combine(@"..//..//..//Pic Food/", Path.GetFileName(tenAnh)), true);
                            MessageBox.Show("Thêm thành công!", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                            MessageBox.Show("Thêm không thành công!", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }
            }

        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void BtChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp;) | *.jpg; *.jpeg; *.gif; *.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txbDuongDan.Text = open.FileName;
                ptbHienThiAnh.Image = new Bitmap(open.FileName);
                ptbHienThiAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
