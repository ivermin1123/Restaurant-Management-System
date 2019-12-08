using QuanLyQuanBeer.DAO;
using System;
using System.IO;
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
            dtgvSanPham.Columns[2].FillWeight = 45;
            dtgvSanPham.Columns[3].HeaderText = "Giá";
            dtgvSanPham.Columns[3].FillWeight = 70;
            dtgvSanPham.Columns[4].HeaderText = "Loại";
            dtgvSanPham.Columns[4].FillWeight = 60;
            dtgvSanPham.Columns[5].HeaderText = "Danh mục";
            dtgvSanPham.Columns[5].FillWeight = 70;
            dtgvSanPham.Columns[6].HeaderText = "Hình ảnh";
        }


        private void BtThemSP_Click(object sender, EventArgs e)
        {
            fThemSP f = new fThemSP();
            f.ShowDialog();
            LoadAccount();
        }

        private void BtSuaSP_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dtgvSanPham.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dtgvSanPham.Rows[selectedrowindex];
            string tenSP = Convert.ToString(selectedRow.Cells["TenSanPham"].Value);
            double gia = Convert.ToDouble(selectedRow.Cells["Gia"].Value);
            int idLoai = SanPhamDAO.Instance.GetIdLoai(tenSP);
            int maSP = Convert.ToInt32(selectedRow.Cells["id"].Value);
            string donVi = Convert.ToString(selectedRow.Cells["DonVi"].Value);
            string danhMuc = LoaiSanPhamDAO.Instance.GetDanhMucSPByID(idLoai);
            string loaiSP = LoaiSanPhamDAO.Instance.GetLoaiSPByID(idLoai);
            string tenAnh = Convert.ToString(selectedRow.Cells["HinhAnh"].Value);
            fSuaSP f = new fSuaSP(tenSP, gia, idLoai, maSP, donVi, danhMuc, loaiSP, tenAnh);
            f.ShowDialog();
            LoadAccount();
        }

        private void BtLamMoi_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        private void BtXoaSP_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dtgvSanPham.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dtgvSanPham.Rows[selectedrowindex];
            string tenSanPham = Convert.ToString(selectedRow.Cells["TenSanPham"].Value);
            string hinhAnh = SanPhamDAO.Instance.GetTenHinhAnh(tenSanPham);
            if (SanPhamDAO.Instance.XoaSP(tenSanPham))
            {
                if (hinhAnh == string.Empty)
                {
                    MessageBox.Show("Xóa thành công!", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                else
                {
                    File.Delete(@"..//..//..//Pic Food/" + hinhAnh);
                    MessageBox.Show("Xóa thành công!", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                
            }
            else
                MessageBox.Show("Xóa không thành công!", "Xóa sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
