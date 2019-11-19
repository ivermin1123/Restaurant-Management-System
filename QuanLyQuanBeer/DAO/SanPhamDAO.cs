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
    public class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return instance; }
            private set { instance = value; }
        }

        private SanPhamDAO() { }

        public bool XoaSP(string tenSanPham)
        {
            string query = ("XoaSp N'" + tenSanPham + "'");
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public List<SanPham> LoadChonMon()
        {
            List<SanPham> tableList = new List<SanPham>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListFood");
            foreach (DataRow item in data.Rows)
            {
                SanPham sp = new SanPham(item);
                tableList.Add(sp);
            }

            return tableList;
        }

        public DataTable GetListSP()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.id,TenSanPham,DonVi,Gia,b.TenLoaiSanPham,a.HinhAnh From SanPham a,  LoaiSanPham b where a.idLoai = b.id");
        }

        public bool ThemSP(string tenSanPham, string DonVi, double gia, int idLoai)
        {
            string query = "USP_InsertDrink @TenSanPham , @DonVi , @Gia , @idLoai ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenSanPham, DonVi ,gia, idLoai }) > 0;
        }

        public bool capNhatSP(string tenSP, string DonVi, double Gia, int idLoai, int id)
        {
            string query = "UPDATE dbo.SanPham SET TenSanPham = N'" + tenSP + "' , DonVi = N'"+DonVi+"', Gia = " + Gia + ", idLoai= " + idLoai + "  WHERE id = " + id + " ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool xoa(string ten)
        {
            string query = "DELETE dbo.LoaiSanPham WHERE tenLoaiSanPham = N'" + ten + "'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public string GetTenSP(string tenSanPham)
        {
            string query = "SELECT * FROM dbo.SanPham WHERE TenSanPham = N'" + tenSanPham + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                SanPham sp = new SanPham(item);
                return sp.TenSanPham;
            }
            return "";
        }


    }
}
