using QuanLyQuanBeer.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fDieuHuong : Form
    {
        private TaiKhoanDTO taiKhoanHienTai;
        public TaiKhoanDTO TaiKhoanHienTai
        {
            get { return taiKhoanHienTai; }
            set { taiKhoanHienTai = value; }
        }
        public fDieuHuong(TaiKhoanDTO acc)
        {
            this.TaiKhoanHienTai = acc;
            InitializeComponent();
            if (acc.LoaiTaiKhoan == "Thủ kho")
            {
                btQLBH.Enabled = false;
            }
            this.lbTenDN.Text = acc.TenDangNhap;
        }

        private void FDieuHuong_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void btQLBH_Click_1(object sender, EventArgs e)
        {
            fQLBH1 f = new fQLBH1(this.TaiKhoanHienTai);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btQLHT_Click_1(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin(TaiKhoanHienTai);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

    }
}
