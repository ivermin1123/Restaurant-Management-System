using System;
using System.Data;
using System.Linq;

namespace QuanLyQuanBeer.DTO
{
    public class KhoDTO
    {
        public KhoDTO(string idHang, string tenHang, string dVT, int sL, double giaTriTon, string idLoaiKho)
        {
            this.IdHang = idHang;
            this.TenHang = tenHang;
            this.DVT = dVT;
            this.SL = sL;
            this.GiaTriTon = giaTriTon;
            this.IdLoaiKho = idLoaiKho;
        }
        public KhoDTO(DataRow row)
        {
            this.IdHang = row["idHang"].ToString();
            this.TenHang = row["tenHang"].ToString();
            this.DVT = row["dVT"].ToString();
            this.SL = (int)row["sL"];
            this.GiaTriTon = (double)row["giaTriTon"];
            this.IdLoaiKho = row["idLoaiKho"].ToString();
        }

        private string idHang;
        private string tenHang;
        private string dVT;
        private int sL;
        private double giaTriTon;
        private string idLoaiKho;

        public string IdHang { get => idHang; set => idHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string DVT { get => dVT; set => dVT = value; }
        public int SL { get => sL; set => sL = value; }
        public double GiaTriTon { get => giaTriTon; set => giaTriTon = value; }
        public string IdLoaiKho { get => idLoaiKho; set => idLoaiKho = value; }
    }
}
