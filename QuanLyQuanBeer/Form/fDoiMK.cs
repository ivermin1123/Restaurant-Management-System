using QuanLyQuanBeer.DAO;
using QuanLyQuanBeer.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fDoiMK : Form
    {
        private string tenDN;

        public fDoiMK(string _tenDN)
        {
            InitializeComponent();
            tenDN = _tenDN;
            txbTenDangNhap.Text = tenDN;
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDoiMK_Click_1(object sender, EventArgs e)
        {
            string passWord = txbMKCu.Text;
            if (passWord != "")
            {
                TaiKhoanDTO accNow = TaiKhoanDAO.Instance.layTaiKhoan(txbTenDangNhap.Text);
                if (passWord == accNow.MatKhau)
                    if (txbMKMoi.Text == txbNhapLaiMK.Text)
                    {
                        bool rs = TaiKhoanDAO.Instance.DoiMK(txbTenDangNhap.Text, txbMKMoi.Text);
                        if (rs)
                            MessageBox.Show("Đổi mật khẩu thành công", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Đổi mật khẩu không thành công", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MessageBox.Show("Mật khẩu không khớp", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                    MessageBox.Show("Sai mật khẩu", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Bạn phải nhập mật khẩu cũ", "Cập nhật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}