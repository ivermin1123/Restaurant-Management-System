using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class MenuDTO
    {
        public MenuDTO(string tenSanPham, int soLuong, double gia, string donVi, double thanhTien = 0)
        {
            this.TenSanPham = tenSanPham;
            this.SoLuong = soLuong;
            this.Gia = gia;
            this.ThanhTien = thanhTien;
            this.DonVi = donVi;
        }

        public MenuDTO(DataRow row)
        {
            this.TenSanPham = row["tenSanPham"].ToString();
            this.SoLuong = (int)row["soLuong"];
            this.Gia = (double)(row["gia"]);
            this.ThanhTien = (double)(row["thanhTien"]);
            this.DonVi = row["donVi"].ToString();
        }

        private string tenSanPham;
        private int soLuong;
        private double gia;
        private double thanhTien;
        private string donVi;

        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public double Gia { get => gia; set => gia = value; }
        public double ThanhTien { get => thanhTien; set => thanhTien = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonVi { get => donVi; set => donVi = value; }
    }
}
