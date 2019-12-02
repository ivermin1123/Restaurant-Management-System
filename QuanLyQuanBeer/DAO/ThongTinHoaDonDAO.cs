using QuanLyQuanBeer.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DAO
{
    public class ThongTinHoaDonDAO
    {
        private static ThongTinHoaDonDAO instance;

        public static ThongTinHoaDonDAO Instance
        {
            get { if (instance == null) instance = new ThongTinHoaDonDAO(); return instance; }
            private set { ThongTinHoaDonDAO.instance = value; }
        }

        private ThongTinHoaDonDAO() { }

        public void InsertBillInfo(int idHoaDon, int idSanPham, int SoLuong)
        {
            string query = ("EXEC USP_InsertBillInfo @idHoaDon , @idSanPham , @SoLuong ");
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHoaDon, idSanPham, SoLuong });
        }

        public void DeleteSP(int idHoaDon, int idSanPham)
        {
            string query = ("EXEC USP_DeleteSP @idHoaDon , @idSanPham");
            DataProvider.Instance.ExecuteNonQuery(query, new object[] {idHoaDon, idSanPham });
        }

        public void UpdateSL(int SoLuong, int idHoaDon, int idSanPham)
        {
            string query = ("EXEC USP_UpdateSL @SoLuong , @idHoaDon , @idSanPham ");
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { SoLuong, idHoaDon, idSanPham });
        }
    }
}
