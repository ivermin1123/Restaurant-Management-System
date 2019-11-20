using QuanLyQuanBeer.DAO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //sp.TenSanPham = txbTenSP1.Text;
            //sp.Gia = Convert.ToDouble(txbGia.Text);
            string TenSanPham = txbTenSP1.Text;
            double Gia = Convert.ToDouble(txbGia.Text);
            string DonVi = txbDonVi.Text;
            // Chọn loại sản phẩm
            LoaiSanPham loaisp = cbxLoaiSP.SelectedItem as LoaiSanPham;
            int IDLoai = loaisp.ID;
            if (txbTenSP1.Text == "" || txbGia.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đủ thông tin!!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                if (SanPhamDAO.Instance.GetTenSP(TenSanPham) == TenSanPham)
                    MessageBox.Show("Đã có sản phẩm này", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (SanPhamDAO.Instance.ThemSP(TenSanPham, DonVi, Gia, IDLoai))
                    {
                        MessageBox.Show("Thêm thành công!", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm không thành công!", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
