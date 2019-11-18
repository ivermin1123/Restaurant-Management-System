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
    public partial class fQLBH : Form
    {

        public fQLBH()
        {
            InitializeComponent();
            USCchaoMung.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }



        private void BtOrderBlue_Click(object sender, EventArgs e)
        {
            USCchaoMung.Visible = false;
            btOrderwhite.Visible = true;
            btDSHoaDonBlue.Visible = true;
            btDSHoaDonWhite.Visible = false;
            btSoDoblue.Visible = true;
            btSoDowhite.Visible = false;
            USCnewOrder.Visible = false;
            USCorder.Visible = true;
            USCsoDo.Visible = false;
            USCdSHoaDon.Visible = false;
        }

        private void BtChoThanhToan_Click(object sender, EventArgs e)
        {
           // btChoThanhToan.IdleFillColor = Color.w;

        }

        private void BtUser_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtOrderPlus_Click(object sender, EventArgs e)
        {
            btDSHoaDonBlue.Visible = true;
            btDSHoaDonWhite.Visible = false;
            btSoDowhite.Visible = false;
            btOrderwhite.Visible = false;
            USCnewOrder.Visible = true;
            USCorder.Visible = false;
            USCchaoMung.Visible = false;
            USCsoDo.Visible = false;
            USCdSHoaDon.Visible = false;
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

        private void BtOrderwhite_Click(object sender, EventArgs e)
        {
            USCnewOrder.Visible = false;
            USCorder.Visible = true;
            USCchaoMung.Visible = false;
            USCsoDo.Visible = false;
            USCdSHoaDon.Visible = false;
        }

        private void BtSoDoblue_Click_1(object sender, EventArgs e)
        {
            btDSHoaDonBlue.Visible = true;
            btDSHoaDonWhite.Visible = false;
            btSoDowhite.Visible = true;
            btOrderwhite.Visible = false;
            btOrderBlue.Visible = true;
            USCnewOrder.Visible = false;
            USCorder.Visible = false;
            USCsoDo.Visible = true;
            USCchaoMung.Visible = false;
            USCdSHoaDon.Visible = false;
        }

        private void BtSoDowhite_Click(object sender, EventArgs e)
        {
            USCsoDo.Visible = true;
            USCnewOrder.Visible = false;
            USCorder.Visible = false;
            USCchaoMung.Visible = false;
            USCdSHoaDon.Visible = false;
        }

        private void USCsoDo_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            USCsoDo.Visible = false;
            USCnewOrder.Visible = false;
            USCorder.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FQLBH_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BtHome_Click(object sender, EventArgs e)
        {
            btDSHoaDonBlue.Visible = true;
            btDSHoaDonWhite.Visible = false;
            USCchaoMung.Visible = true;
            USCchaoMung.BringToFront();
            btSoDoblue.Visible = true;
            btSoDowhite.Visible = false;
            btOrderwhite.Visible = false;
            btOrderBlue.Visible = true;
            USCnewOrder.Visible = false;
            USCorder.Visible = false;
            USCsoDo.Visible = false;
            USCdSHoaDon.Visible = false;
        }

        private void BtMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtDSHoaDonBlue_Click(object sender, EventArgs e)
        {
            btDSHoaDonBlue.Visible = false;
            btDSHoaDonWhite.Visible = true;
            btSoDowhite.Visible = false;
            btOrderwhite.Visible = false;
            USCdSHoaDon.Visible = true;
            USCchaoMung.Visible = false;
            USCorder.Visible = false;
            USCsoDo.Visible = false;
            USCnewOrder.Visible = false;
        }

        private void BtDSHoaDonWhite_Click(object sender, EventArgs e)
        {

        }

        // this.WindowState = FormWindowState.Maximized;
        // this.WindowState = FormWindowState.Normal;
    }
}
