using QuanLyQuanBeer.DAO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
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
            listSP.DataSource = SanPhamDAO.Instance.GetListSP();
            List<LoaiSanPham> danhSachLoaiSP = LoaiSanPhamDAO.Instance.GetListLoaiSP();
            cbxLoaiSP.DataSource = danhSachLoaiSP;
            cbxLoaiSP.DisplayMember = "TenLoaiSanPham";
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            
            if (txbTenSP1.Text == "" || txbGia.Text == "" || cbxLoaiSP.Text == ""|| txbDonVi.Text == "")
                MessageBox.Show("Bạn phải nhập đủ thông tin!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                if (rdbtDoUong.Checked = false && rdbtKhac.Checked == false && rdbtMonAn.Checked == false)
                    MessageBox.Show("Bạn phải nhập đủ thông tin!!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                else
                {
                    string TenSanPham = txbTenSP1.Text;
                    double Gia = Convert.ToDouble(txbGia.Text);
                    string DonVi = txbDonVi.Text;
                    // Chọn loại sản phẩm
                    LoaiSanPham loaisp = cbxLoaiSP.SelectedItem as LoaiSanPham;
                    int IDLoai = loaisp.ID;
                    if (SanPhamDAO.Instance.GetTenSP(TenSanPham) == TenSanPham)
                        MessageBox.Show("Đã có sản phẩm này", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (SanPhamDAO.Instance.ThemSP(TenSanPham, DonVi, Gia, IDLoai))
                        {
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
    }
}
