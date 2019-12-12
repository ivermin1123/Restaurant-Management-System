using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class ThongTinHoaDonDTO
    {
        public ThongTinHoaDonDTO(int iD, int idHoaDon, int idSanPham, int soLuong)
        {
            this.ID = iD;
            this.IdHoaDon = idHoaDon;
            this.IdSanPham = idSanPham;
            this.SoLuong = soLuong;
        }

        public ThongTinHoaDonDTO(DataRow row)
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