using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class MenuDTO
    {
        public MenuDTO(string tenSanPham, int soLuong, double gia, string donVi, double tongCong = 0)
        {
            this.TenSanPham = tenSanPham;
            this.SoLuong = soLuong;
            this.Gia = gia;
            this.TongCong = tongCong;
            this.DonVi = donVi;
        }

        public MenuDTO(DataRow row)
        {
            this.TenSanPham = row["tenSanPham"].ToString();
            this.SoLuong = (int)row["soLuong"];
            this.Gia = (double)(row["gia"]);
            this.TongCong = (double)(row["tongCong"]);
            this.DonVi = row["donVi"].ToString();
        }

        private string tenSanPham;
        private int soLuong;
        private double gia;
        private double tongCong;
        private string donVi;

        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public double Gia { get => gia; set => gia = value; }
        public double TongCong { get => tongCong; set => tongCong = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public string DonVi { get => donVi; set => donVi = value; }
    }
}
