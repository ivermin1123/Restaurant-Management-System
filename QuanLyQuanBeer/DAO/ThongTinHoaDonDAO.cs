using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System.Data;

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

        public ThongTinHoaDonDTO GETDTO(int tenKM,int idHoaDon)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From ThongTinHoaDon WHERE idSanPham ="+tenKM+" AND idHoaDon ="+idHoaDon );
            if (data.Rows.Count > 0)
            {
                ThongTinHoaDonDTO km = new ThongTinHoaDonDTO(data.Rows[0]);
                return km;
            }
            return null;
        }
        public void InsertBillInfo(int idHoaDon, int idSanPham, int SoLuong)
        {
            string query = ("EXEC USP_InsertBillInfo @idHoaDon , @idSanPham , @SoLuong ");
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHoaDon, idSanPham, SoLuong });
        }

        public void DeleteSP(int idHoaDon, int idSanPham)
        {
            string query = ("EXEC USP_DeleteSP @idHoaDon , @idSanPham");
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHoaDon, idSanPham });
        }

        public void UpdateSL(int SoLuong, int idHoaDon, int idSanPham)
        {
            string query = ("EXEC USP_UpdateSL @SoLuong , @idHoaDon , @idSanPham ");
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { SoLuong, idHoaDon, idSanPham });
        }

        public bool ChuyenNMon(int idHoaDon,int idSanPham, int idTableTo,int idTableFrom)
        {
            string query = "ChuyenNMon @idHoaDon , @idSanPham , @idTableTo , @idTableFrom ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { idHoaDon, idSanPham, idTableTo, idTableFrom }) > 0;
        }

    }
}
