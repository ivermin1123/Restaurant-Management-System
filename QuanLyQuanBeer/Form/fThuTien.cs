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
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 500000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt200_Click(object sender, EventArgs e)
        {
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 200000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt100_Click(object sender, EventArgs e)
        {
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 100000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt50_Click(object sender, EventArgs e)
        {
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 50000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt20_Click(object sender, EventArgs e)
        {
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 20000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt10_Click(object sender, EventArgs e)
        {
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 10000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 5000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 2000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 1000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void TxbTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            /*decimal tienKhachDua = decimal.Parse(txbTienKhachDua.Text);
            decimal tienThu = decimal.Parse(lbTienThu.Text);
            string tienTraLai = (tienKhachDua - tienThu).ToString();
            lbTienTraLai.Text = tienTraLai;

            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(lbTienTraLai.Text, NumberStyles.AllowThousands);
            lbTienTraLai.Text = String.Format(culture, "{0:N0}", value);*/
        }
    }
}
