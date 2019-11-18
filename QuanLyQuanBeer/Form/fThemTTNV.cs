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
    public partial class fThemTTNV : Form
    {
        private string _userName;
        private string gioiTinh;
        public fThemTTNV(string userName)
        {
            InitializeComponent();
            _userName = userName;
            txbTenDN.Text = _userName;
        }

        private void BtThem_Click(object sender, EventArgs e)
        {
            string tenDN = txbTenDN.Text;
            string hoTen = txbHoTen.Text;
            string diaChi = txbDiaChi.Text;
            if (rdbtNam.Checked == true)
                gioiTinh = "Nam";
            if (rdbtNu.Checked == true)
                gioiTinh = "Nữ";
            string cMND = txbCMND.Text;
            string sDT = txbSDT.Text;
            string tuoi = txbTuoi.Text;
            if (hoTen == "" || diaChi == "" || sDT == "" || cMND == "" || tuoi == "")
                MessageBox.Show("Bạn phải nhập đủ!", "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (rdbtNam.Checked == false && rdbtNu.Checked == false)
                MessageBox.Show("Bạn phải nhập đủ!", "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                long _cMND = long.Parse(txbCMND.Text);
                long _sDT = long.Parse(txbSDT.Text);
                int _tuoi = int.Parse(txbTuoi.Text);

                if (ThongTinTaiKhoanDAO.Instance.them(hoTen, _sDT, diaChi, _cMND, _tuoi, gioiTinh, tenDN))
                {
                    MessageBox.Show("Thêm thành công!", "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm không thành công!", "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }

            }
        }

        private void TxbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void TxbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void TxbTuoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }
    }
}
