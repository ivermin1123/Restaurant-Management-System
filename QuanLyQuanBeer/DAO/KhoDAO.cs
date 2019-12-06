using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyQuanBeer.DAO
{
    public class KhoDAO
    {
        private static KhoDAO instance;

        public static KhoDAO Instance
        {
            get { if (instance == null) instance = new KhoDAO(); return instance; }
            private set { KhoDAO.instance = value; }
        }

        private KhoDAO() { }

        public DataTable GetListKho()
        {
            string query = "USP_GetDsKho";
            return  DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
