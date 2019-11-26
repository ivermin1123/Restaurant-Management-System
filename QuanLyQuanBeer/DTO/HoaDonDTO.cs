using System;
using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class HoaDonDTO
    {
        public HoaDonDTO(int iD, DateTime? thoiGianVao, DateTime? thoiGianRa, int idBan, string trangThai)
        {
            this.ID = iD;
            this.ThoiGianVao = thoiGianVao;
            this.ThoiGianRa = thoiGianRa;
            this.IdBan = idBan;
            this.TrangThai = trangThai;
        }

        public HoaDonDTO(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.ThoiGianVao = (DateTime?)row["thoiGianVao"];
            var thoiGianRaTemp = row["thoiGianRa"];
            if (thoiGianRaTemp.ToString() != "")
                this.ThoiGianRa = (DateTime?)thoiGianRaTemp;
            else
                this.TrangThai = row["TrangThai"].ToString();
            this.IdBan = (int)row["iDBan"];
        }

        private int iD;
        private DateTime? thoiGianVao;
        private DateTime? thoiGianRa;
        private int idBan;
        private string trangThai;

        public int ID { get => iD; set => iD = value; }
        public DateTime? ThoiGianVao { get => thoiGianVao; set => thoiGianVao = value; }
        public DateTime? ThoiGianRa { get => thoiGianRa; set => thoiGianRa = value; }
        public int IdBan { get => idBan; set => idBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
