using QuanLyQuanBeer.DAO;
using System;
using System.Drawing;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fTaoVoucherSLLon : Form
    {
        public fTaoVoucherSLLon()
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

        private void btTao_Click(object sender, EventArgs e)
        {
            if (txbNoiDung.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng nhập nội dung Voucher", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txbGiamGiaTM.Text == string.Empty && txbGiamGiaPT.Text == string.Empty)
                MessageBox.Show("Bạn cần phải giảm giá % hoặc tiền mặt \n Đâu thể tạo một Voucher mà không giảm gì phải không ^^!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (txbNoiDung.Text == string.Empty)
                MessageBox.Show("Vui lòng nhập SL Voucher cần tạo !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                this.Size = new Size(566, 472);
                string TenVoucher = txbNoiDung.Text;
                if (txbGiamGiaPT.Text == string.Empty)
                    txbGiamGiaPT.Text = 0.ToString();
                int giamGia = int.Parse(txbGiamGiaPT.Text);
                if (txbGiamGiaTM.Text == string.Empty)
                    txbGiamGiaTM.Text = 0.ToString();
                double giamTien = double.Parse(txbGiamGiaTM.Text);
                DateTime hanSuDung = dtpkHSD.Value;
                int sl = int.Parse(txbSL.Text);
                for (int i = 1; i <= sl; i++)
                {
                    string s = "HUTECH" + GetUniqueKey(5);
                    VoucherDAO.Instance.ThemVoucher(s, TenVoucher, giamGia, giamTien, hanSuDung);
                    txb1.Text += s + Environment.NewLine;
                }
            }
        }

        private void btCoppy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txb1.Text);
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}