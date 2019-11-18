using QuanLyQuanBeer.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DAO
{
    public class ThongTinTaiKhoanDAO
    {
        private static ThongTinTaiKhoanDAO instance;

        public static ThongTinTaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new ThongTinTaiKhoanDAO(); return instance; }
            private set { ThongTinTaiKhoanDAO.instance = value; }
        }

        private ThongTinTaiKhoanDAO() { }

        public bool them(string hoTen, long sDT, string diaChi, long cMND, int tuoi, string gioiTinh, string tenDN)
        {
            string query = "Exec themThongTinTk  @hoTen= N'" + hoTen + "' , @sDT = " + sDT + ", @diaChi= N'" + diaChi + "' , @cMND= " + cMND + ", @tuoi=" + tuoi + " , @gioiTinh= N'" + gioiTinh + "' , @tenDangNhap= '" + tenDN + "' ";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

    }
}
