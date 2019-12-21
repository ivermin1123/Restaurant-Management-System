using QuanLyQuanBeer.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer.USC
{
    public partial class USCKho : UserControl
    {
        private BindingSource listKho = new BindingSource();

        public USCKho()
        {
            InitializeComponent();
            LoadKho();
            binding();
        }

        private void LoadKho()
        {
            dtgvKho.DataSource = listKho;
            listKho.DataSource = KhoDAO.Instance.GetListKho();
            dtgvKho.Columns[0].HeaderText = "ID";
            dtgvKho.Columns[0].FillWeight = 25;
            dtgvKho.Columns[1].HeaderText = "Tên sản phẩm";
            dtgvKho.Columns[2].HeaderText = "Đơn vị";
            dtgvKho.Columns[3].HeaderText = "SL";
            dtgvKho.Columns[4].HeaderText = "Giá";
        }

        private void binding()
        {
            txbMaLSP.DataBindings.Add("Text", dtgvKho.DataSource, "idHang", true, DataSourceUpdateMode.Never);
            txbTenSP.DataBindings.Add("Text", dtgvKho.DataSource, "TenHang", true, DataSourceUpdateMode.Never);
            txbGia.DataBindings.Add("Text", dtgvKho.DataSource, "Gia", true, DataSourceUpdateMode.Never);
            txbSL.DataBindings.Add("Text", dtgvKho.DataSource, "SL", true, DataSourceUpdateMode.Never);
            txbDVT.DataBindings.Add("Text", dtgvKho.DataSource, "DVT", true, DataSourceUpdateMode.Never);
        }

        private void btThemLSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbTenSP.Text == string.Empty || txbGia.Text == string.Empty || txbSL.Text == string.Empty)
                    MessageBox.Show("Bạn phải nhập đủ thông tin!", "Thêm loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    int soLuong = int.Parse(txbSL.Text);
                    double gia = double.Parse(txbGia.Text);
                    string tenSP = txbTenSP.Text;
                    string DVT = txbDVT.Text;
                    if (KhoDAO.Instance.ThemSP(tenSP, soLuong, gia, DVT))
                    {
                        MessageBox.Show("Thêm thành công!", "Thêm kho", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKho();
                    }
                    else
                        MessageBox.Show("Thêm không thành công!", "Thêm kho", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSuaLSP_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbTenSP.Text == string.Empty || txbGia.Text == string.Empty || txbSL.Text == string.Empty)
                    MessageBox.Show("Bạn phải nhập đủ thông tin!", "Thêm loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    int id = int.Parse(txbMaLSP.Text);
                    int soLuong = int.Parse(txbSL.Text);
                    double gia = double.Parse(txbGia.Text);
                    string tenSP = txbTenSP.Text;
                    string DVT = txbDVT.Text;
                    if (KhoDAO.Instance.CapNhatKho(tenSP, soLuong, gia, DVT, id))
                    {
                        MessageBox.Show("Cập nhật thành công!", "Cập nhật loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadKho();
                    }
                    else
                        MessageBox.Show("Cập nhật không thành công!", "Cập nhật loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            LoadKho();
        }

        private void btXoaLSP_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txbMaLSP.Text);
                if (KhoDAO.Instance.XoaKho(id))
                {
                    MessageBox.Show("Xóa thành công!", "Xóa loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKho();
                }
                else
                    MessageBox.Show("Xóa không thành công!", "Xóa loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}