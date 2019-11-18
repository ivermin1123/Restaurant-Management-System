using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanBeer.DAO;

namespace QuanLyQuanBeer.USC
{
    public partial class USCNhanVien : UserControl
    {
        BindingSource listNhanVien = new BindingSource();
        public USCNhanVien()
        {
            InitializeComponent();
            LoadAccount();
            binding();
        }

        void LoadAccount()
        {
            dtgvNhanVien.DataSource = listNhanVien;
            listNhanVien.DataSource = ThongTinTaiKhoanDAO.Instance.GetListNhanVien();

        }

        void binding()
        {
            txbIDNhanVien.DataBindings.Add("Text", dtgvNhanVien.DataSource, "id", true, DataSourceUpdateMode.Never);
            txbTenDN.DataBindings.Add("Text", dtgvNhanVien.DataSource, "TenDangNhap", true, DataSourceUpdateMode.Never);
            txbHoTen.DataBindings.Add("Text", dtgvNhanVien.DataSource, "HoTen", true, DataSourceUpdateMode.Never);
            txbDiaChi.DataBindings.Add("Text", dtgvNhanVien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never);
            txbCMND.DataBindings.Add("Text", dtgvNhanVien.DataSource, "CMND", true, DataSourceUpdateMode.Never);
            txbTuoi.DataBindings.Add("Text", dtgvNhanVien.DataSource, "Tuoi", true, DataSourceUpdateMode.Never);
            txbSDT.DataBindings.Add("Text", dtgvNhanVien.DataSource, "SoDienThoai", true, DataSourceUpdateMode.Never);
        }

        private void BtSuaNV_Click(object sender, EventArgs e)
        {
            string tenDN = txbTenDN.Text;
            string hoTen = txbHoTen.Text;
            string diaChi = txbDiaChi.Text;
            string cMND = txbCMND.Text;
            string tuoi = txbTuoi.Text;
            string sDT = txbSDT.Text;
            string gioiTinh;
            if (rdbtNam.Checked)
            {
                gioiTinh = "Nam";
            }
            else
                gioiTinh = "Nữ";
            if (hoTen == "" || diaChi == "" || cMND == "" || tuoi == "" || sDT == "")
                MessageBox.Show("Bạn phải nhập đủ thông tin!", "Cập nhật thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                int CMND = int.Parse(txbCMND.Text);
                int _sDT = int.Parse(txbSDT.Text);
                int _tuoi = int.Parse(txbTuoi.Text);
                if (ThongTinTaiKhoanDAO.Instance.capNhat(hoTen, _sDT, diaChi, CMND, _tuoi, gioiTinh, tenDN))
                {
                    MessageBox.Show("Cập nhật thành công!", "Cập nhật tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAccount();
                }
                else
                    MessageBox.Show("Cập nhật không thành công!", "Cập nhật tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
