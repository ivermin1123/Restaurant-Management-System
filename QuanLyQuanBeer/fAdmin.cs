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
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
        }

        

        private void BtBaoCao_Click(object sender, EventArgs e)
        {
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
