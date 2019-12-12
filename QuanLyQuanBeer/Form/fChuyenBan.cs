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
    public partial class fChuyenBan : Form
    {
        private TaiKhoanDTO _taiKhoanHienTai;
        private BanDTO _ban;
        public fChuyenBan(TaiKhoanDTO taiKhoanHienTai,BanDTO ban)
        {
            InitializeComponent();
            _taiKhoanHienTai = taiKhoanHienTai;
            _ban = ban;
            LoadCBXT();
           
        }

        void LoadCBXT()
        {
            List<BanDTO> dsBanPhai = BanDAO.Instance.LoadDsBan();
            dsBanPhai.RemoveAt(dsBanPhai.FindIndex(a => a.TenBan == _ban.TenBan));
            cbxBanPhai.DisplayMember = "TenBan";
            cbxBanPhai.DataSource = dsBanPhai;
            int idBanPhai = BanDAO.Instance.GetIdBanByTen(cbxBanPhai.Text);
            int idHoaDonPhai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(idBanPhai);
            int idHoaDonTrai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(_ban.ID);
            txbMaHDTrai.Text = "HD00" + idHoaDonTrai;
            if (idHoaDonPhai == -1)
                txbMaHDPhai.Text = string.Empty;
            else 
                txbMaHDPhai.Text = "HD00" + idHoaDonPhai;
            txbBanTrai.Text = _ban.TenBan;
            XemHoaDon1(_ban.ID);
            XemHoaDon(idBanPhai);
        }
        void XemHoaDon1(int id)
        {
            lsvTableFrom.Items.Clear();
            List<MenuDTO> danhSachThongTinHoaDon = MenuDAO.Instance.GetListMenuByTable1(id);
            double TongTien = 0;
            foreach (MenuDTO item in danhSachThongTinHoaDon)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenSanPham.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.DonVi.ToString());
                if (item.ThanhTien == 0)
                    lsvItem.SubItems.Add("Miễn phí");
                else
                    lsvItem.SubItems.Add(String.Format("{0:0,0}", item.ThanhTien) + " VND");
                TongTien += item.ThanhTien;
                lsvTableFrom.Items.Add(lsvItem);
            }
        }

        void XemHoaDon(int id)
        {
            lsvTableTo.Items.Clear();
            List<MenuDTO> danhSachThongTinHoaDon = MenuDAO.Instance.GetListMenuByTable1(id);
            double TongTien = 0;
            foreach (MenuDTO item in danhSachThongTinHoaDon)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenSanPham.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.DonVi.ToString());
                if (item.ThanhTien == 0)
                    lsvItem.SubItems.Add("Miễn phí");
                else
                    lsvItem.SubItems.Add(String.Format("{0:0,0}", item.ThanhTien) + " VND");
                TongTien += item.ThanhTien;
                lsvTableTo.Items.Add(lsvItem);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxBanPhai_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idBanPhai = BanDAO.Instance.GetIdBanByTen(cbxBanPhai.Text);
            int idHoaDonPhai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(idBanPhai);
            if (idHoaDonPhai == -1)
                txbMaHDPhai.Text = string.Empty;
            else
                txbMaHDPhai.Text = "HD00" + idHoaDonPhai;
            XemHoaDon(idBanPhai);
        }

        private void btSangPhai1_Click(object sender, EventArgs e)
        {
            int idBanPhai = BanDAO.Instance.GetIdBanByTen(cbxBanPhai.Text);
            int idHoaDonTrai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(_ban.ID);
            int idHoaDonPhai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(idBanPhai);
            try
            {
                if (idHoaDonPhai == -1)
                {
                    if (MessageBox.Show(cbxBanPhai.Text + " chưa có hóa đơn !! Bạn có muốn tạo hóa đơn không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (lsvTableFrom.SelectedItems.Count > 0)
                        {
                            while (lsvTableFrom.SelectedItems.Count > 0)
                            {
                                ListViewItem temp = lsvTableFrom.SelectedItems[0];
                                lsvTableFrom.Items.Remove(temp);
                                lsvTableTo.Items.Add(temp);
                                string tenMon = temp.Text;
                                int idSanPham = SanPhamDAO.Instance.GetIDByTenSP(tenMon);
                                ThongTinHoaDonDTO thongtin = ThongTinHoaDonDAO.Instance.GETDTO(idSanPham, idHoaDonTrai);
                                int x = thongtin.SoLuong;
                                ThongTinHoaDonDAO.Instance.ChuyenNMon(idHoaDonTrai, idSanPham, idBanPhai, _ban.ID);
                                BanDAO.Instance.UpdateTrangThaiBan(idBanPhai);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn món muốn chuyển !!", "Thông báo");
                        }
                    }
                }
                else
                {
                    if (lsvTableFrom.SelectedItems.Count > 0)
                    {
                        while (lsvTableFrom.SelectedItems.Count > 0)
                        {
                            ListViewItem temp = lsvTableFrom.SelectedItems[0];
                            lsvTableFrom.Items.Remove(temp);
                            lsvTableTo.Items.Add(temp);
                            string tenMon = temp.Text;
                            int idSanPham = SanPhamDAO.Instance.GetIDByTenSP(tenMon);
                            ThongTinHoaDonDTO thongtin = ThongTinHoaDonDAO.Instance.GETDTO(idSanPham, idHoaDonTrai);
                            int x = thongtin.SoLuong;
                            ThongTinHoaDonDAO.Instance.ChuyenNMon(idHoaDonTrai, idSanPham, idBanPhai, _ban.ID);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn món muốn chuyển !!", "Thông báo");
                    }
                }
                int SL = lsvTableFrom.Items.Count;
                if (SL <= 0)
                {
                    HoaDonDAO.Instance.DeleteBillTrong(idHoaDonTrai);
                    BanDAO.Instance.UpdateStatusTable(_ban.ID);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btSangPhaiAll_Click(object sender, EventArgs e)
        {
            int idBanPhai = BanDAO.Instance.GetIdBanByTen(cbxBanPhai.Text);
            int idHoaDonTrai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(_ban.ID);
            int idHoaDonPhai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(idBanPhai);
            try
            {
                if (idHoaDonPhai == -1)
                {
                    if (MessageBox.Show(cbxBanPhai.Text + " chưa có hóa đơn !! Bạn có muốn tạo hóa đơn không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        while (lsvTableFrom.Items.Count > 0)
                        {
                            ListViewItem temp = lsvTableFrom.Items[0];
                            lsvTableFrom.Items.Remove(temp);
                            lsvTableTo.Items.Add(temp);
                            string tenMon = temp.Text;
                            int idSanPham = SanPhamDAO.Instance.GetIDByTenSP(tenMon);
                            ThongTinHoaDonDTO thongtin = ThongTinHoaDonDAO.Instance.GETDTO(idSanPham, idHoaDonTrai);
                            int x = thongtin.SoLuong;
                            ThongTinHoaDonDAO.Instance.ChuyenNMon(idHoaDonTrai, idSanPham, idBanPhai, _ban.ID);
                            BanDAO.Instance.UpdateTrangThaiBan(idBanPhai);
                        }
                        HoaDonDAO.Instance.DeleteBillTrong(idHoaDonTrai);
                        BanDAO.Instance.UpdateStatusTable(_ban.ID);
                    }
                }
                else
                {
                    while (lsvTableFrom.Items.Count > 0)
                    {
                        ListViewItem temp = lsvTableFrom.Items[0];
                        lsvTableFrom.Items.Remove(temp);
                        lsvTableTo.Items.Add(temp);
                        string tenMon = temp.Text;
                        int idSanPham = SanPhamDAO.Instance.GetIDByTenSP(tenMon);
                        ThongTinHoaDonDTO thongtin = ThongTinHoaDonDAO.Instance.GETDTO(idSanPham, idHoaDonTrai);
                        int x = thongtin.SoLuong;
                        ThongTinHoaDonDAO.Instance.ChuyenNMon(idHoaDonTrai, idSanPham, idBanPhai, _ban.ID);
                    }
                    HoaDonDAO.Instance.DeleteBillTrong(idHoaDonTrai);
                    BanDAO.Instance.UpdateStatusTable(_ban.ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btSangTrai1_Click(object sender, EventArgs e)
        {
            int idBanPhai = BanDAO.Instance.GetIdBanByTen(cbxBanPhai.Text);
            int idHoaDonTrai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(_ban.ID);
            int idHoaDonPhai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(idBanPhai);
            try
            {
                if (idHoaDonTrai == -1)
                {
                    if (MessageBox.Show(txbBanTrai.Text + " chưa có hóa đơn !! Bạn có muốn tạo hóa đơn không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        if (lsvTableTo.SelectedItems.Count > 0)
                        {
                            while (lsvTableTo.SelectedItems.Count > 0)
                            {
                                ListViewItem temp = lsvTableTo.SelectedItems[0];
                                lsvTableTo.Items.Remove(temp);
                                lsvTableFrom.Items.Add(temp);
                                string tenMon = temp.Text;
                                int idSanPham = SanPhamDAO.Instance.GetIDByTenSP(tenMon);
                                ThongTinHoaDonDTO thongtin = ThongTinHoaDonDAO.Instance.GETDTO(idSanPham, idHoaDonPhai);
                                int x = thongtin.SoLuong;
                                ThongTinHoaDonDAO.Instance.ChuyenNMon(idHoaDonPhai, idSanPham, _ban.ID,idBanPhai);
                                BanDAO.Instance.UpdateTrangThaiBan(_ban.ID);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa chọn món muốn chuyển !!", "Thông báo");
                        }
                    }
                }
                else
                {
                    if (lsvTableTo.SelectedItems.Count > 0)
                    {
                        while (lsvTableTo.SelectedItems.Count > 0)
                        {
                            ListViewItem temp = lsvTableTo.SelectedItems[0];
                            lsvTableTo.Items.Remove(temp);
                            lsvTableFrom.Items.Add(temp);
                            string tenMon = temp.Text;
                            int idSanPham = SanPhamDAO.Instance.GetIDByTenSP(tenMon);
                            ThongTinHoaDonDTO thongtin = ThongTinHoaDonDAO.Instance.GETDTO(idSanPham, idHoaDonPhai);
                            int x = thongtin.SoLuong;
                            ThongTinHoaDonDAO.Instance.ChuyenNMon(idHoaDonPhai, idSanPham, _ban.ID,idBanPhai);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn món muốn chuyển !!", "Thông báo");
                    }
                }
                int SL = lsvTableTo.Items.Count;
                if (SL <= 0)
                {
                    HoaDonDAO.Instance.DeleteBillTrong(idHoaDonPhai);
                    BanDAO.Instance.UpdateStatusTable(idBanPhai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btSangTraiAll_Click(object sender, EventArgs e)
        {
            int idBanPhai = BanDAO.Instance.GetIdBanByTen(cbxBanPhai.Text);
            int idHoaDonTrai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(_ban.ID);
            int idHoaDonPhai = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(idBanPhai);
            try
            {
                if (idHoaDonTrai == -1)
                {
                    if (MessageBox.Show(cbxBanPhai.Text + " chưa có hóa đơn !! Bạn có muốn tạo hóa đơn không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        while (lsvTableTo.Items.Count > 0)
                        {
                            ListViewItem temp = lsvTableTo.Items[0];
                            lsvTableTo.Items.Remove(temp);
                            lsvTableFrom.Items.Add(temp);
                            string tenMon = temp.Text;
                            int idSanPham = SanPhamDAO.Instance.GetIDByTenSP(tenMon);
                            ThongTinHoaDonDTO thongtin = ThongTinHoaDonDAO.Instance.GETDTO(idSanPham, idHoaDonPhai);
                            int x = thongtin.SoLuong;
                            ThongTinHoaDonDAO.Instance.ChuyenNMon(idHoaDonPhai, idSanPham, _ban.ID,idBanPhai);
                            BanDAO.Instance.UpdateTrangThaiBan(idHoaDonTrai);
                        }
                        HoaDonDAO.Instance.DeleteBillTrong(idHoaDonPhai);
                        BanDAO.Instance.UpdateStatusTable(idBanPhai);
                    }
                }
                else
                {
                    while (lsvTableTo.Items.Count > 0)
                    {
                        ListViewItem temp = lsvTableTo.Items[0];
                        lsvTableTo.Items.Remove(temp);
                        lsvTableFrom.Items.Add(temp);
                        string tenMon = temp.Text;
                        int idSanPham = SanPhamDAO.Instance.GetIDByTenSP(tenMon);
                        ThongTinHoaDonDTO thongtin = ThongTinHoaDonDAO.Instance.GETDTO(idSanPham, idHoaDonPhai);
                        int x = thongtin.SoLuong;
                        ThongTinHoaDonDAO.Instance.ChuyenNMon(idHoaDonPhai, idSanPham, _ban.ID, idBanPhai );
                    }
                    HoaDonDAO.Instance.DeleteBillTrong(idHoaDonPhai);
                    BanDAO.Instance.UpdateStatusTable(idBanPhai);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
