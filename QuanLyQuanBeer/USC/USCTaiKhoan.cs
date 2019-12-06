using QuanLyQuanBeer.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class USCTaiKhoan : UserControl
    {
        BindingSource accountList = new BindingSource();
        public USCTaiKhoan()
        {
            InitializeComponent();
            LoadAccount();
        }

        void LoadAccount()
        {
            dtgvTaiKhoan.DataSource = accountList;
            accountList.DataSource = TaiKhoanDAO.Instance.layDSTaiKhoan();
            dtgvTaiKhoan.Columns[0].HeaderText = "Tên đăng nhập";
            dtgvTaiKhoan.Columns[1].HeaderText = "Mật khẩu";
            dtgvTaiKhoan.Columns[2].HeaderText = "Loại tài khoản";
        }

        private void BtThemTK_Click(object sender, EventArgs e)
        {
            fThemTK f = new fThemTK();
            f.ShowDialog();
            LoadAccount();
        }

        private void BtXoaTK_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dtgvTaiKhoan.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dtgvTaiKhoan.Rows[selectedrowindex];
            string tenDN = Convert.ToString(selectedRow.Cells["TenDangNhap"].Value);
            if (tenDN == "admin")
            {
                MessageBox.Show("Đừng tự delete bản thân như vậy chứ ??", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DialogResult rv = MessageBox.Show("Xóa tài khoản sẽ xóa cả thông tin nhân viên.\nBạn có chắc không ?", "Xóa tài khoản", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rv == DialogResult.OK)
                {
                    if (TaiKhoanDAO.Instance.xoa(tenDN))
                    {
                        MessageBox.Show("Xóa thành công!", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAccount();
                    }
                    else
                        MessageBox.Show("Xóa không thành công!", "Xóa tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtSuaTK_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dtgvTaiKhoan.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dtgvTaiKhoan.Rows[selectedrowindex];
            string userName = Convert.ToString(selectedRow.Cells["TenDangNhap"].Value);
            string passWord = Convert.ToString(selectedRow.Cells["MatKhau"].Value); ;
            string loai = Convert.ToString(selectedRow.Cells["LoaiTaiKhoan"].Value); ;
            fSuaTK f = new fSuaTK(userName, passWord, loai);
            f.ShowDialog();
            LoadAccount();
        }

        private void BtResetTK_Click(object sender, EventArgs e)
        {
            int selectedrowindex = dtgvTaiKhoan.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dtgvTaiKhoan.Rows[selectedrowindex];
            string userName = Convert.ToString(selectedRow.Cells["TenDangNhap"].Value);
            if (TaiKhoanDAO.Instance.datLaiMK(userName))
            {
                MessageBox.Show("Đặt lại thành công!", "Đặt lại tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAccount();
            }
            else
                MessageBox.Show("Đặt lại không thành công!", "Đặt lại tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtLamMoi_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }
    }
}
