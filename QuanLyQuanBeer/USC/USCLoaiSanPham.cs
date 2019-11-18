using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanBeer.DAO;

namespace QuanLyQuanBeer.USC
{
    public partial class USCLoaiSanPham : UserControl
    {
        BindingSource listLoaiSP = new BindingSource();
        public USCLoaiSanPham()
        {
            InitializeComponent();
            LoadAccount();
            binding();
        }
        void LoadAccount()
        {
            dtgvLoaiSanPham.DataSource = listLoaiSP;
            listLoaiSP.DataSource = LoaiSanPhamDAO.Instance.GetListLoaiSP();
            dtgvLoaiSanPham.Columns[0].HeaderText = "ID";
            dtgvLoaiSanPham.Columns[1].HeaderText = "Loại sản phẩm";
        }

        void binding()
        {
            txbMaLSP.DataBindings.Add("Text", dtgvLoaiSanPham.DataSource, "id", true, DataSourceUpdateMode.Never);
            txbLoaiSP.DataBindings.Add("Text", dtgvLoaiSanPham.DataSource, "TenLoaiSanPham", true, DataSourceUpdateMode.Never);
        }

        private void BtThemLSP_Click(object sender, EventArgs e)
        {
            string LoaiSP = txbLoaiSP.Text;
            if (LoaiSP == "")
                MessageBox.Show("Bạn phải nhập đủ thông tin!", "Thêm loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (LoaiSanPhamDAO.Instance.GetLoaiSP(LoaiSP) == LoaiSP)
                MessageBox.Show("Đã có loại sản phẩm này !!", "Thêm loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                    if (LoaiSanPhamDAO.Instance.ThemLSP(LoaiSP))
            {
                MessageBox.Show("Thêm thành công!", "Thêm loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccount();
            }
            else
                MessageBox.Show("Thêm không thành công!", "Thêm loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtSuaLSP_Click(object sender, EventArgs e)
        {
            int MaLSP = int.Parse(txbMaLSP.Text);
            string LoaiSP = txbLoaiSP.Text;
            if (LoaiSP == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Cập nhật loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (LoaiSanPhamDAO.Instance.capNhatLSP(LoaiSP, MaLSP))
                {
                    MessageBox.Show("Cập nhật thành công!", "Cập nhật loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!", "Cập nhật loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtXoaLSP_Click(object sender, EventArgs e)
        {
            string tenLoaiSanPham = txbLoaiSP.Text;
            if (LoaiSanPhamDAO.Instance.xoaLSP(tenLoaiSanPham))
            {
                MessageBox.Show("Xóa thành công!", "Xóa loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccount();
            }
            else
                MessageBox.Show("Xóa không thành công!", "Xóa loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtLamMoi_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
    }
}
