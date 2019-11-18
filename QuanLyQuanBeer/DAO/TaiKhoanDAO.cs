using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DAO
{
    public class TaiKhoanDAO
    {
        private static TaiKhoanDAO instance;

        public static TaiKhoanDAO Instance
        {
            get { if (instance == null) instance = new TaiKhoanDAO(); return instance; }
            private set { TaiKhoanDAO.instance = value; }
        }

        private TaiKhoanDAO() { }

        public DataTable layDSTaiKhoan()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM TaiKhoan");
        }

        public string layTenDangNhap(string tenDangNhap)
        {
            string query = "SELECT * FROM dbo.TaiKhoan WHERE TenDangNhap = '" + tenDangNhap + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                TaiKhoan acc = new TaiKhoan(item);
                return acc.TenDangNhap;
            }
            return "";
        }

        public bool xoa(string ten)
        {
            string query = "XoaTK '" + ten + "'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool capNhatTK(string matKhau, string loai, string tenDangNhap)
        {
            string query = "UPDATE dbo.TaiKhoan SET MatKhau = '" + matKhau + "', LoaiTaiKhoan = N'" + loai + "' WHERE TenDangNhap = '" + tenDangNhap + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool datLaiMK(string ten)
        {
            string query = "UPDATE dbo.TaiKhoan SET MatKhau = '1' WHERE TenDangNhap = '" + ten + "'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool them(string ten, string matKhau, string loai)
        {
            string query = "themTaiKhoan '" + ten + "', '" + matKhau + "', N'" + loai + "'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public string layTrangThai(string tenDN)
        {
            string query = "Select * From TaiKhoan where TenDangNhap = N'" + tenDN + "' ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                TaiKhoan acc = new TaiKhoan(item);
                return acc.LoaiTaiKhoan;
            }
            return "";
        }

    }
}
