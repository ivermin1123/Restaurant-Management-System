using QuanLyQuanBeer.DAO;
using QuanLyQuanBeer.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fDangNhap : Form
    {
        public fDangNhap()
        {
            InitializeComponent();
        }

        private bool DangNhap(string TenDangNhap, string MatKhau)
        {
            return TaiKhoanDAO.Instance.DangNhap(TenDangNhap, MatKhau);
        }

        private void FDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thực sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btDN_Click_1(object sender, EventArgs e)
        {
            string tenDN = txbTenDangNhap.Text;
            string matKhau = txbMatKhau.Text;
            if (DangNhap(tenDN, matKhau))
            {
                TaiKhoanDTO acc = TaiKhoanDAO.Instance.layTaiKhoan(tenDN);
                if (acc.LoaiTaiKhoan == "Nhân viên")
                {
                    fQLBH1 form = new fQLBH1(acc);
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    fDieuHuong f = new fDieuHuong(acc);
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TxbTenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDN_Click_1(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                btThoat_Click(this, new EventArgs());
            }
        }

        private void TxbMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btDN_Click_1(this, new EventArgs());
            }
            if (e.KeyCode == Keys.Escape)
            {
                btThoat_Click(this, new EventArgs());
            }
        }
    }
}