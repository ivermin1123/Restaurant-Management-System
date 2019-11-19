using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace QuanLyQuanBeer
{
    public partial class fThuTien : Form
    {
        public fThuTien()
        {
            InitializeComponent();
        }

        void LoadTien()
        {
            decimal TienThuDoi = decimal.Parse(lbTienTraLai.Text); // 344.800
            //decimal TienThuCheck = (TienThuDoi % 10000); // 4800

            // Làm tròn >= 5k -> 10k || <5k -> 5k
            /*decimal Change;
            if (TienThuCheck == 5000 || TienThuCheck > 5000)
                Change = 10000;
            else
                Change = 5000;
            decimal HienThi = TienThuDoi - TienThuCheck + Change;*/

            txbTienThua.Text = lbTienTraLai.Text;

            // Đổi định dạng hiển thị
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(txbTienThua.Text, NumberStyles.Currency);
            txbTienThua.Text = String.Format(culture, "{0:N0}", value);
            txbTienMat.Text = txbTienKhachDua.Text;
        }
        private void BtThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HienthiTienVN()
        {
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(txbTienKhachDua.Text, NumberStyles.AllowThousands);
            txbTienKhachDua.Text = String.Format(culture, "{0:N0}", value);
            txbTienKhachDua.Select(txbTienKhachDua.Text.Length, 0);
        }
        private void Bt500_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == "")
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 500000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt200_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == "")
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 200000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt100_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == "")
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 100000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt50_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == "")
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 50000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt20_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == "")
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 20000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt10_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == "")
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 10000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == "")
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 5000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == "")
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 2000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == "")
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 1000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void TxbTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            txbTienKhachDua.Focus();
            txbTienKhachDua.SelectionStart = txbTienKhachDua.Text.Length;
            if (txbTienKhachDua.Text == "")
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhachDua = decimal.Parse(txbTienKhachDua.Text);
            if (lbTienThu.Text == "")
                lbTienThu.Text = 0.ToString();
            decimal tienThu = decimal.Parse(lbTienThu.Text);
            string tienTraLai = (tienKhachDua - tienThu).ToString();
            lbTienTraLai.Text = tienTraLai;

            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(lbTienTraLai.Text, NumberStyles.Currency);
            lbTienTraLai.Text = String.Format(culture, "{0:N0}", value);

            decimal value1 = decimal.Parse(txbTienKhachDua.Text, NumberStyles.Currency);
            txbTienKhachDua.Text = String.Format(culture, "{0:N0}", value1);
            LoadTien();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (lbTienTraLai.Text != "")
            {
                pnTinhTien.Visible = true;
                LoadTien();
                decimal value = decimal.Parse(lbTienTraLai.Text);
                if (value > 0 )
                {
                    panel16.Visible = true;
                }
                else
                    panel16.Visible = false;
            }
        }


        private void TxbTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (decimal.Parse(txbTienKhachDua.Text) > 999999999999999999)
                MessageBox.Show("Số bạn nhập vượt qua phạm vi cho phép");
            if ((Convert.ToInt32(e.KeyChar) >= 48 && Convert.ToInt32(e.KeyChar) <= 57) || Convert.ToInt32(e.KeyChar) == 8)
            {
                e.Handled = false;
            }
            else e.Handled = true;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
            panel16.Visible = false;
            pnTinhTien.Visible = false;
        }
    }
}
