using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanBeer.DTO;
using QuanLyQuanBeer.DAO;
using Bunifu.Framework.UI;

namespace QuanLyQuanBeer.USC
{
    public partial class USCKhuyenMai : UserControl
    {
        public USCKhuyenMai()
        {
            InitializeComponent();
            LoadKM();
        }

        void LoadKM()
        {
            panelAdd.Controls.Clear();
            List<KhuyenMaiDTO> tableList = KhuyenMaiDAO.Instance.LoadDsKMAll();
            foreach (KhuyenMaiDTO item in tableList)
            {
                switch (item.IdLoaiKM)
                {
                    case 1:
                        Panel pn2 = new Panel();
                        Panel pn3 = new Panel();
                        Panel pn4 = new Panel();
                        TextBox txbGiamGia = new TextBox();
                        Panel pn1 = new Panel();
                        BunifuSwitch sw = new BunifuSwitch();
                        TextBox txbGiamTien = new TextBox();
                        TextBox txbDieuKien = new TextBox();
                        TextBox txbToiDa = new TextBox();
                        TextBox txbND = new TextBox();
                        BunifuImageButton bt = new BunifuImageButton();
                        // panel2
                        pn2.Controls.Add(pn3);
                        pn2.Controls.Add(txbND);
                        pn2.Dock = System.Windows.Forms.DockStyle.Top;
                        pn2.Location = new System.Drawing.Point(0, 0);
                        pn2.Name = "panel2";
                        pn2.Size = new System.Drawing.Size(837, 29);
                        pn2.TabIndex = 3;
                        // txbND
                        txbND.Dock = System.Windows.Forms.DockStyle.Fill;
                        txbND.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        txbND.Location = new System.Drawing.Point(0, 0);
                        txbND.MaxLength = 9999;
                        txbND.Text = item.TenKM;
                        txbND.Size = new System.Drawing.Size(837, 29);
                        txbND.TabIndex = 0;
                        // panel3
                        pn3.Controls.Add(pn4);
                        pn3.Controls.Add(txbGiamGia);
                        pn3.Controls.Add(pn1);
                        pn3.Controls.Add(txbGiamTien);
                        pn3.Controls.Add(txbDieuKien);
                        pn3.Controls.Add(txbToiDa);
                        pn3.Dock = System.Windows.Forms.DockStyle.Right;
                        pn3.Location = new System.Drawing.Point(356, 0);
                        pn3.Name = "panel3";
                        pn3.Size = new System.Drawing.Size(481, 29);
                        pn3.TabIndex = 112;
                        // panel4
                        pn4.BackColor = System.Drawing.Color.White;
                        pn4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        pn4.Controls.Add(bt);
                        pn4.Location = new System.Drawing.Point(448, 0);
                        pn4.Name = "panel4";
                        pn4.Size = new System.Drawing.Size(32, 29);
                        pn4.TabIndex = 108;
                        // btXoa
                        bt.Image = Properties.Resources.xoa;
                        bt.ImageActive = null;
                        bt.Location = new System.Drawing.Point(-3, -1);
                        bt.Size = new System.Drawing.Size(35, 29);
                        bt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                        bt.TabIndex = 112;
                        bt.TabStop = false;
                        bt.Zoom = 10;
                        bt.Click += (s, e) =>
                        {
                            if (MessageBox.Show("Bạn có chắc chắn xóa khuyến mãi này chứ ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                            {
                                KhuyenMaiDAO.Instance.XoaKhuyenMai(item.Id);
                                LoadKM();
                            }
                        };
                        // txbGiamGia
                        txbGiamGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        txbGiamGia.Location = new System.Drawing.Point(1, 0);
                        txbGiamGia.MaxLength = 2;
                        txbGiamGia.Text = (item.GiamGia).ToString();
                        txbGiamGia.Size = new System.Drawing.Size(53, 29);
                        txbGiamGia.TabIndex = 1;
                        txbGiamGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                        // panel1
                        pn1.BackColor = System.Drawing.Color.White;
                        pn1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                        pn1.Controls.Add(sw);
                        pn1.Location = new System.Drawing.Point(389, 0);
                        pn1.Name = "panel1";
                        pn1.Size = new System.Drawing.Size(60, 29);
                        pn1.TabIndex = 107;
                        // Switch
                        sw.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                        sw.BorderRadius = 0;
                        sw.Cursor = System.Windows.Forms.Cursors.Hand;
                        sw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                        sw.Location = new System.Drawing.Point(3, 5);
                        if (item.TrangThai == "Đang diễn ra")
                            sw.Value = true;
                        else
                            sw.Value = false;
                        sw.Click += (s, e) =>
                        {
                            if (sw.Value == true)
                                KhuyenMaiDAO.Instance.DoiTrangThai("Đang diễn ra", item.Id);
                            else
                                KhuyenMaiDAO.Instance.DoiTrangThai("Không hoạt động", item.Id);
                        };
                        sw.Oncolor = System.Drawing.Color.SeaGreen;
                        sw.Onoffcolor = System.Drawing.Color.DarkGray;
                        sw.Size = new System.Drawing.Size(51, 19);
                        sw.TabIndex = 5;
                        sw.TabStop = false;
                        sw.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
                        // txbGiamTien
                        txbGiamTien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        txbGiamTien.Location = new System.Drawing.Point(53, 0);
                        txbGiamTien.MaxLength = 8;
                        txbGiamTien.Text = (item.GiamTien).ToString();
                        txbGiamTien.Size = new System.Drawing.Size(113, 29);
                        txbGiamTien.TabIndex = 2;
                        txbGiamTien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        // txbDieuKien
                        txbDieuKien.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        txbDieuKien.Location = new System.Drawing.Point(277, 0);
                        txbDieuKien.MaxLength = 8;
                        txbDieuKien.Text = (item.DieuKien).ToString();
                        txbDieuKien.Size = new System.Drawing.Size(113, 29);
                        txbDieuKien.TabIndex = 4;
                        txbDieuKien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        // txbToiDa
                        txbToiDa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        txbToiDa.Location = new System.Drawing.Point(165, 0);
                        txbToiDa.MaxLength = 8;
                        txbToiDa.Text = (item.ToiDa).ToString();
                        txbToiDa.Size = new System.Drawing.Size(113, 29);
                        txbToiDa.TabIndex = 3;
                        txbToiDa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
                        panelAdd.Controls.Add(pn2);
                         break;
                }
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            fThemKhuyenMai f = new fThemKhuyenMai();
            f.ShowDialog();
            LoadKM();
        }

        private void btLamMoi_Click(object sender, EventArgs e)
        {
            LoadKM();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            fSuaKM f = new fSuaKM();
            f.ShowDialog();
        }
    }
}
