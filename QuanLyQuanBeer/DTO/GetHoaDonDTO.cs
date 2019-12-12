using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class GetHoaDonDTO
    {
        public GetHoaDonDTO(int iD, string tenBan, double tongCong, string nhanVien)
        {
            this.ID = iD;
            this.TenBan = tenBan;
            this.TongCong = tongCong;
            this.NhanVien = nhanVien;
        }

        public GetHoaDonDTO(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.TenBan = row["tenBan"].ToString();
            this.TongCong = (double)row["tongCong"];
            this.NhanVien = row["nhanVien"].ToString();
        }

        private int iD;
        private string nhanVien;
        private string tenBan;
        private double tongCong;

        public int ID { get => iD; set => iD = value; }
        public string NhanVien { get => nhanVien; set => nhanVien = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public double TongCong { get => tongCong; set => tongCong = value; }
    }
}