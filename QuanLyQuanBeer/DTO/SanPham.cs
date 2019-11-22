using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class SanPham
    {
        public SanPham(int iD, string tenSanPham, string donVi, int idLoai, double gia)
        {
            this.ID = iD;
            this.TenSanPham = tenSanPham;
            this.DonVi = donVi;
            this.IdLoai = idLoai;
            this.Gia = gia;
        }

        public SanPham(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.TenSanPham = row["tenSanPham"].ToString();
            this.DonVi = row["donVi"].ToString();
            this.IdLoai = (int)row["idLoai"];
            this.Gia = (double)row["gia"];
        }

        private int iD;
        private string tenSanPham;
        private string donVi;
        private int idLoai;
        private double gia;

        public int ID { get => iD; set => iD = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public string DonVi { get => donVi; set => donVi = value; }
        public int IdLoai { get => idLoai; set => idLoai = value; }
        public double Gia { get => gia; set => gia = value; }
    }
}
