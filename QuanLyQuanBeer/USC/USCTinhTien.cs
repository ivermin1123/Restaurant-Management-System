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
    public partial class TinhTien : UserControl
    {
        public TinhTien()
        {
            InitializeComponent();
        }

        private void BtThuTien_Click(object sender, EventArgs e)
        {
            fThuTien f = new fThuTien();
            f.ShowDialog();
        }
    }
}
