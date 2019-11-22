using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }



        private void BtBaoCao_Click(object sender, EventArgs e)
        {
            uscBan.Visible = false;
            uscLoaiSanPham.Visible = false;
            uscSanPham.Visible = false;
            uscNhanVien.Visible = false;
            USCTaiKhoan.Visible = false;
            pn1.Visible = true;
            pn2.Visible = false;
            pn3.Visible = false;
            pn4.Visible = false;
            pn5.Visible = false;
            pn6.Visible = false;
            pn7.Visible = false;
        }

        private void BtTaiKhoan_Click(object sender, EventArgs e)
        {
            uscBan.Visible = false;
            uscLoaiSanPham.Visible = false;
            uscSanPham.Visible = false;
            USCTaiKhoan.Visible = true;
            uscNhanVien.Visible = false;
            pn1.Visible = false;
            pn2.Visible = true;
            pn3.Visible = false;
            pn4.Visible = false;
            pn5.Visible = false;
            pn6.Visible = false;
            pn7.Visible = false;
        }

        private void BtSanPham_Click(object sender, EventArgs e)
        {
            uscBan.Visible = false;
            uscLoaiSanPham.Visible = false;
            uscSanPham.Visible = true;
            uscNhanVien.Visible = false;
            USCTaiKhoan.Visible = false;
            pn1.Visible = false;
            pn2.Visible = false;
            pn3.Visible = true;
            pn4.Visible = false;
            pn5.Visible = false;
            pn6.Visible = false;
            pn7.Visible = false;
        }

        private void BtDanhMuc_Click(object sender, EventArgs e)
        {
            uscBan.Visible = false;
            uscLoaiSanPham.Visible = true;
            uscSanPham.Visible = false;
            uscNhanVien.Visible = false;
            USCTaiKhoan.Visible = false;
            pn1.Visible = false;
            pn2.Visible = false;
            pn3.Visible = false;
            pn4.Visible = true;
            pn5.Visible = false;
            pn6.Visible = false;
            pn7.Visible = false;
        }

        private void BtNhanVien_Click(object sender, EventArgs e)
        {
            uscBan.Visible = false;
            uscLoaiSanPham.Visible = false;
            uscSanPham.Visible = false;
            uscNhanVien.Visible = true;
            USCTaiKhoan.Visible = false;
            pn1.Visible = false;
            pn2.Visible = false;
            pn3.Visible = false;
            pn4.Visible = false;
            pn5.Visible = true;
            pn6.Visible = false;
            pn7.Visible = false;
        }

        private void BtThietLapHeThong_Click(object sender, EventArgs e)
        {
            uscBan.Visible = true;
            uscLoaiSanPham.Visible = false;
            uscSanPham.Visible = false;
            uscNhanVien.Visible = false;
            USCTaiKhoan.Visible = false;
            pn1.Visible = false;
            pn2.Visible = false;
            pn3.Visible = false;
            pn4.Visible = false;
            pn5.Visible = false;
            pn6.Visible = true;
            pn7.Visible = false;
        }

        private void BtHelp_Click(object sender, EventArgs e)
        {
            uscBan.Visible = false;
            uscLoaiSanPham.Visible = false;
            uscSanPham.Visible = false;
            uscNhanVien.Visible = false;
            USCTaiKhoan.Visible = false;
            pn1.Visible = false;
            pn2.Visible = false;
            pn3.Visible = false;
            pn4.Visible = false;
            pn5.Visible = false;
            pn6.Visible = false;
            pn7.Visible = true;
        }

        private void BtResize_Click(object sender, EventArgs e)
        {
            if (pnMenu.Width == 65)
            {
                pnMenu.Width = 270;
            }
            else
                pnMenu.Width = 65;
        }

        private void BtRestore_Click(object sender, EventArgs e)
        {
            btRestore.Visible = false;
            btMaximize.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void BtMaximize_Click(object sender, EventArgs e)
        {
            btMaximize.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            btRestore.Visible = true;
        }

        private void BtMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
    }
}
