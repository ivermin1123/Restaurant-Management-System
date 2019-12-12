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
            lsvBC.Items.Clear();
            DateTime fromDay = dtpkFromDay.Value;
            DateTime toDay = dtpkToDay.Value;
            List<GetHoaDonDTO> listHD = GetHoaDonDAO.Instance.LayDsHoaDonByDate(fromDay, toDay);
            foreach (GetHoaDonDTO item in listHD)
            {
                ListViewItem lsvItem = new ListViewItem(item.ID.ToString());
                lsvItem.SubItems.Add(item.TenBan.ToString());
                lsvItem.SubItems.Add(item.TongCong.ToString());
                lsvItem.SubItems.Add(item.NhanVien.ToString());
                lsvBC.Items.Add(lsvItem);
            }
        }


        private void lsvBC_MouseDoubleClick(object sender, MouseEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            lsvBC.Controls.Clear();
        }
    }
}
