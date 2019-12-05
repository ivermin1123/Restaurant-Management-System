using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System.Data;

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

        public string layGioiTinh(string tenDN)
        {
            string query = "Select * From ThongTinTaiKhoan where TenDangNhap = N'" + tenDN + "' ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                ThongTinTaiKhoanDTO acc = new ThongTinTaiKhoanDTO(item);
                return acc.GioiTinh;
            }
            return string.Empty;
        }

        public string GetTenBangTenDN(string tenDN)
        {
            string query = "Select * From ThongTinTaiKhoan where TenDangNhap = N'" + tenDN + "' ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                ThongTinTaiKhoanDTO acc = new ThongTinTaiKhoanDTO(item);
                return acc.HoTen;
            }
            return string.Empty;
        }

        public DataTable GetListNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.ThongTinTaiKhoan");
        }
        public bool capNhat(string hoTen, int sDT, string diaChi, int cMND, int tuoi, string gioiTinh, string tenDN)
        {
            string query = "UPDATE dbo.ThongTinTaiKhoan SET HoTen= N'" + hoTen + "' , SoDienThoai = " + sDT + ", DiaChi= N'" + diaChi + "' , CMND= " + cMND + ", Tuoi=" + tuoi + " , GioiTinh= N'" + gioiTinh + "' WHERE TenDangNhap= '" + tenDN + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool them(string hoTen, long sDT, string diaChi, long cMND, int tuoi, string gioiTinh, string tenDN)
        {
            string query = "Exec themThongTinTk  @hoTen= N'" + hoTen + "' , @sDT = " + sDT + ", @diaChi= N'" + diaChi + "' , @cMND= " + cMND + ", @tuoi=" + tuoi + " , @gioiTinh= N'" + gioiTinh + "' , @tenDangNhap= '" + tenDN + "' ";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}
