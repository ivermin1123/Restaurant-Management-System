using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DTO
{
    public class MenuDTO
    {
        public MenuDTO(string tenSanPham, int soLuong, float gia, double tongCong = 0)
        {
            this.TenSanPham = tenSanPham;
            this.SoLuong = soLuong;
            this.Gia = gia;
            this.TongCong = tongCong;
        }

        public MenuDTO(DataRow row)
        {
            this.TenSanPham = row["tenSanPham"].ToString();
            this.SoLuong = (int)row["soLuong"];
            this.Gia = (double)(row["gia"]);
            this.TongCong = (double)(row["tongCong"]);
        }

        private string tenSanPham;
        private int soLuong;
        private double gia;
        private double tongCong;

        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public double Gia { get => gia; set => gia = value; }
        public double TongCong { get => tongCong; set => tongCong = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
