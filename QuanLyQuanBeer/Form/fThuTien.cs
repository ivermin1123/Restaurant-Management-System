using QuanLyQuanBeer.DAO;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fThuTien : Form
    {
        private string _tongTien;
        private int _idBan;
        private string _nhanVien;
        private string _ThanhTien;
        private int _idHoaDon;
        private DateTime? _GioVao;
        private string _VAT;
        private string _TenBan;
        private string _ThanhToan;
        public fThuTien(string tongTien, int idBan, string NhanVien, string ThanhTien, int idHoaDon, DateTime? GioVao, string VAT, string TenBan, string ThanhToan)
        {
            InitializeComponent();
            _tongTien = tongTien;
            _idBan = idBan;
            _nhanVien = NhanVien;
            _ThanhTien = ThanhTien;
            _idHoaDon = idHoaDon;
            _GioVao = GioVao;
            _VAT = VAT;
            _TenBan = TenBan;
            _ThanhToan = ThanhToan;
            GoiYTien();
        }

        void GoiYTien()
        {
            txbTienThu.Text = _tongTien;
            CultureInfo culture = new CultureInfo("en-US");
            double TongTien = double.Parse(txbTienThu.Text); // 655.200
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
            if (txbTienKhachDua.Text == string.Empty)
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 500000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt200_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == string.Empty)
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 200000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt100_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == string.Empty)
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 100000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt50_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == string.Empty)
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 50000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt20_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == string.Empty)
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 20000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt10_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == string.Empty)
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 10000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt5_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == string.Empty)
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 5000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt2_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == string.Empty)
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 2000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        private void Bt1_Click(object sender, EventArgs e)
        {
            if (txbTienKhachDua.Text == string.Empty)
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhach = decimal.Parse(txbTienKhachDua.Text);
            decimal tienKhachCong = (tienKhach + 1000);
            txbTienKhachDua.Text = tienKhachCong.ToString();
            HienthiTienVN();
        }

        void LoadTien()
        {
            //decimal TienThuDoi = decimal.Parse(txbTienTraLai.Text); // 344.800
            //decimal TienThuCheck = (TienThuDoi % 10000); // 4800
            // Làm tròn >= 5k -> 10k || <5k -> 5k
            /*decimal Change;
            if (TienThuCheck == 5000 || TienThuCheck > 5000)
                Change = 10000;
            else
                Change = 5000;
            decimal HienThi = TienThuDoi - TienThuCheck + Change;*/
            decimal tienKhachDua = decimal.Parse(txbTienKhachDua.Text);
            decimal tienThu = decimal.Parse(txbTienThu.Text);
            string tienThua = (tienKhachDua - tienThu).ToString();
            txbTienThua.Text = tienThua;
            // Đổi định dạng hiển thị
            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(txbTienThua.Text, NumberStyles.Currency);
            txbTienThua.Text = String.Format(culture, "{0:N0}", value);
            txbTienMat.Text = txbTienKhachDua.Text;
        }

        private void TxbTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            txbTienKhachDua.Focus();
            txbTienKhachDua.SelectionStart = txbTienKhachDua.Text.Length;
            if (txbTienKhachDua.Text == string.Empty)
                txbTienKhachDua.Text = 0.ToString();
            decimal tienKhachDua = decimal.Parse(txbTienKhachDua.Text);
            if (txbTienThu.Text == string.Empty)
                txbTienThu.Text = 0.ToString();
            decimal tienThu = decimal.Parse(txbTienThu.Text);
            string tienTraLai = (tienKhachDua - tienThu).ToString();
            txbTienTraLai.Text = tienTraLai;

            CultureInfo culture = new CultureInfo("en-US");
            decimal value = decimal.Parse(txbTienTraLai.Text, NumberStyles.Currency);
            txbTienTraLai.Text = String.Format(culture, "{0:N0}", value);

            decimal value1 = decimal.Parse(txbTienKhachDua.Text, NumberStyles.Currency);
            txbTienKhachDua.Text = String.Format(culture, "{0:N0}", value1);
            LoadTien();
        }

        private void BunifuFlatButton4_Click(object sender, EventArgs e)
        {
            if (txbTienTraLai.Text != string.Empty)
            {
                btDong.Enabled = true;
                btInVaDong.Enabled = true;
                pnTinhTien.Visible = true;
                LoadTien();
                decimal tienKhachDua = decimal.Parse(txbTienKhachDua.Text);
                decimal tienThu = decimal.Parse(txbTienThu.Text);
                decimal tienThua = tienKhachDua - tienThu;
                if (tienThua > 0)
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

        private void BtDong_Click(object sender, EventArgs e)
        {
            int idBill = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(_idBan);
            decimal TienThua = 0;
            if (ckbxKLayTienTHua.Checked == true)
            {
                TienThua = decimal.Parse(txbTienThua.Text);
            }
            else
                TienThua = 0;
            if (idBill != -1)
            {
                double tongtien = Convert.ToDouble(_ThanhToan);
                if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho Bàn {0}" +
                    "\nTổng tiền = {1:0,0} VND", _idBan, tongtien), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    HoaDonDAO.Instance.CheckOut(idBill, tongtien, TienThua, _nhanVien);
                    BanDAO.Instance.UpdateStatusTable(_idBan);
                    this.Close();
                }
            }
        }

        private void CkbxKLayTienTHua_OnChange(object sender, EventArgs e)
        {
            decimal tienThu = decimal.Parse(txbTienThu.Text);
            if (ckbxKLayTienTHua.Checked != true)
            {
                decimal tienKhachDua = decimal.Parse(txbTienKhachDua.Text);
                decimal tienTraLai = tienKhachDua - tienThu;
                CultureInfo culture = new CultureInfo("en-US");
                txbTienTraLai.Text = String.Format(culture, "{0:N0}", tienTraLai);
            }
            else
                txbTienTraLai.Text = 0.ToString();
        }

        private void BtHuy_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtInVaDong_Click(object sender, EventArgs e)
        {
            try
            {
                string TienKhachDua = txbTienKhachDua.Text;
                string TienTraLai = txbTienTraLai.Text;
                string TienThua1;
                if (ckbxKLayTienTHua.Checked == true)
                {
                    TienThua1 = txbTienThua.Text;
                }
                else
                    TienThua1 = 0.ToString();
                DateTime? GioRa = DateTime.Now;
                rptHoaDon rptHoaDon = new rptHoaDon(_idBan);
                rptHoaDon.XuatHoaDon(_idHoaDon, _TenBan, _nhanVien, _ThanhTien, _GioVao, _VAT, _ThanhToan, TienKhachDua, TienTraLai, GioRa);
                int idBill = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(_idBan);

                if (idBill != -1)
                {
                    double tongtien = Convert.ToDouble(txbTienThu.Text);
                    if (MessageBox.Show(string.Format("Bạn có chắc thanh toán hóa đơn cho Bàn {0}" +
                        "\nTổng tiền = {1:0,0} VND", _idBan, tongtien), "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        HoaDonDAO.Instance.CheckOut(idBill, tongtien, decimal.Parse(TienThua1), _nhanVien);
                        BanDAO.Instance.UpdateStatusTable(_idBan);
                        this.Close();
                        rptHoaDon.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
