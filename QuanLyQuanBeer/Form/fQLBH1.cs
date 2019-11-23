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
        private TaiKhoan taiKhoanHienTai;
        public TaiKhoan TaiKhoanHienTai
        {
            get { return taiKhoanHienTai; }
            set { taiKhoanHienTai = value; }
        }
        public fQLBH1(TaiKhoan acc)
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
            List<Ban> tableList = BanDAO.Instance.LoadDsBan();
            foreach (Ban item in tableList)
            {
                Button btn = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight };
                btn.Text = item.TenBan;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.FromArgb(9, 115, 185);
                btn.FlatAppearance.BorderSize = 3;
                btn.FlatAppearance.MouseOverBackColor = Color.Azure;
                btn.FlatAppearance.MouseDownBackColor = Color.PowderBlue;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.FromArgb(9, 115, 185);
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(128, 128, 128);
                        break;
                }
                flpBan.Controls.Add(btn);
            }
        }

        void LoadMon()
        {
            List<SanPham> tableList = SanPhamDAO.Instance.LoadChonMon();
            foreach (SanPham item in tableList)
            {
                Button btn = new Button() { Width = 137, Height = 140 };
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Text = item.TenSanPham;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                flpChonMon.Controls.Add(btn);
            }
        }

        void LoadMonAn()
        {
            List<SanPham> tableList = SanPhamDAO.Instance.LoadMonAn();
            foreach (SanPham item in tableList)
            {
                Button btn = new Button() { Width = 137, Height = 140 };
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Text = item.TenSanPham;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                flpChonMon.Controls.Add(btn);
            }
        }

        void LoadDoUong()
        {
            List<SanPham> tableList = SanPhamDAO.Instance.LoadDoUong();
            foreach (SanPham item in tableList)
            {
                Button btn = new Button() { Width = 137, Height = 140 };
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Text = item.TenSanPham;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                flpChonMon.Controls.Add(btn);
            }
        }

        void LoadKhac()
        {
            List<SanPham> tableList = SanPhamDAO.Instance.LoadKhac();
            foreach (SanPham item in tableList)
            {
                Button btn = new Button() { Width = 137, Height = 140 };
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Text = item.TenSanPham;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                flpChonMon.Controls.Add(btn);
            }
        }

        void SearchMonAnTheoTen(string TenMon)
        {
            /*string firstLetters = "";
            foreach (var part in TenMon.Split(' ')) -- Lay ky tu dau tien VD: Con ga => Cg;
                firstLetters += part.Substring(0, 1);*/ 
            flpChonMon.Controls.Clear();
            List<SanPham> tableList = SanPhamDAO.Instance.SearchMon(TenMon);
            foreach (SanPham item in tableList)
            {
                Button btn = new Button() { Width = 137, Height = 140 };
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Text = item.TenSanPham;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                flpChonMon.Controls.Add(btn);
            }
        }
        #endregion

        #region Events

        private void btSearch_Click(object sender, EventArgs e)
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

        private void btMonAn_Click(object sender, EventArgs e)
        {
            flpChonMon.Controls.Clear();
            LoadMonAn();
        }

        private void btDoUong_Click(object sender, EventArgs e)
        {
            flpChonMon.Controls.Clear();
            LoadDoUong();
        }

        private void btKhac_Click(object sender, EventArgs e)
        {
            flpChonMon.Controls.Clear();
            LoadKhac();
        }

        private void btTatCa_Click(object sender, EventArgs e)
        {
            flpChonMon.Controls.Clear();
            LoadMon();
        }
        private void txbSearch_Enter(object sender, EventArgs e)
        {
            if (txbSearch.Text == "Nhập tên món cần tìm")
            {
                txbSearch.Text = "";
                txbSearch.ForeColor = Color.Black;
            }
        }
        #endregion

    }
}
