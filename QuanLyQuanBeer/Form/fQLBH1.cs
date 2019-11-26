using QuanLyQuanBeer.DAO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fQLBH1 : Form
    {
        private TaiKhoanDTO taiKhoanHienTai;
        public TaiKhoanDTO TaiKhoanHienTai
        {
            get { return taiKhoanHienTai; }
            set { taiKhoanHienTai = value; }
        }
        public fQLBH1(TaiKhoanDTO acc)
        {
            this.TaiKhoanHienTai = acc;
            InitializeComponent();
            pnChaoMung.Visible = true;
            LoadTable();
            LoadMon();
        }

        #region Method

        void LoadTable()
        {
            flpBan.Controls.Clear();
            List<BanDTO> tableList = BanDAO.Instance.LoadDsBan();
            foreach (BanDTO item in tableList)
            {
                Button bt = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight };
                bt.Text = item.TenBan;
                bt.FlatStyle = FlatStyle.Flat;
                bt.Click += Bt_click;
                bt.Tag = item;
                bt.FlatAppearance.BorderColor = Color.FromArgb(9, 115, 185);
                bt.FlatAppearance.BorderSize = 3;
                bt.FlatAppearance.MouseOverBackColor = Color.Azure;
                bt.FlatAppearance.MouseDownBackColor = Color.PowderBlue;
                bt.Font = new Font("Arial", 12, FontStyle.Bold);
                switch (item.TrangThai)
                {
                    case "Trống":
                        bt.BackColor = Color.White;
                        bt.ForeColor = Color.FromArgb(9, 115, 185);
                        break;
                    default:
                        bt.BackColor = Color.FromArgb(128, 128, 128);
                        bt.ForeColor = Color.White;
                        bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(214,214,214);
                        break;
                }
                flpBan.Controls.Add(bt);
            }
        }
        void XemHoaDon(int id)
        {
            lsvHoaDon.Items.Clear();
            List<MenuDTO> danhSachThongTinHoaDon = MenuDAO.Instance.GetListMenuByTable(id);
            double TongTien = 0;
            foreach (MenuDTO item in danhSachThongTinHoaDon)
            {
                ListViewItem lsvItem = new ListViewItem(item.TenSanPham.ToString());
                lsvItem.SubItems.Add(item.SoLuong.ToString());
                lsvItem.SubItems.Add(item.Gia.ToString());
                lsvItem.SubItems.Add(item.DonVi.ToString());
                if (item.TongCong == 0)
                    lsvItem.SubItems.Add("Miễn phí");
                else
                    lsvItem.SubItems.Add(String.Format("{0:0,0}", item.TongCong) + " VND");
                TongTien += item.TongCong;
                lsvHoaDon.Items.Add(lsvItem);
            }
            if (TongTien > 0)
                txbTongTien.Text = String.Format("{0:0,0}", TongTien);
            else
                txbTongTien.Text = 0.ToString();
        }

        void TaoButton(List<SanPhamDTO> tableList)
        {
            foreach (SanPhamDTO item in tableList)
            {
                if (item.HinhAnh == "")
                    return;
                Panel pn = new Panel();
                Bunifu.Framework.UI.BunifuImageButton bt1 = new Bunifu.Framework.UI.BunifuImageButton();
                TextBox txb = new TextBox();
                Label lb = new Label();
                // panel
                pn.BorderStyle = BorderStyle.FixedSingle;
                pn.Controls.Add(lb);
                pn.Controls.Add(txb);
                pn.Controls.Add(bt1);
                pn.Size = new Size(155, 180);
                // ButtonImage
                bt1.Dock = DockStyle.Top;
                bt1.Cursor = Cursors.Hand;
                bt1.Image = Image.FromFile(@"..//..//..//Pic Food/"+ item.HinhAnh);
                bt1.ImageActive = null;
                bt1.Location = new Point(0, 0);
                bt1.Size = new Size(153, 127);
                bt1.SizeMode = PictureBoxSizeMode.StretchImage;
                bt1.Zoom = 0;
                int idSP = SanPhamDAO.Instance.GetIDByTenSP(item.TenSanPham);
                bt1.Click += (s, e) => 
                {
                    if (!(lsvHoaDon.Tag is BanDTO ban))
                    {
                        MessageBox.Show("Hãy chọn bàn !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    int idHoaDon = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID);
                    //int idSanPham = (comboBoxTenMon.SelectedItem as SanPham).ID;
                    double tongCong = Convert.ToDouble(txbTongTien.Text);
                    if (BanDAO.Instance.GetTrangThaiBanBangIDBan(ban.ID) == "Trống")
                    {
                        DialogResult kq = MessageBox.Show("Bạn đang chọn bàn mới.\n Bạn có muốn tạo hóa đơn mới cho bàn này chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (kq == DialogResult.OK)
                        {
                            HoaDonDAO.Instance.InsertBill(ban.ID, tongCong);
                            ThongTinHoaDonDAO.Instance.InsertBillInfo(HoaDonDAO.Instance.GetMaxIdBill(), idSP, 1);
                            BanDAO.Instance.UpdateTrangThaiBan(ban.ID);
                        }
                    }
                    else
                    {
                        ThongTinHoaDonDAO.Instance.InsertBillInfo(idHoaDon, idSP, 1);
                    }
                    LoadTable();
                    XemHoaDon(ban.ID);
                };
                // textBox
                txb.Cursor = Cursors.Arrow;
                txb.BackColor = Color.FromArgb(242,242,242);
                txb.Dock = DockStyle.Fill;
                txb.ForeColor = Color.Black;
                txb.ReadOnly = true;
                txb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,0);
                txb.Multiline = true;
                txb.Size = new Size(153, 51);
                txb.Text = item.TenSanPham;
                txb.TextAlign = HorizontalAlignment.Center;
                // label
                lb.AutoSize = true;
                lb.BackColor = Color.FromArgb(81,164,201);
                lb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                lb.ForeColor = Color.White;
                lb.Size = new Size(46, 21);
                lb.Location = new Point(103, 1);
                string Gia = ((int)(item.Gia)/1000).ToString();
                lb.Text = Gia + "K";
                flpChonMon.Controls.Add(pn);
            }
        }
        void LoadMon()
        {
            List<SanPhamDTO> tableList = SanPhamDAO.Instance.LoadChonMon();
            TaoButton(tableList);
        }
        void LoadMonAn()
        {
            List<SanPhamDTO> tableList = SanPhamDAO.Instance.LoadMonAn();
            TaoButton(tableList);
        }
        void LoadDoUong()
        {
            List<SanPhamDTO> tableList = SanPhamDAO.Instance.LoadDoUong();
            TaoButton(tableList);
        }
        void LoadKhac()
        {
            List<SanPhamDTO> tableList = SanPhamDAO.Instance.LoadKhac();
            TaoButton(tableList);
        }
        void SearchMonAnTheoTen(string TenMon)
        {
            /*string firstLetters = "";
            foreach (var part in TenMon.Split(' ')) -- Lay ky tu dau tien VD: Con ga => Cg;
                firstLetters += part.Substring(0, 1);*/
            flpChonMon.Controls.Clear();
            List<SanPhamDTO> tableList = SanPhamDAO.Instance.SearchMon(TenMon);
            TaoButton(tableList);
        }
        #endregion

        #region Events
        void Bt_click(object sender, EventArgs e)
        {
            int idBan = ((sender as Button).Tag as BanDTO).ID;
            lsvHoaDon.Tag = (sender as Button).Tag;
            lbIdBan.Text = idBan.ToString();
            XemHoaDon(idBan);
        }

        private void BtSearch_Click_1(object sender, EventArgs e)
        {
            SearchMonAnTheoTen(txbSearch.Text);
        }

        private void BtSoDowhite_Click(object sender, EventArgs e)
        {
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
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

        private void BtUser_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void BtHome_Click(object sender, EventArgs e)
        {
            //pnChaoMung.BringToFront();
            btOrderwhite.Visible = false;
            btOrderBlue.Visible = true;
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = true;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FQLBH1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BtOrderBlue_Click(object sender, EventArgs e)
        {
            btOrderwhite.Visible = true;
            pnNewOrder.Visible = false;
            pnOrder.Visible = true;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtOrderwhite_Click(object sender, EventArgs e)
        {
            pnNewOrder.Visible = false;
            pnOrder.Visible = true;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtSoDoblue_Click(object sender, EventArgs e)
        {
            btOrderwhite.Visible = false;
            btOrderBlue.Visible = true;
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtSoDowhite_Click_1(object sender, EventArgs e)
        {
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtOrderPlus_Click(object sender, EventArgs e)
        {
            btOrderwhite.Visible = false;
            pnNewOrder.Visible = true;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtTinhTien_Click(object sender, EventArgs e)
        {
            pnTinhTien.Visible = true;
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
        }

        private void BtQuayLai_Click(object sender, EventArgs e)
        {
            pnTinhTien.Visible = false;
            pnNewOrder.Visible = true;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
        }

        private void BtThuTien_Click(object sender, EventArgs e)
        {
            fThuTien f = new fThuTien();
            f.ShowDialog();
        }

        private void BtMenu_Click(object sender, EventArgs e)
        {
            pnMenu.BringToFront();
            if (pnMenu.Visible != true)
                pnMenu.Visible = true;
            else
                pnMenu.Visible = false;
        }

        private void BtMonAn_Click(object sender, EventArgs e)
        {
            flpChonMon.Controls.Clear();
            LoadMonAn();
        }

        private void BtDoUong_Click(object sender, EventArgs e)
        {
            flpChonMon.Controls.Clear();
            LoadDoUong();
        }

        private void BtKhac_Click(object sender, EventArgs e)
        {
            flpChonMon.Controls.Clear();
            LoadKhac();
        }

        private void BtTatCa_Click(object sender, EventArgs e)
        {
            flpChonMon.Controls.Clear();
            LoadMon();
        }
        private void TxbSearch_Enter_1(object sender, EventArgs e)
        {
            if (txbSearch.Text == "Nhập tên món cần tìm")
            {
                txbSearch.Text = "";
                txbSearch.ForeColor = Color.Black;
            }
        }

        #endregion

        private void BtThemMonKhac_Click(object sender, EventArgs e)
        {
            if (!(lsvHoaDon.Tag is BanDTO ban))
            {
                MessageBox.Show("Hãy chọn bàn !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idHoaDon = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID);
            fThemMonNgoai f = new fThemMonNgoai(idHoaDon);
            f.ShowDialog();
            XemHoaDon(ban.ID);
        }
    }
}
