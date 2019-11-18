using QuanLyQuanBeer.ADO;
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
    }
}
