using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class KhoDTO
    {
        public KhoDTO(int idHang, string tenHang, string dVT, int sL)
        {
            this.IdHang = idHang;
            this.TenHang = tenHang;
            this.DVT = dVT;
            this.SL = sL;
        }

        public KhoDTO(DataRow row)
        {
            this.IdHang = (int)row["idHang"];
            this.TenHang = row["tenHang"].ToString();
            this.DVT = row["dVT"].ToString();
            this.SL = (int)row["sL"];
        }

        private int idHang;
        private string tenHang;
        private string dVT;
        private int sL;

        public int IdHang { get => idHang; set => idHang = value; }
        public string TenHang { get => tenHang; set => tenHang = value; }
        public string DVT { get => dVT; set => dVT = value; }
        public int SL { get => sL; set => sL = value; }
    }
}