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
    public partial class fSuaKM : Form
    {
        public fSuaKM()
        {
            InitializeComponent();
            LoadCBX();
        }

        void LoadCBX()
        {
            List<LoaiKhuyenMaiDTO> dsLKM = LoaiKhuyenMaiDAO.Instance.GetListLoaiSP();
            cbxLoaiKM.DataSource = dsLKM;
            cbxLoaiKM.DisplayMember = "TenLoaiKM";
            List<KhuyenMaiDTO> dsKM = KhuyenMaiDAO.Instance.LoadDsKMAll();
            cbxTenKM.DisplayMember = "TenKM";
            cbxTenKM.DataSource = dsKM;
            //cbxTenKM.SelectedIndex = 1;
        }

        private void btThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxTenKM_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenKM = cbxTenKM.Text;
            string tenLKM = cbxLoaiKM.Text;
            KhuyenMaiDTO km = KhuyenMaiDAO.Instance.GetDTOKM(tenKM);
            txbDieuKien.Text = km.DieuKien.ToString();
            txbGiamGiaPT.Text = km.GiamGia.ToString();
            txbGiamGiaTM.Text = km.GiamTien.ToString();
            txbToiDa.Text = km.ToiDa.ToString();
            txbNDKM.Text = km.TenKM;
            cbxLoaiKM.Text = LoaiKhuyenMaiDAO.Instance.GetTenLoaiKMByID(km.IdLoaiKM);

        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txbNDKM.Text == string.Empty)
                MessageBox.Show("Bạn chưa nhập nội dung khuyến mại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txbGiamGiaPT.Text == string.Empty && txbGiamGiaTM.Text == string.Empty)
                MessageBox.Show("Bạn phải nhập giảm giá theo % hoặc tiền mặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                string tenKMSua = txbNDKM.Text;
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
                string tenKMDau = cbxTenKM.Text;
                int idLoaiKM = LoaiKhuyenMaiDAO.Instance.GetIDByTenLoaiKM(cbxLoaiKM.Text);
                int idKM = KhuyenMaiDAO.Instance.GetIDByTenKM(tenKMDau);
                if (KhuyenMaiDAO.Instance.SuaKhuyenMai(tenKMSua, giamGia, giamTien, toiDa, dieuKien, idLoaiKM,idKM))
                {
                    MessageBox.Show("Sửa thành công!", "Sửa khuyến mại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Sửa không thành công!", "Sửa khuyến mại", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
