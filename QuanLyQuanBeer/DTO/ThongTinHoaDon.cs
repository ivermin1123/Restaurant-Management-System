using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DTO
{
    public class ThongTinHoaDon
    {
        public ThongTinHoaDon(int iD, int idHoaDon, int idSanPham, int soLuong)
        {
            this.ID = iD;
            this.IdHoaDon = idHoaDon;
            this.IdSanPham = idSanPham;
            this.SoLuong = soLuong;
        }

        public ThongTinHoaDon(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.IdHoaDon = (int)row["idHoaDon"];
            this.IdSanPham = (int)row["idSanPham"];
            this.SoLuong = (int)row["soLuong"];
        }

        private int iD;
        private int idHoaDon;
        private int idSanPham;
        private int soLuong;

        public int ID { get => iD; set => iD = value; }
        public int IdHoaDon { get => idHoaDon; set => idHoaDon = value; }
        public int IdSanPham { get => idSanPham; set => idSanPham = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
