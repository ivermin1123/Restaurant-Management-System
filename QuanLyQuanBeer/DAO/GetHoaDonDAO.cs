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
    public class GetHoaDonDAO
    {
        private static GetHoaDonDAO instance;

        public static GetHoaDonDAO Instance
        {
            get { if (instance == null) instance = new GetHoaDonDAO(); return instance; }
            private set { GetHoaDonDAO.instance = value; }
        }
        private GetHoaDonDAO() { }

        public List<GetHoaDonDTO> LayDsHoaDonByDate(DateTime fromDay, DateTime toDay)
        {
            List<GetHoaDonDTO> danhSach = new List<GetHoaDonDTO>();
            string query = "USP_BCTK @fromDate , @toDate ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { fromDay, toDay });
            foreach (DataRow item in data.Rows)
            {
                danhSach.Add(new GetHoaDonDTO(item));
            }
            return danhSach;
        }
    }
}
