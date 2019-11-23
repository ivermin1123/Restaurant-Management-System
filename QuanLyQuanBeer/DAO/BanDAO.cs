using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyQuanBeer.DAO
{
    public class BanDAO
    {
        private static BanDAO instance;

        public static BanDAO Instance
        {
            get { if (instance == null) instance = new BanDAO(); return BanDAO.instance; }
            private set { BanDAO.instance = value; }

        }
        public static int TableWidth = 120;
        public static int TableHeight = 80;
        private BanDAO() { }

        public bool xoaBan(string tenBan)
        {
            string query = "xoaBan @tenBan = N'" + tenBan + "'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
        public bool capNhatBan(string tenSP, int id, string trangThai)
        {
            string query = "UPDATE dbo.Ban SET TenBan = N'" + tenSP + "', TrangThai = N'" + trangThai + "' WHERE id = " + id + " ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        public bool ThemBan(string tenBan)
        {
            string query = "themBan N'" + tenBan + "' ";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public string GetTenBan(string tenBan)
        {
            string query = "SELECT * FROM dbo.Ban WHERE TenBan = N'" + tenBan + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                Ban ban = new Ban(item);
                return ban.TenBan;
            }
            return "";
        }

        public List<Ban> LoadDsBan()
        {
            List<Ban> tableList = new List<Ban>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                Ban table = new Ban(item);
                tableList.Add(table);
            }

            return tableList;
        }
    }
}
