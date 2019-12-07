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

        public VoucherDTO GETDTOVoucher(string maVC)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From Voucher WHERE id = '" + maVC + "'");
            if (data.Rows.Count > 0)
            {
                VoucherDTO km = new VoucherDTO(data.Rows[0]);
                return km;
            }
            return null;
        }
        public List<VoucherDTO> GetlistVC()
        {
            List<VoucherDTO> listVC = new List<VoucherDTO>();
            string query = "Select * From Voucher ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                VoucherDTO vc = new VoucherDTO(item);
                listVC.Add(vc);
            }
            return listVC;
        }

        public bool SuaVoucher(string id,string tenVC, int giamGia, double giamTien, DateTime hSD)
        {
            string query = "UPDATE dbo.Voucher SET TenVoucher = N'"+tenVC+"' , GiamGia = "+giamGia+", GiamTien = "+giamTien+", HanSuDung = '"+hSD+"' where id = '"+id+"'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public bool XoaVoucher(string id)
        {
            string query = "DELETE dbo.Voucher where id = '" + id + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
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
