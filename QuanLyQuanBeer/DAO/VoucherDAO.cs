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
    public class VoucherDAO
    {
        private static VoucherDAO instance;
        public static VoucherDAO Instance
        {
            get { if (instance == null) instance = new VoucherDAO(); return instance; }
            private set { VoucherDAO.instance = value; }
        }
        private VoucherDAO() { }

        public List<SanPhamDTO> LoadChonMon()
        {
            List<SanPhamDTO> tableList = new List<SanPhamDTO>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListFood");
            foreach (DataRow item in data.Rows)
            {
                SanPhamDTO sp = new SanPhamDTO(item);
                tableList.Add(sp);
            }

            return tableList;
        }

        public List<VoucherDTO> LayThongTinVoucher(string maVC)
        {
            List<VoucherDTO> listVC = new List<VoucherDTO>();
            string query = "Select * From Voucher where id = '"+ maVC + "'" ;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                VoucherDTO vc = new VoucherDTO(item);
                listVC.Add(vc);
            }
            return listVC;
        }

        public bool CheckMaVC(string maVC)
        {
            string query = "Select * From Voucher where id ='" + maVC + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count > 0)
                return true;
            return false;
        }

        public bool ThemVoucher(string id, string TenVoucher, int giamGia, double giamTien, DateTime hanSuDung)
        {
            string query = "USP_InsertVoucher @id , @TenVoucher , @giamGia , @giamTien , @hanSuDung ";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, TenVoucher, giamGia, giamTien, hanSuDung }) > 0;
        }
        public bool CapNhatTrangThaiVoucher(string maVC)
        {
            string query = "UPDATE dbo.Voucher SET TrangThai = N'Đã sử dụng' WHERE id = '" + maVC + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }

    
}
