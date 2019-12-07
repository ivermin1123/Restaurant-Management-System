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
    public class LoaiKhuyenMaiDAO
    {
        private static LoaiKhuyenMaiDAO instance;

        public static LoaiKhuyenMaiDAO Instance
        {
            get { if (instance == null) instance = new LoaiKhuyenMaiDAO(); return instance; }
            private set { LoaiKhuyenMaiDAO.instance = value; }
        }

        private LoaiKhuyenMaiDAO() { }

        public int GetIDByTenLoaiKM(string tenKM)
        {
            string query = "SELECT * FROM LoaiKhuyenMai WHERE TenLoaiKM = N'" + tenKM + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                LoaiKhuyenMaiDTO lkm = new LoaiKhuyenMaiDTO(item);
                return lkm.Id;
            }
            return -1;
        }

        public string GetTenLoaiKMByID(int idLKM)
        {
            string query = "SELECT * FROM LoaiKhuyenMai WHERE id="+ idLKM;
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                LoaiKhuyenMaiDTO lkm = new LoaiKhuyenMaiDTO(item);
                return lkm.TenLoaiKM;
            }
            return string.Empty;
        }

        public List<LoaiKhuyenMaiDTO> GetListLoaiSP()
        {
            List<LoaiKhuyenMaiDTO> dsKM = new List<LoaiKhuyenMaiDTO>();
            string query = ("SELECT * From LoaiKhuyenMai");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                LoaiKhuyenMaiDTO lkm = new LoaiKhuyenMaiDTO(item);
                dsKM.Add(lkm);
            }
            return dsKM;
        }
    }
}
