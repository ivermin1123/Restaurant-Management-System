using QuanLyQuanBeer.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fThemTK : Form
    {
        public fThemTK()
        {
            InitializeComponent();
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            string userName = txbTenTaiKhoan.Text;
            string passWord = txbMatKhau.Text;
            string loai;
            if (rdbtNhanVien.Checked)//
            {
                loai = "Nhân viên";
            }
            else
                loai = "Quản lý";
            if (userName == "" || passWord == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (rdbtNhanVien.Checked == false && rdbtQuanLy.Checked == false)
                    MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if (TaiKhoanDAO.Instance.layTenDangNhap(userName) == userName)
                        MessageBox.Show("Đã có tài khoản này", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        if (TaiKhoanDAO.Instance.them(userName, passWord, loai))
                        {
                            MessageBox.Show("Thêm thành công!", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DialogResult kq = MessageBox.Show("Hãy thêm thông tin cho tài khoản này !!!", "Thêm thông tin tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (kq == DialogResult.OK)
                            {
                                fThemTTNV f = new fThemTTNV(userName);
                                f.ShowDialog();
                            }
                        }
                        else
                            MessageBox.Show("Thêm không thành công!", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        this.Close();
                    }
                }


            }
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
