using QuanLyQuanBeer.DAO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyQuanBeer
{
    public partial class USCBaoCaoTK : UserControl
    {
        public USCBaoCaoTK()
        {
            InitializeComponent();
        }

        private void btLayDuLieu_Click(object sender, EventArgs e)
        {
            try
            {
                lsvBC.Items.Clear();
                DateTime fromDay = dtpkFromDay.Value;
                DateTime toDay = dtpkToDay.Value;
                List<GetHoaDonDTO> listHD = GetHoaDonDAO.Instance.LayDsHoaDonByDate(fromDay, toDay);
                if (listHD.Count <= 0)
                {
                    MessageBox.Show("Không có dữ liệu trong thời gian này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    foreach (GetHoaDonDTO item in listHD)
                    {
                        ListViewItem lsvItem = new ListViewItem(item.ID.ToString());
                        lsvItem.SubItems.Add(item.TenBan.ToString());
                        lsvItem.SubItems.Add(item.TongCong.ToString());
                        lsvItem.SubItems.Add(item.NhanVien.ToString());
                        lsvBC.Items.Add(lsvItem);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lsvBC_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lsvBC.SelectedItems.Count > 0)
                {
                    ListViewItem temp = lsvBC.SelectedItems[0];
                    int idHoaDon = int.Parse(temp.Text);
                    HoaDonDTO hd = HoaDonDAO.Instance.GetDTOHoaDon(idHoaDon);
                    string TenBan = BanDAO.Instance.GetTenBanByID(hd.IdBan);
                    rptBC rptBC = new rptBC(hd.IdBan);
                    rptBC.XuatHoaDon(idHoaDon, TenBan, hd.NhanVien, hd.ThoiGianVao, hd.ThoiGianRa);
                    rptBC.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lsvBC.Controls.Clear();
        }
    }
}