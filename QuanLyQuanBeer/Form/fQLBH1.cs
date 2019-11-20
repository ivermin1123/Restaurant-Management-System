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
    public partial class fQLBH1 : Form
    {
        public fQLBH1()
        {
            InitializeComponent();
            pnChaoMung.Visible = true;
            LoadTable();
            LoadMon();
        }
        void LoadTable()
        {
            List<Ban> tableList = BanDAO.Instance.LoadDsBan();
            foreach (Ban item in tableList)
            {
                btTang1.BackColor = Color.White;
                Button btn = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight, Image = Image.FromFile(@"D:\C#\Icon\banchuaxoabg1.jpg") };
                btn.Text = item.TenBan;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                /*switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(9, 115, 185); 
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(128, 128, 128);
                        break;
                }*/
                flpBan.Controls.Add(btn);
            }
        }

        void LoadMon()
        {
            List<SanPham> tableList = SanPhamDAO.Instance.LoadChonMon();
            foreach (SanPham item in tableList)
            {
                Button btn = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight};
                btn.TextAlign = ContentAlignment.BottomCenter;
                btn.Text = item.TenSanPham;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                /*switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(9, 115, 185); 
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(128, 128, 128);
                        break;
                }*/
                flpChonMon.Controls.Add(btn);
            }
        }


        #region Events
        private void BtSoDowhite_Click(object sender, EventArgs e)
        {
            pnSoDo.Visible = true;
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
            btSoDoblue.Visible = true;
            btSoDowhite.Visible = false;
            btOrderwhite.Visible = false;
            btOrderBlue.Visible = true;
            pnSoDo.Visible = false;
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = true;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbGio.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void FQLBH1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbNgay.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void BtOrderBlue_Click(object sender, EventArgs e)
        {
            btOrderwhite.Visible = true;
            btSoDoblue.Visible = true;
            btSoDowhite.Visible = false;
            pnSoDo.Visible = false;
            pnNewOrder.Visible = false;
            pnOrder.Visible = true;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtOrderwhite_Click(object sender, EventArgs e)
        {
            pnSoDo.Visible = false;
            pnNewOrder.Visible = false;
            pnOrder.Visible = true;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtSoDoblue_Click(object sender, EventArgs e)
        {
            btSoDowhite.Visible = true;
            btOrderwhite.Visible = false;
            btOrderBlue.Visible = true;
            pnSoDo.Visible = true;
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtSoDowhite_Click_1(object sender, EventArgs e)
        {
            pnSoDo.Visible = true;
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtOrderPlus_Click(object sender, EventArgs e)
        {
            btSoDowhite.Visible = false;
            btOrderwhite.Visible = false;
            pnSoDo.Visible = false;
            pnNewOrder.Visible = true;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
            pnTinhTien.Visible = false;
        }

        private void BtTinhTien_Click(object sender, EventArgs e)
        {
            pnTinhTien.Visible = true;
            pnSoDo.Visible = false;
            pnNewOrder.Visible = false;
            pnOrder.Visible = false;
            pnChaoMung.Visible = false;
            pnDsHD.Visible = false;
        }

        private void BtQuayLai_Click(object sender, EventArgs e)
        {
            pnTinhTien.Visible = false;
            pnSoDo.Visible = false;
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
        #endregion
    }
}
