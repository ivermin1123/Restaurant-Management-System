using QuanLyQuanBeer.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer.USC
{
    public partial class USCBan : UserControl
    {
        BindingSource listBan = new BindingSource();
        public USCBan()
        {
            InitializeComponent();
            LoadAccount();
            Binding();
        }

        void LoadAccount()
        {
            dtgvBan.DataSource = listBan;
            listBan.DataSource = BanDAO.Instance.LoadDsBan();
            dtgvBan.Columns[0].HeaderText = "ID";
            dtgvBan.Columns[1].HeaderText = "Loại sản phẩm";
            dtgvBan.Columns[2].HeaderText = "Trạng Thái";
        }

        void Binding()
        {
            txbIdBan.DataBindings.Add("Text", dtgvBan.DataSource, "id", true, DataSourceUpdateMode.Never);
            txbTenBan.DataBindings.Add("Text", dtgvBan.DataSource, "TenBan", true, DataSourceUpdateMode.Never);
            txbTrangThaiBan.DataBindings.Add("Text", dtgvBan.DataSource, "TrangThai", true, DataSourceUpdateMode.Never);
        }

        private void BtThemBan_Click(object sender, EventArgs e)
        {
            string tenBan = txbTenBan.Text;
            if (tenBan == string.Empty)
                MessageBox.Show("Bạn phải nhập đủ thông tin!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                if (BanDAO.Instance.GetTenBan(tenBan) == tenBan)
                MessageBox.Show("Đã có loại sản phẩm này !!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                    if (BanDAO.Instance.ThemBan(tenBan))
            {
                MessageBox.Show("Thêm thành công!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccount();
            }
            else
                MessageBox.Show("Thêm không thành công!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtXoaBan_Click(object sender, EventArgs e)
        {
            string tenBan = txbTenBan.Text;
            if (BanDAO.Instance.XoaBan(tenBan))
            {
                MessageBox.Show("Xóa thành công!", "Xóa loại bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccount();
            }
            else
                MessageBox.Show("Xóa không thành công!", "Xóa loại bàn", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtSuaBan_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbIdBan.Text);
            string tenBan = txbTenBan.Text;
            if (tenBan == string.Empty)
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Cập nhật bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (BanDAO.Instance.GetTenBan(tenBan) == tenBan)
                MessageBox.Show("Đã có bàn này !!", "Thêm bàn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (BanDAO.Instance.CapNhatBan(tenBan, id))
                {
                    MessageBox.Show("Cập nhật thành công!", "Cập nhật bàn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!", "Cập nhật loại sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
