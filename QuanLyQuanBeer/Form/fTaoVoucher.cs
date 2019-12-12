using QuanLyQuanBeer.DAO;
using System;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fTaoVoucher : Form
    {
        public fTaoVoucher()
        {
            InitializeComponent();
        }

        public static string GetUniqueKey(int size)
        {
            char[] chars =
                "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".ToCharArray();
            byte[] data = new byte[size];
            using (RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider())
            {
                crypto.GetBytes(data);
            }
            StringBuilder result = new StringBuilder(size);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        private void btTao_Click_1(object sender, EventArgs e)
        {
            if (txbNoiDung.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập nội dung Voucher", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txbGiamGiaTM.Text == string.Empty && txbGiamGiaPT.Text == string.Empty)
                MessageBox.Show("Bạn cần phải giảm giá % hoặc tiền mặt \n Đâu thể tạo một Voucher mà không giảm gì phải không ^^!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                this.Size = new Size(547, 433);
                if (txbVoucher.Text != string.Empty)
                    MessageBox.Show("Voucher đã được tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    txbVoucher.Text = "HUTECH" + GetUniqueKey(5);
                    lbhehe.Visible = true;
                    lbhehe1.Visible = true;
                    txbVoucher.Visible = true;
                    string id = txbVoucher.Text;
                    string TenVoucher = txbNoiDung.Text;
                    if (txbGiamGiaPT.Text == string.Empty)
                        txbGiamGiaPT.Text = 0.ToString();
                    int giamGia = int.Parse(txbGiamGiaPT.Text);
                    if (txbGiamGiaTM.Text == string.Empty)
                        txbGiamGiaTM.Text = 0.ToString();
                    double giamTien = double.Parse(txbGiamGiaTM.Text);
                    DateTime hanSuDung = dtpkHSD.Value;
                    if (VoucherDAO.Instance.ThemVoucher(id, TenVoucher, giamGia, giamTien, hanSuDung))
                    {
                        MessageBox.Show("Thêm thành công!", "Thêm Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Thêm không thành công!", "Thêm sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbGiamGiaPT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void txbGiamGiaTM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void txbGiamGiaTM_TextChanged(object sender, EventArgs e)
        {
            txbGiamGiaTM.Focus();
            txbGiamGiaTM.SelectionStart = txbGiamGiaTM.Text.Length;
            if (txbGiamGiaTM.Text == string.Empty)
                txbGiamGiaTM.Text = 0.ToString();
            CultureInfo culture = new CultureInfo("en-US");
            decimal value1 = decimal.Parse(txbGiamGiaTM.Text, NumberStyles.Currency);
            txbGiamGiaTM.Text = String.Format(culture, "{0:N0}", value1);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}