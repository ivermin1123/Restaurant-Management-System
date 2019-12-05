using Bunifu.Framework.UI;
using QuanLyQuanBeer.DAO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class fQLBH1 : Form
    {
        BindingSource listSP = new BindingSource();
        private TaiKhoanDTO taiKhoanHienTai;
        private double thanhTien1;
        public bool _KetQua;
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
                        bt.FlatAppearance.MouseOverBackColor = Color.FromArgb(214, 214, 214);
                        break;
                }
                flpBan.Controls.Add(bt);
            }
        }

        void XemHoaDon(int id)
        {
            //CultureInfo culture = new CultureInfo("en-US");
            //Thread.CurrentThread.CurrentCulture = culture;
            //Thread.CurrentThread.CurrentUICulture = culture;
            dtgvHoaDon.DataSource = listSP;
            listSP.DataSource = MenuDAO.Instance.GetListSP(id);
            dtgvHoaDon.Columns[0].HeaderText = "Tên sản phẩm";
            dtgvHoaDon.Columns[0].FillWeight = 160;
            dtgvHoaDon.Columns[1].HeaderText = "SL";
            dtgvHoaDon.Columns[1].FillWeight = 40;
            dtgvHoaDon.Columns[2].HeaderText = "Giá";
            dtgvHoaDon.Columns[2].DefaultCellStyle.Format = "0,0" + " đ";
            dtgvHoaDon.Columns[3].HeaderText = "Đơn vị";
            dtgvHoaDon.Columns[3].FillWeight = 65;
            dtgvHoaDon.Columns[4].HeaderText = "Thành tiền";
            dtgvHoaDon.Columns[4].DefaultCellStyle.Format = "0,0" + " đ";

            DataTable table = MenuDAO.Instance.GetListSP(id);
            object sumObject;
            //if (table.Rows.Count > 0)
            //{
            sumObject = table.Compute("Sum(ThanhTien)", string.Empty);
            txbTongTien.Text = String.Format("{0:0,0}", sumObject);
            //}
        }

        void XemHoaDon1(int id)
        {
            lsvHoaDon1.Items.Clear();
            BanDTO ban = dtgvHoaDon.Tag as BanDTO;
            int idHoaDon = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID);
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
                lsvHoaDon1.Items.Add(lsvItem);
            }
            lbMaHD_Ban.Text = "Mã HD: " + idHoaDon + " - Bàn: " + ban.ID;
            thanhTien1 = TongTien;
            txbThanhTien.Text = String.Format("{0:0,0}", TongTien);
            double gTGT = thanhTien1 * 10 / 100;
            txbGTGT.Text = String.Format("{0:0,0}", gTGT);
            double TongThanhToan = thanhTien1 + gTGT;
            txbTongThanhToan.Text = String.Format("{0:0,0}", TongThanhToan);
            txbConPhaiThu.Text = txbTongThanhToan.Text;
        }

        void TaoButton(List<SanPhamDTO> tableList)
        {
            foreach (SanPhamDTO item in tableList)
            {
                if (item.HinhAnh == string.Empty)
                    item.HinhAnh = "Khongcohinhanh.jpg";
                Panel pn = new Panel();
                BunifuImageButton bt1 = new BunifuImageButton();
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
                bt1.Image = Image.FromFile(@"..//..//..//Pic Food/" + item.HinhAnh);
                bt1.ImageActive = null;
                bt1.Location = new Point(0, 0);
                bt1.Size = new Size(153, 127);
                bt1.SizeMode = PictureBoxSizeMode.StretchImage;
                bt1.Zoom = 0;
                int idSP = SanPhamDAO.Instance.GetIDByTenSP(item.TenSanPham);
                bt1.MouseClick += (s, e) =>
                {
                    if (!(dtgvHoaDon.Tag is BanDTO ban))
                    {
                        MessageBox.Show("Hãy chọn bàn !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    int idHoaDon = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID);
                    if (txbTongTien.Text == string.Empty)
                    {
                        txbTongTien.Text = 0.ToString();
                    }
                    double tongCong = Convert.ToDouble(txbTongTien.Text);
                    if (BanDAO.Instance.GetTrangThaiBanBangIDBan(ban.ID) == "Trống")
                    {
                        DialogResult kq = MessageBox.Show(ban.TenBan + " chưa có hóa đơn.\n Bạn có muốn tạo hóa đơn mới cho bàn này chứ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                        if (kq == DialogResult.OK)
                        {
                            HoaDonDAO.Instance.InsertBill(ban.ID, tongCong);
                            ThongTinHoaDonDAO.Instance.InsertBillInfo(HoaDonDAO.Instance.GetMaxIdBill(), idSP, 1);
                            BanDAO.Instance.UpdateTrangThaiBan(ban.ID);
                            LoadTable();
                        }
                    }
                    else
                    {
                        switch (e.Button)
                        {
                            case MouseButtons.Left:
                                ThongTinHoaDonDAO.Instance.InsertBillInfo(idHoaDon, idSP, 1);
                                break;
                            case MouseButtons.Right:
                                ThongTinHoaDonDAO.Instance.InsertBillInfo(idHoaDon, idSP, -1);
                                break;
                        }
                    }
                    XemHoaDon(ban.ID);
                };
                // textBox
                txb.Cursor = Cursors.Arrow;
                txb.BackColor = Color.FromArgb(242, 242, 242);
                txb.Dock = DockStyle.Fill;
                txb.ForeColor = Color.Black;
                txb.ReadOnly = true;
                txb.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                txb.Multiline = true;
                txb.Size = new Size(153, 51);
                txb.Text = item.TenSanPham;
                txb.TextAlign = HorizontalAlignment.Center;
                // label
                lb.AutoSize = true;
                lb.BackColor = Color.FromArgb(81, 164, 201);
                lb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
                lb.ForeColor = Color.White;
                lb.Size = new Size(46, 21);
                lb.Location = new Point(103, 1);
                string Gia = ((int)(item.Gia) / 1000).ToString();
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
            dtgvHoaDon.Tag = (sender as Button).Tag;
            lbIdBan.Text = idBan.ToString();
            XemHoaDon(idBan);
            XemHoaDon1(idBan);
        }

        private void CkbxGTGT_OnChange(object sender, EventArgs e)
        {
            double gTGT;
            if (ckbxGTGT.Checked != true)
            {
                txbGTGT.Text = string.Empty;
                double TongThanhToan = thanhTien1 + 0;
                txbTongThanhToan.Text = String.Format("{0:0,0}", TongThanhToan);
                txbConPhaiThu.Text = txbTongThanhToan.Text;
            }
            else
            {
                gTGT = thanhTien1 * 10 / 100;
                txbGTGT.Text = String.Format("{0:0,0}", gTGT);
                double TongThanhToan = thanhTien1 + gTGT;
                txbTongThanhToan.Text = String.Format("{0:0,0}", TongThanhToan);
                txbConPhaiThu.Text = txbTongThanhToan.Text;
            }
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
            pnDatCho.Visible = false;
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
            pnDatCho.Visible = false;
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
            pnDatCho.Visible = false;
        }

        private void BtOrderwhite_Click(object sender, EventArgs e)
        {
            pnNewOrder.Visible = false;
            pnOrder.Visible = true;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
            pnDatCho.Visible = false;
        }

        private void BtSoDoblue_Click(object sender, EventArgs e)
        {
            btOrderwhite.Visible = false;
            btOrderBlue.Visible = true;
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDatCho.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtSoDowhite_Click_1(object sender, EventArgs e)
        {
            pnNewOrder.Visible = false;
            pnDatCho.Visible = false;
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
            pnDatCho.Visible = false;
        }

        private void BtDatChoWhite_Click(object sender, EventArgs e)
        {
            btOrderwhite.Visible = false;
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
            pnDatCho.Visible = true;
        }

        private void DtgvHoaDon_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                BanDTO ban = dtgvHoaDon.Tag as BanDTO;
                int idHoaDon = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID);
                if (dtgvHoaDon.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dtgvHoaDon.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dtgvHoaDon.Rows[selectedrowindex];
                    string a = Convert.ToString(selectedRow.Cells["SoLuong"].Value);
                    string b = Convert.ToString(selectedRow.Cells["TenSanPham"].Value);
                    int SL = int.Parse(a);
                    int idSP = SanPhamDAO.Instance.GetIDByTenSP(b);
                    ThongTinHoaDonDAO.Instance.UpdateSL(SL, idHoaDon, idSP);
                    XemHoaDon(ban.ID);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void DtgvHoaDon_KeyDown(object sender, KeyEventArgs e)
        {
            BanDTO ban = dtgvHoaDon.Tag as BanDTO;
            int idHoaDon = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID);
            if (e.KeyCode == Keys.Delete)
            {
                int selectedrowindex = dtgvHoaDon.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dtgvHoaDon.Rows[selectedrowindex];
                string b = Convert.ToString(selectedRow.Cells["TenSanPham"].Value);
                int idSP = SanPhamDAO.Instance.GetIDByTenSP(b);
                ThongTinHoaDonDAO.Instance.DeleteSP(idHoaDon, idSP);
                XemHoaDon(ban.ID);
            }
        }

        private void BtTinhTien_Click_1(object sender, EventArgs e)
        {
            if (!(dtgvHoaDon.Tag is BanDTO ban))
            {
                MessageBox.Show("Hãy chọn bàn !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                if (HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID) != -1)
                {
                    XemHoaDon1(ban.ID);
                    pnTinhTien.Visible = true;
                    pnNewOrder.Visible = false;
                    pnOrder.Visible = false;
                    pnChaoMung.Visible = false;
                    pnDsHD.Visible = false;
                }
                else
                    MessageBox.Show("Không có hóa đơn để thanh toán !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

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
                txbSearch.Text = string.Empty;
                txbSearch.ForeColor = Color.Black;
            }
        }

        private void BtThemMonKhac_Click(object sender, EventArgs e)
        {
            if (!(dtgvHoaDon.Tag is BanDTO ban))
            {
                MessageBox.Show("Hãy chọn bàn !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idHoaDon = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID);
            fThemMonNgoai f = new fThemMonNgoai(idHoaDon, ban.ID, ban.TenBan);
            f.ShowDialog();
            XemHoaDon(ban.ID);
            XemHoaDon1(ban.ID);
        }

        private void BtThuTien_Click_1(object sender, EventArgs e)
        {
            BanDTO ban = dtgvHoaDon.Tag as BanDTO;
            string ThanhTien = txbThanhTien.Text;
            int idHoaDon = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID);
            DateTime? GioVao = HoaDonDAO.Instance.GetGioVaoByID(ban.ID);
            rptInTam rptInTam = new rptInTam(ban.ID);
            string VAT;
            if (ckbxGTGT.Checked == true)
                VAT = txbGTGT.Text;
            else
                VAT = "0";
            string tongTien = txbConPhaiThu.Text;
            string TenDN = TaiKhoanHienTai.TenDangNhap;
            string NhanVien = ThongTinTaiKhoanDAO.Instance.GetTenBangTenDN(TenDN);
            string ThanhToan = txbTongThanhToan.Text;
            fThuTien f = new fThuTien(tongTien, ban.ID, NhanVien, ThanhTien, idHoaDon, GioVao, VAT, ban.TenBan, ThanhToan);
            f.ShowDialog();
            XemHoaDon1(ban.ID);
            XemHoaDon(ban.ID);
            LoadTable();
            if (HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID) == -1)
            {
                btOrderwhite.Visible = false;
                pnNewOrder.Visible = true;
                pnOrder.Visible = false;
                pnChaoMung.Visible = false;
                pnDsHD.Visible = false;
                pnTinhTien.Visible = false;
            }
        }

        private void BtQuayLai_Click_1(object sender, EventArgs e)
        {
            pnTinhTien.Visible = false;
            pnNewOrder.Visible = true;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
        }

        private void BtLamMoi_Click(object sender, EventArgs e)
        {
            LoadTable();
        }


        #endregion



        private void BtInTamTinh_Click(object sender, EventArgs e)
        {
            try
            {
                BanDTO ban = dtgvHoaDon.Tag as BanDTO;
                string ThanhTien = txbThanhTien.Text;
                int idHoaDon = HoaDonDAO.Instance.LayIDHoaDonChuaThanhToanBangIDBan(ban.ID);
                string TenDN = TaiKhoanHienTai.TenDangNhap;
                string NhanVien = ThongTinTaiKhoanDAO.Instance.GetTenBangTenDN(TenDN);
                DateTime? GioVao = HoaDonDAO.Instance.GetGioVaoByID(ban.ID);
                string VAT;
                if (ckbxGTGT.Checked == true)
                    VAT = txbGTGT.Text;
                else
                    VAT = "0";
                string ThanhToan = txbTongThanhToan.Text;
                rptInTam rptInTam = new rptInTam(ban.ID);
                rptInTam.XuatHoaDon(idHoaDon, ban.TenBan, NhanVien, ThanhTien, GioVao, VAT, ThanhToan);
                rptInTam.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtLamMoi_Click_1(object sender, EventArgs e)
        {
            LoadTable();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BtOrderPlus_Click(sender, e);
        }
    }
}
