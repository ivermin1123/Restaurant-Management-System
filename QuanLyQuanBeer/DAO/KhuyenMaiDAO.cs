using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private KhuyenMaiDAO() { }

        public List<KhuyenMaiDTO> LoadDsKM()
        {
            // Trả về danh sách bàn với các giá trị : Id,Tên bàn, Trạng thái
            List<KhuyenMaiDTO> dsKM = new List<KhuyenMaiDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetDSKM");
            foreach (DataRow item in data.Rows)
            {
                KhuyenMaiDTO km = new KhuyenMaiDTO(item);
                dsKM.Add(km);
            }
            return dsKM;
        }
    }
}
