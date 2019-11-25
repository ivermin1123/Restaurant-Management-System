using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System.Collections.Generic;
using System.Data;

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

        public List<SanPhamDTO> LoadChonMon()
        {
            List<SanPhamDTO> tableList = new List<SanPhamDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListFood");
            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO(item);
                tableList.Add(sp);
            }

            return tableList;
        }

        public List<SanPhamDTO> SearchMon(string name)
        {
            List<SanPhamDTO> tableList = new List<SanPhamDTO>();
            string query = string.Format("Select * From SanPham where dbo.fuConvertToUnsign1(TenSanPham) Like N'%'+ dbo.fuConvertToUnsign1(N'{0}') +'%'", name);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO(item);
                tableList.Add(sp);
            }
            return tableList;
        }

        public List<SanPhamDTO> LoadMonAn()
        {
            List<SanPhamDTO> tableList = new List<SanPhamDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListMonAn");
            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO(item);
                tableList.Add(sp);
            }
            return tableList;
        }

        public List<SanPhamDTO> LoadDoUong()
        {
            List<SanPhamDTO> tableList = new List<SanPhamDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListDoUong");
            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO(item);
                tableList.Add(sp);
            }
            return tableList;
        }

        public List<SanPhamDTO> LoadKhac()
        {
            List<SanPhamDTO> tableList = new List<SanPhamDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListKhac");
            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO(item);
                tableList.Add(sp);
            }
            return tableList;
        }

        public DataTable GetListSP()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT a.id,TenSanPham,DonVi,Gia,b.TenLoaiSanPham,b.DanhMuc From SanPham a,  LoaiSanPham b where a.idLoai = b.id");
        }

        public bool ThemSP(string tenSanPham, string DonVi, double gia, int idLoai)
        {
            string query = "USP_InsertDrink @TenSanPham , @DonVi , @Gia , @idLoai ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenSanPham, DonVi, gia, idLoai }) > 0;
        }

        public bool capNhatSP(string tenSP, string DonVi, double Gia, int idLoai, int id)
        {
            string query = "UPDATE dbo.SanPham SET TenSanPham = N'" + tenSP + "' , DonVi = N'" + DonVi + "', Gia = " + Gia + ", idLoai= " + idLoai + "  WHERE id = " + id + " ";
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
                SanPhamDTO sp = new SanPhamDTO(item);
                return sp.TenSanPham;
            }
            return "";
        }

        public int GetIdLoai(string tenSanPham)
        {
            string query = "SELECT * FROM dbo.SanPham WHERE TenSanPham = N'" + tenSanPham + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO(item);
                return sp.IdLoai;
            }
            return 0;
        }
    }
}
