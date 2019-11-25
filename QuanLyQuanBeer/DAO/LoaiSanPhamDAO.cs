using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyQuanBeer.DAO
{
    public class LoaiSanPhamDAO
    {
        private static LoaiSanPhamDAO instance;
        public static LoaiSanPhamDAO Instance
        {
            get { if (instance == null) instance = new LoaiSanPhamDAO(); return instance; }
            private set { LoaiSanPhamDAO.instance = value; }
        }
        private LoaiSanPhamDAO() { }

        public bool xoaLSP(string ten)
        {
            string query = "DELETE dbo.LoaiSanPham WHERE tenLoaiSanPham = N'" + ten + "'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public string layDanhMuc(string tenLSP)
        {
            string query = "Select * From LoaiSanPham where TenLoaiSanPham = N'" + tenLSP + "' ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                LoaiSanPhamDTO acc = new LoaiSanPhamDTO(item);
                return acc.DanhMuc;
            }
            return "";
        }


        public bool ThemLSP(string tenLoaiSanPham, string danhMuc)
        {
            string query = "themLoaiSanPham N'" + tenLoaiSanPham + "', N'" + danhMuc + "' ";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool capNhatLSP(string tenSP, int id)
        {
            string query = "UPDATE dbo.LoaiSanPham SET TenLoaiSanPham = N'" + tenSP + "' WHERE id = " + id + " ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<LoaiSanPhamDTO> GetListLoaiSP()
        {
            List<LoaiSanPhamDTO> danhSachLoaiSP = new List<LoaiSanPhamDTO>();

            string query = ("SELECT * From LoaiSanPham");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiSanPhamDTO loaiSP = new LoaiSanPhamDTO(item);
                danhSachLoaiSP.Add(loaiSP);
            }
            return danhSachLoaiSP;

        }

        public string GetLoaiSPByID(int idLoai)
        {
            string query = "SELECT * FROM dbo.LoaiSanPham WHERE id = N'" + idLoai + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                LoaiSanPhamDTO sp = new LoaiSanPhamDTO(item);
                return sp.TenloaiSanPham;
            }
            return "";
        }

        public int GetIDByLoaiSP(string tenLSP)
        {
            string query = "SELECT * FROM dbo.LoaiSanPham WHERE TenLoaiSanPham = N'" + tenLSP + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                LoaiSanPhamDTO sp = new LoaiSanPhamDTO(item);
                return sp.ID;
            }
            return 0;
        }

        public string GetLoaiSP(string tenLoaiSanPham)
        {
            string query = "SELECT * FROM dbo.LoaiSanPham WHERE TenLoaiSanPham = N'" + tenLoaiSanPham + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                LoaiSanPhamDTO sp = new LoaiSanPhamDTO(item);
                return sp.TenloaiSanPham;
            }
            return "";
        }
    }
}
