using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class SanPhamDTO
    {
        public SanPhamDTO(int iD, string tenSanPham, string donVi, int idLoai, double gia, string hinhAnh)
        {
            this.ID = iD;
            this.TenSanPham = tenSanPham;
            this.DonVi = donVi;
            this.IdLoai = idLoai;
            this.Gia = gia;
            this.HinhAnh = hinhAnh;
        }

        public SanPhamDTO(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.TenSanPham = row["tenSanPham"].ToString();
            this.DonVi = row["donVi"].ToString();
            this.IdLoai = (int)row["idLoai"];
            this.Gia = (double)row["gia"];
            this.HinhAnh = row["hinhAnh"].ToString();
        }

        private int iD;
        private string tenSanPham;
        private string donVi;
        private int idLoai;
        private double gia;
        private string hinhAnh;

        public int ID { get => iD; set => iD = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int IdLoai { get => idLoai; set => idLoai = value; }
        public double Gia { get => gia; set => gia = value; }
        public string HinhAnh { get => hinhAnh; set => hinhAnh = value; }
    }
}
