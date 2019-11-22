using QuanLyQuanBeer.DTO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fDieuHuong : Form
    {
        private TaiKhoan taiKhoanHienTai;
        public TaiKhoan TaiKhoanHienTai
        {
            get { return taiKhoanHienTai; }
            set { taiKhoanHienTai = value; }
        }
        public fDieuHuong(TaiKhoan acc)
        {
            this.TaiKhoanHienTai = acc;
            InitializeComponent();
            this.lbTenDN.Text = acc.TenDangNhap;
        }

        private void BtQLBH_Click(object sender, EventArgs e)
        {
            fQLBH1 f = new fQLBH1(this.TaiKhoanHienTai);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void BtQLHT_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FDieuHuong_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
