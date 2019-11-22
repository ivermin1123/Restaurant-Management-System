using QuanLyQuanBeer.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class USCSanPham : UserControl
    {
        BindingSource listSP = new BindingSource();
        public USCSanPham()
        {
            InitializeComponent();
            LoadAccount();
            binding();
        }

        void LoadAccount()
        {
            dtgvSanPham.DataSource = listSP;
            listSP.DataSource = SanPhamDAO.Instance.GetListSP();
            dtgvSanPham.Columns[0].HeaderText = "ID";
            dtgvSanPham.Columns[0].FillWeight = 25;
            dtgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
            dtgvSanPham.Columns[1].FillWeight = 130;
            dtgvSanPham.Columns[2].HeaderText = "Đơn vị";
            dtgvSanPham.Columns[3].HeaderText = "Giá";
            dtgvSanPham.Columns[4].HeaderText = "Loại";
            dtgvSanPham.Columns[5].HeaderText = "Danh mục";
        }

        void binding()
        {
            txbMaSP1.DataBindings.Add("Text", dtgvSanPham.DataSource, "id", true, DataSourceUpdateMode.Never);
            txbTenSP1.DataBindings.Add("Text", dtgvSanPham.DataSource, "TenSanPham", true, DataSourceUpdateMode.Never);
            txbGia.DataBindings.Add("Text", dtgvSanPham.DataSource, "Gia", true, DataSourceUpdateMode.Never);
            txbDonVi.DataBindings.Add("Text", dtgvSanPham.DataSource, "DonVi", true, DataSourceUpdateMode.Never);
        }

        private void bdCbx()
        {
            string tenSP = txbTenSP1.Text;
            int idLoai = SanPhamDAO.Instance.GetIdLoai(tenSP);
            string tenLSP = LoaiSanPhamDAO.Instance.GetLoaiSPByID(idLoai);
            txbLoaiSP.Text = tenLSP;
        }

        private void bdRDBT()
        {
            string tenLSP = txbLoaiSP.Text;
            txbDanhMuc.Text = LoaiSanPhamDAO.Instance.layDanhMuc(tenLSP);
        }

        private void BtThemSP_Click(object sender, EventArgs e)
        {
            fThemSP f = new fThemSP();
            f.ShowDialog();
        }

        private void BtSuaSP_Click(object sender, EventArgs e)
        {
            string TenSanPham = txbTenSP1.Text;
            double Gia = Convert.ToDouble(txbGia.Text);
            int IDLoai = SanPhamDAO.Instance.GetIdLoai(TenSanPham);
            int MaSP = int.Parse(txbMaSP1.Text);
            string DonVi = txbDonVi.Text;
            if (txbTenSP1.Text == "" || txbGia.Text == "")
                MessageBox.Show("Bạn phải nhập đủ!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (TenSanPham == SanPhamDAO.Instance.GetTenSP(TenSanPham))
                MessageBox.Show("Đã có sản phẩm này!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (SanPhamDAO.Instance.capNhatSP(TenSanPham, DonVi, Gia, IDLoai, MaSP))
                {
                    MessageBox.Show("Cập nhật thành công!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!", "Cập nhật sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtLamMoi_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void BtXoaSP_Click(object sender, EventArgs e)
        {
            string tenSanPham = txbTenSP1.Text;
            if (SanPhamDAO.Instance.XoaSP(tenSanPham))
            {
                MessageBox.Show("Xóa thành công!", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccount();
            }
            else
                MessageBox.Show("Xóa không thành công!", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void txbTenSP1_TextChanged(object sender, EventArgs e)
        {
            bdCbx();
            bdRDBT();
        }
    }
}
