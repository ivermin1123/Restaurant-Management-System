using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyQuanBeer.DAO
{
    public class KhuyenMaiDAO
    {
        private static KhuyenMaiDAO instance;

        public static KhuyenMaiDAO Instance
        {
            get { if (instance == null) instance = new KhuyenMaiDAO(); return instance; }
            private set { KhuyenMaiDAO.instance = value; }
        }

        private KhuyenMaiDAO()
        {
        }

        public List<KhuyenMaiDTO> LoadDsKM()
        {
            List<KhuyenMaiDTO> dsKM = new List<KhuyenMaiDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetDSKM");
            foreach (DataRow item in data.Rows)
            {
                KhuyenMaiDTO km = new KhuyenMaiDTO(item);
                dsKM.Add(km);
            }
            return dsKM;
        }

        public int GetIDByTenKM(string tenKM)
        {
            string query = "SELECT * FROM KhuyenMai WHERE TenKM = N'" + tenKM + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                KhuyenMaiDTO lkm = new KhuyenMaiDTO(item);
                return lkm.Id;
            }
            return -1;
        }

        public KhuyenMaiDTO GetDTOKM(string tenKM)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From KhuyenMai WHERE TenKM = N'" + tenKM + "'");
            if (data.Rows.Count > 0)
            {
                KhuyenMaiDTO km = new KhuyenMaiDTO(data.Rows[0]);
                return km;
            }
            return null;
        }

        public List<KhuyenMaiDTO> LoadDsKMAll()
        {
            List<KhuyenMaiDTO> dsKM = new List<KhuyenMaiDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM KhuyenMai Where idLoaiKm = 1");
            foreach (DataRow item in data.Rows)
            {
                KhuyenMaiDTO km = new KhuyenMaiDTO(item);
                dsKM.Add(km);
            }
            return dsKM;
        }

        public void DoiTrangThai(string trangThai, int id)
        {
            string query = "UPDATE dbo.KhuyenMai SET TrangThai =N'" + trangThai + "' WHERE id =" + id;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public void XoaKhuyenMai(int id)
        {
            string query = "DELETE dbo.KhuyenMai WHERE id =" + id;
            DataProvider.Instance.ExecuteQuery(query);
        }

        public bool ThemKhuyenMai(string tenKM, int giamGia, double giamTien, double toiDa, double dieuKien, int idLoaiKm)
        {
            string query = "USP_InsertDiscount @tenKM , @giamGia , @giamTien , @toiDa , @dieuKien , @idLoaiKM ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenKM, giamGia, giamTien, toiDa, dieuKien, idLoaiKm }) > 0;
        }

        public bool SuaKhuyenMai(string tenKM, int giamGia, double giamTien, double toiDa, double dieuKien, int idLoaiKm, int idKM)
        {
            string query = "USP_UpdateDiscount @tenKM , @giamGia , @giamTien , @toiDa , @dieuKien , @idLoaiKM , @idKM ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { tenKM, giamGia, giamTien, toiDa, dieuKien, idLoaiKm, idKM }) > 0;
        }
    }
}