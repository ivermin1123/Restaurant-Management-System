using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class NewOrder : UserControl
    {
        public NewOrder()
        {
            InitializeComponent();
        }

        public void BtTinhTien_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            btQuayLai.Visible = true;
            USCtinhTien.Visible = true;
            USCtinhTien.BringToFront();
            btQuayLai.BringToFront();
        }

        private void BtQuayLai_Click_1(object sender, EventArgs e)
        {
            USCtinhTien.Visible = false;
            btQuayLai.Visible = false;
            panel1.Visible = true;
            panel2.Visible = true;
        }
    }
}
