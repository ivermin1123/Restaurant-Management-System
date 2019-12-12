using QuanLyQuanBeer.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer.USC
{
    public partial class USCVoucher : UserControl
    {
        private BindingSource listVC = new BindingSource();

        public USCVoucher()
        {
            InitializeComponent();
            LoadVoucher();
        }

        private void LoadVoucher()
        {
            dtgvVoucher.DataSource = listVC;
            listVC.DataSource = VoucherDAO.Instance.GetlistVC();
            dtgvVoucher.Columns[0].HeaderText = "Mã Voucher";
            dtgvVoucher.Columns[1].HeaderText = "Nội dung Voucher";
            dtgvVoucher.Columns[2].HeaderText = "Giảm giá (%)";
            dtgvVoucher.Columns[2].FillWeight = 80;
            dtgvVoucher.Columns[3].HeaderText = "Giảm giá (Tiền)";
            dtgvVoucher.Columns[4].HeaderText = "Hạn sử dụng";
            dtgvVoucher.Columns[5].HeaderText = "Trạng thái";
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            LoadVoucher();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            fTaoVoucher f = new fTaoVoucher();
            f.ShowDialog();
            LoadVoucher();
        }

        private void btThemSLL_Click(object sender, EventArgs e)
        {
            fTaoVoucherSLLon f = new fTaoVoucherSLLon();
            f.ShowDialog();
            LoadVoucher();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dtgvVoucher.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dtgvVoucher.Rows[selectedrowindex];
            string maVC = Convert.ToString(selectedRow.Cells["id"].Value);
            fSuaVoucher f = new fSuaVoucher(maVC);
            f.ShowDialog();
            LoadVoucher();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dtgvVoucher.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dtgvVoucher.Rows[selectedrowindex];
            string maVC = Convert.ToString(selectedRow.Cells["id"].Value);
            if (VoucherDAO.Instance.XoaVoucher(maVC))
            {
                MessageBox.Show("Xóa thành công", "Xóa Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Xóa không thành công", "Xóa Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadVoucher();
        }
    }
}