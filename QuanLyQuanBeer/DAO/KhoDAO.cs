using QuanLyQuanBeer.ADO;
using System.Data;

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

        private KhoDAO()
        {
        }

        public DataTable GetListKho()
        {
            string query = "USP_GetDsKho";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public bool ThemSP(string tenSP, int SL,double gia,string DVT)
        {
            string query = "themKho @tenSP , @SL , @gia , @DVT";
            return DataProvider.Instance.ExecuteNonQuery(query,new object[] { tenSP, SL, gia,DVT}) > 0;
        }

        public bool CapNhatKho(string tenSP, int SL, double gia, string DVT, int id)
        {
            string query = "UPDATE dbo.Kho SET TenHang = N'"+tenSP+"' , DVT = N'"+DVT +"' , SL = "+SL+ " , Gia = " + gia + "  WHERE idHang = " + id + " ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool XoaKho(int id)
        {
            string query = "DELETE dbo.Kho WHERE idHang ="+ id;
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }
    }
}