using QuanLyQuanBeer.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{

    public partial class fSuaTK : Form
    {
        private string _userName;
        private string _passWord;
        private string _loai;
        public fSuaTK(string userName,string passWord, string loai)
        {
            InitializeComponent();
            _userName = userName;
            _passWord = passWord;
            _loai = loai;
            txbTenTaiKhoan.Text = _userName;
            txbMatKhau.Text = _passWord;
            if (_loai == "Nhân viên")
                rdbtNhanVien.Checked = true;
            else
                rdbtQuanLy.Checked = true;
        }

        private void txbTenTaiKhoan_TextChanged(object sender, EventArgs e)
        {
            if (_userName == "admin")
                rdbtNhanVien.Enabled = false;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThayDoi_Click(object sender, EventArgs e)
        {
            string passWord = txbMatKhau.Text;
            string loai;
            if (rdbtNhanVien.Checked)
            {
                loai = "Nhân viên";
            }
            else
                loai = "Quản lý";
            if (passWord == "")
                MessageBox.Show("Bạn chưa nhập đủ thông tin!", "Thêm tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if (TaiKhoanDAO.Instance.capNhatTK(passWord, loai, _userName))
                {
                    MessageBox.Show("Cập nhật thành công!", "Cập nhật tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("      Cập nhật không thành công! \nBạn không được thay đổi tên đăng nhập!!", "Cập nhật tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Close();
        }
    }
}
