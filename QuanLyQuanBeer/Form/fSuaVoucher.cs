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
    public partial class fSuaVoucher : Form
    {
        private string _maVC;
        public fSuaVoucher(string maVC)
        {
            InitializeComponent();
            _maVC = maVC;
            LoadVC();
        }

        void LoadVC()
        {
            VoucherDTO vc = VoucherDAO.Instance.GETDTOVoucher(_maVC);
            txbVoucher.Text = _maVC;
            txbGiamGiaPT.Text = vc.GiamGia.ToString();
            txbGiamGiaTM.Text = vc.GiamTien.ToString();
            txbNoiDung.Text = vc.TenVoucher;
            dtpkHSD.Value = vc.HanSuDung;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btTao_Click(object sender, EventArgs e)
        {
            string tenVC = txbNoiDung.Text;
            int giamGia = int.Parse(txbGiamGiaPT.Text);
            double giamTien = double.Parse(txbGiamGiaTM.Text);
            DateTime hSD = dtpkHSD.Value;
            if (VoucherDAO.Instance.SuaVoucher(_maVC,tenVC,giamGia,giamTien,hSD))
            {
                MessageBox.Show("Cập nhật thành công","Cập nhật Voucher",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Cập nhật không thành công", "Cập nhật Voucher", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
