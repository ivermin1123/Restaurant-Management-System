using System;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fThuTien : Form
    {
        private string _tongTien;
        public fThuTien(string tongTien)
        {
            InitializeComponent();
            _tongTien = tongTien;
            Load1();
        }

        void Load1()
        {
            lbTienThu.Text = _tongTien;
            CultureInfo culture = new CultureInfo("en-US");
            double TongTien = double.Parse(lbTienThu.Text); // 655.200
            double basocuoi = (TongTien % 1000); // 200
            double bonsocuoi = (TongTien % 10000); // 5.200
            double namsocuoi = (TongTien % 100000); // 55.200
            double x = 0, y = 0, z = 0;
            if (basocuoi > 0)
            {
                x = (TongTien - basocuoi + 1000);
                y = (TongTien - bonsocuoi + 10000);
                z = (TongTien - namsocuoi + 100000);
                btGoiY1.Text = String.Format(culture, "{0:N0}", x); // 5,295,000
                btGoiY2.Text = String.Format(culture, "{0:N0}", x + 1000); // 5,296,000
                btGoiY3.Text = String.Format(culture, "{0:N0}", y); // 5,300,000
                if (bonsocuoi <= 5000) // 5,294,442
                {
                    if (namsocuoi <= 50000)
                    {
                        btGoiY4.Text = String.Format(culture, "{0:N0}", y + 10000);
                        btGoiY5.Text = String.Format(culture, "{0:N0}", y);
                        btGoiY6.Text = String.Format(culture, "{0:N0}", z + 100000);
                    }
                    else
                    {
                        btGoiY4.Text = String.Format(culture, "{0:N0}", z + 100000);
                        btGoiY5.Text = String.Format(culture, "{0:N0}", z + 200000);
                        btGoiY6.Text = String.Format(culture, "{0:N0}", z + 300000);
                    }
                }
                else
                {
                    btGoiY4.Text = String.Format(culture, "{0:N0}", y + 10000);
                    btGoiY5.Text = String.Format(culture, "{0:N0}", z + 100000);
                    btGoiY6.Text = String.Format(culture, "{0:N0}", z + 200000);
                }
            }
            else
            {
                // 655.000
                x = (TongTien - bonsocuoi + 10000);
                y = (TongTien - namsocuoi + 100000);
                btGoiY1.Text = String.Format(culture, "{0:N0}", TongTien);// 655.000
                btGoiY2.Text = String.Format(culture, "{0:N0}", x); // 660.000
                btGoiY3.Text = String.Format(culture, "{0:N0}", x + 10000); // 670.000
                btGoiY4.Text = String.Format(culture, "{0:N0}", y); // 700.000
                btGoiY5.Text = String.Format(culture, "{0:N0}", y + 100000); // 800.000
                btGoiY6.Text = String.Format(culture, "{0:N0}", y + 200000); // 900.000
            }
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
                if (value > 0)
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

        private void BtGoiY1_Click(object sender, EventArgs e)
        {
            txbTienKhachDua.Text = btGoiY1.Text;
        }

        private void BtGoiY2_Click(object sender, EventArgs e)
        {
            txbTienKhachDua.Text = btGoiY2.Text;
        }

        private void BtGoiY3_Click(object sender, EventArgs e)
        {
            txbTienKhachDua.Text = btGoiY3.Text;
        }

        private void BtGoiY4_Click(object sender, EventArgs e)
        {
            txbTienKhachDua.Text = btGoiY4.Text;
        }

        private void BtGoiY5_Click(object sender, EventArgs e)
        {
            txbTienKhachDua.Text = btGoiY5.Text;
        }

        private void BtGoiY6_Click(object sender, EventArgs e)
        {
            txbTienKhachDua.Text = btGoiY6.Text;
        }
    }
}
