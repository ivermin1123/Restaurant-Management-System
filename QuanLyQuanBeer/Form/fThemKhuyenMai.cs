using QuanLyQuanBeer.DAO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fThemKhuyenMai : Form
    {
        public fThemKhuyenMai()
        {
            InitializeComponent();
            LoadCBX();
        }

        private void LoadCBX()
        {
            //listSP.DataSource = SanPhamDAO.Instance.GetListSP();
            List<LoaiKhuyenMaiDTO> danhSachLoaiSP = LoaiKhuyenMaiDAO.Instance.GetListLoaiSP();
            cbxLoaiKM.DataSource = danhSachLoaiSP;
            cbxLoaiKM.DisplayMember = "TenLoaiKM";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txbNDKM.Text == string.Empty)
                MessageBox.Show("Bạn chưa nhập nội dung khuyến mại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txbGiamGiaPT.Text == string.Empty && txbGiamGiaTM.Text == string.Empty)
                MessageBox.Show("Bạn phải nhập giảm giá theo % hoặc tiền mặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string tenKM = txbNDKM.Text;
                if (txbGiamGiaPT.Text == string.Empty)
                    txbGiamGiaPT.Text = 0.ToString();
                int giamGia = int.Parse(txbGiamGiaPT.Text);
                if (txbGiamGiaTM.Text == string.Empty)
                    txbGiamGiaTM.Text = 0.ToString();
                double giamTien = double.Parse(txbGiamGiaTM.Text);
                if (txbToiDa.Text == string.Empty)
                    txbToiDa.Text = 0.ToString();
                double toiDa = double.Parse(txbToiDa.Text);
                if (txbDieuKien.Text == string.Empty)
                    txbDieuKien.Text = 0.ToString();
                double dieuKien = double.Parse(txbDieuKien.Text);
                int idLoaiKM = LoaiKhuyenMaiDAO.Instance.GetIDByTenLoaiKM(cbxLoaiKM.Text);
                if (KhuyenMaiDAO.Instance.ThemKhuyenMai(tenKM, giamGia, giamTien, toiDa, dieuKien, idLoaiKM))
                {
                    MessageBox.Show("Thêm thành công!", "Thêm khuyến mại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Thêm không thành công!", "Thêm khuyến mại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void txbGiamGiaTM_TextChanged(object sender, EventArgs e)
        {
            txbGiamGiaTM.Focus();
            txbGiamGiaTM.SelectionStart = txbGiamGiaTM.Text.Length;
            if (txbGiamGiaTM.Text == string.Empty)
                txbGiamGiaTM.Text = 0.ToString();
            CultureInfo culture = new CultureInfo("en-US");
            decimal value1 = decimal.Parse(txbGiamGiaTM.Text, NumberStyles.Currency);
            txbGiamGiaTM.Text = String.Format(culture, "{0:N0}", value1);
        }

        private void txbToiDa_TextChanged(object sender, EventArgs e)
        {
            txbToiDa.Focus();
            txbToiDa.SelectionStart = txbToiDa.Text.Length;
            if (txbToiDa.Text == string.Empty)
                txbToiDa.Text = 0.ToString();
            CultureInfo culture = new CultureInfo("en-US");
            decimal value1 = decimal.Parse(txbToiDa.Text, NumberStyles.Currency);
            txbToiDa.Text = String.Format(culture, "{0:N0}", value1);
        }

        private void txbDieuKien_TextChanged(object sender, EventArgs e)
        {
            txbDieuKien.Focus();
            txbDieuKien.SelectionStart = txbDieuKien.Text.Length;
            if (txbDieuKien.Text == string.Empty)
                txbDieuKien.Text = 0.ToString();
            CultureInfo culture = new CultureInfo("en-US");
            decimal value1 = decimal.Parse(txbDieuKien.Text, NumberStyles.Currency);
            txbDieuKien.Text = String.Format(culture, "{0:N0}", value1);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}