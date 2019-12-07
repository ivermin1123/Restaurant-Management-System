using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System;
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
            string query = ("Exec USP_InsertBill @idBan , @TongCong");
            DataProvider.Instance.ExecuteNonQuery(query, new object[] { idBan, tongCong });
        }

        public void CheckOut(int id, double TongCong, decimal TienThua, string NhanVien)
        {
            string query = "UPDATE dbo.HoaDon SET ThoiGianRa = GETDATE(), TrangThai = N'Đã thanh toán', TongCong = " + TongCong + ", TienThua = " + TienThua + " , NhanVien = N'" + NhanVien + "' WHERE id = " + id;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool ApDungVoucher(string maVC,int id)
        {
            string query = "UPDATE dbo.HoaDon SET Voucher ='"+ maVC + "' WHERE id = " + id+"AND TrangThai = N'Chưa thanh toán'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
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

        public string GetVoucherNeuCo(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM  dbo.HoaDon WHERE idBan = " + id + " AND TrangThai = N'Chưa thanh toán'");
            if (data.Rows.Count > 0)
            {
                HoaDonDTO hoaDon = new HoaDonDTO(data.Rows[0]);
                return hoaDon.Voucher;
            }
            return string.Empty;
        }

        public DateTime? GetGioVaoByID(int id)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM  dbo.HoaDon WHERE idBan = " + id + " AND TrangThai = N'Chưa thanh toán'");
            if (data.Rows.Count > 0)
            {
                HoaDonDTO hoaDon = new HoaDonDTO(data.Rows[0]);
                return hoaDon.ThoiGianVao;
            }
            return DateTime.Now;
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
