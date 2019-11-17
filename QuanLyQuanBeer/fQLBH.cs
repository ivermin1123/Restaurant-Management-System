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




        public void setButton1Visible(bool flag)
        {
            this.USCmenu.Visible = flag;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }



        private void BtOrderBlue_Click(object sender, EventArgs e)
        {
            btQuayLai.Visible = false;
            USCchaoMung.Visible = false;
            btOrderwhite.Visible = true;
            btSoDoblue.Visible = true;
            btSoDowhite.Visible = false;
            USCnewOrder.Visible = false;
            USCorder.Visible = true;
            USCsoDo.Visible = false;
            USCmenu.Visible = false;
            btTinhTien.Visible = false;
            USCtinhTien.Visible = false;
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
            USCtinhTien.Visible = false;
            btQuayLai.Visible = false;
            btTinhTien.Visible = true;
            USCnewOrder.Visible = true;
            USCorder.Visible = false;
            USCchaoMung.Visible = false;
            USCsoDo.Visible = false;
            USCmenu.Visible = false;
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
            btQuayLai.Visible = false;
            btTinhTien.Visible = false;
            USCnewOrder.Visible = false;
            USCorder.Visible = true;
            USCchaoMung.Visible = false;
            USCsoDo.Visible = false;
            USCtinhTien.Visible = false;
            USCmenu.Visible = false;
        }

        private void BtSoDoblue_Click_1(object sender, EventArgs e)
        {
            btQuayLai.Visible = false;
            btTinhTien.Visible = false;
            btSoDowhite.Visible = true;
            btOrderwhite.Visible = false;
            btOrderBlue.Visible = true;
            USCnewOrder.Visible = false;
            USCorder.Visible = false;
            USCsoDo.Visible = true;
            USCmenu.Visible = false;
            USCtinhTien.Visible = false;
            USCchaoMung.Visible = false;
        }

        private void BtSoDowhite_Click(object sender, EventArgs e)
        {
            USCtinhTien.Visible = false;
            btQuayLai.Visible = false;
            btTinhTien.Visible = false;
            USCsoDo.Visible = true;
            USCnewOrder.Visible = false;
            USCorder.Visible = false;
            USCchaoMung.Visible = false;
            USCmenu.Visible = false;
        }

        private void BtOption_Click(object sender, EventArgs e)
        {
            USCmenu.BringToFront();
            if (USCmenu.Visible != true)
                USCmenu.Visible = true;
            else
                USCmenu.Visible = false;  
        }

        private void USCsoDo_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_MouseClick(object sender, MouseEventArgs e)
        {
            btQuayLai.Visible = false;
            btTinhTien.Visible = false;
            USCsoDo.Visible = false;
            USCnewOrder.Visible = false;
            USCorder.Visible = false;
            USCmenu.Visible = false;
        }

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            USCmenu.Visible = false;
        }

        private void BtTinhTien_Click(object sender, EventArgs e)
        {
            USCtinhTien.Visible = true;
            USCtinhTien.BringToFront();
            btQuayLai.Visible = true;
            btQuayLai.BringToFront();
        }

        private void BtQuayLai_Click(object sender, EventArgs e)
        {
            btQuayLai.Visible = false;
            btTinhTien.Visible = true;
            USCnewOrder.Visible = true;
            USCorder.Visible = false;
            USCsoDo.Visible = false;
            USCmenu.Visible = false;
            USCtinhTien.Visible = false;
            USCchaoMung.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
            timer1.Start();
        }

        private void FQLBH_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy"); ;
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void BtHome_Click(object sender, EventArgs e)
        {
            USCchaoMung.Visible = true;
            USCchaoMung.BringToFront();
            btQuayLai.Visible = false;
            btTinhTien.Visible = false;
            btSoDoblue.Visible = true;
            btSoDowhite.Visible = false;
            btOrderwhite.Visible = false;
            btOrderBlue.Visible = true;
            USCnewOrder.Visible = false;
            USCorder.Visible = false;
            USCsoDo.Visible = false;
            USCmenu.Visible = false;
            USCtinhTien.Visible = false;
        }

        // this.WindowState = FormWindowState.Maximized;
        // this.WindowState = FormWindowState.Normal;
    }
}
