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
        // Khai báo kích thước cho Button Bàn
        public static int TableWidth = 120;
        public static int TableHeight = 80;
        private BanDAO() { }

        public bool XoaBan(string tenBan)
        {
            // Xóa bàn = tên bàn
            // VD: xoaBan @tenBan = N'Bàn 1' => bàn có tên "Bàn 1" sẽ bị xóa.
            string query = "xoaBan @tenBan = N'" + tenBan + "'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool CapNhatBan(string tenSP, int id)
        {
            // Cập nhật tên bàn = id bàn
            // VD: UPDATE dbo.Ban SET TenBan = N'ABC' WHERE id = 1 => Bàn có id = 1 sẽ đổi tên thành "ABC".
            string query = "UPDATE dbo.Ban SET TenBan = N'" + tenSP + "' WHERE id = " + id + " ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool ThemBan(string tenBan)
        {
            // Thêm bàn
            // VD: INSERT INTO dbo.Ban(TenBan,TrangThai) VALUES(N'Bàn x', N'Trống') => Thêm Bàn mới tên = "Bàn x" và Trạng Thái = "Trống".
            string query = "themBan N'" + tenBan + "' ";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public string GetTenBan(string tenBan)
        {
            // Lấy tên bàn
            // VD: SELECT * FROM dbo.Ban WHERE TenBan = N'Bàn 01' => Nếu có trả về "Bàn 1" không có trả về "".
            string query = "SELECT * FROM dbo.Ban WHERE TenBan = N'" + tenBan + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                BanDTO ban = new BanDTO(item);
                return ban.TenBan;
            }
            return "";
        }

        public void UpdateStatusTable( int id)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE dbo.Ban SET TrangThai = N'Trống' Where id = " + id);
        }

        public string GetTrangThaiBanBangIDBan(int idBan)
        {
            string query = "SELECT * FROM dbo.Ban WHERE id = "+ idBan ;
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                BanDTO ban = new BanDTO(item);
                return ban.TrangThai;
            }
            return "";
        }

        public void UpdateTrangThaiBan(int idBan)
        {
            string query = "UPDATE dbo.Ban SET TrangThai = N'Có người' WHERE id = " + idBan + " ";
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public List<BanDTO> LoadDsBan()
        {
            // Trả về danh sách bàn với các giá trị : Id,Tên bàn, Trạng thái
            List<BanDTO> tableList = new List<BanDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTableList");
            foreach (DataRow item in data.Rows)
            {
                BanDTO table = new BanDTO(item);
                tableList.Add(table);
            }
            return tableList;
        }
    }
}
