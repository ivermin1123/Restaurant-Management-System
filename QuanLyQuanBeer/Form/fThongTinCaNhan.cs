using QuanLyQuanBeer.DAO;
using QuanLyQuanBeer.DTO;
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
    public partial class fThongTinCaNhan : Form
    {
        private string _tenDN;
        public fThongTinCaNhan(string tenDN)
        {
            InitializeComponent();
            _tenDN = tenDN;
            LoadTT(_tenDN);
        }

        void LoadTT(string tenDN)
        {
            ThongTinTaiKhoanDTO tt = ThongTinTaiKhoanDAO.Instance.GETDTOTTTK(tenDN);
            txbCMND.Text = tt.CMND.ToString();
            txbDiaChi.Text = tt.DiaChi;
            txbGioiTinh.Text = tt.GioiTinh;
            txbHoTen.Text = tt.HoTen;
            txbTuoi.Text = tt.Tuoi.ToString();
        }

        private void btDoiMK_Click(object sender, EventArgs e)
        {
            fDoiMK f = new fDoiMK(_tenDN);
            f.ShowDialog();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
