using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static int TableWidth = 100;
        public static int TableHeight = 100;
        private BanDAO() { }
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
