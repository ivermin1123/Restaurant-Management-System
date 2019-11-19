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
    public partial class fDieuHuong : Form
    {
        public fDieuHuong()
        {
            InitializeComponent();
        }

        private void BtQLBH_Click(object sender, EventArgs e)
        {
            fQLBH1 f = new fQLBH1();
            f.ShowDialog();
        }

        private void BtQLHT_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();
        }
    }
}
