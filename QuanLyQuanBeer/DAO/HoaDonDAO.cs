using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System.Data;

namespace QuanLyQuanBeer.DAO
{
    public class HoaDonDAO
    {
        private static HoaDonDAO instance;
        public static HoaDonDAO Instance
        {
            get { if (instance == null) instance = new HoaDonDAO(); return instance; }
            private set { HoaDonDAO.instance = value; }
        }
        private HoaDonDAO() { }

        public void InsertBill(int idBan, double tongCong)
        {
            string query = ("Exec USP_InsertBill @idBan , @TongCong  ");
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBan, tongCong });
        }

        public int LayIDHoaDonChuaThanhToanBangIDBan(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM  dbo.HoaDon WHERE idBan = " + id + " AND TrangThai = N'Chưa thanh toán'");
            if (data.Rows.Count > 0)
            {
                HoaDonDTO hoaDon = new HoaDonDTO(data.Rows[0]);
                return hoaDon.ID;
            }
            return -1;
        }

        public int GetMaxIdBill()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteScalar("SELECT MAX(id) FROM dbo.HoaDon");
            }
            catch
            {
                return 1;
            }
        }
    }
}
