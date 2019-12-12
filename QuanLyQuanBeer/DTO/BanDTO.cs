using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class BanDTO
    {
        public BanDTO(int iD, string tenBan, string trangThai)
        {
            this.ID = iD;
            this.TenBan = tenBan;
            this.TrangThai = trangThai;
        }

        public BanDTO(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.TenBan = row["tenBan"].ToString();
            this.TrangThai = row["trangThai"].ToString();
        }

        private int iD;
        private string tenBan;
        private string trangThai;

        public int ID { get => iD; set => iD = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}