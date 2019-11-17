using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DTO
{
    public class HoaDon
    {
        public HoaDon(int iD, DateTime? thoiGianVao, DateTime?  thoiGianRa, int idBan, double tongCong, string trangThai)
        {
            this.ID = iD;
            this.ThoiGianVao = thoiGianVao;
            this.ThoiGianRa = thoiGianRa;
            this.IdBan = idBan;
            this.TongCong = tongCong;
            this.TrangThai = trangThai;
        }

        public HoaDon(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.ThoiGianVao = (DateTime?)row["thoiGianVao"];
            var thoiGianRaTemp = row["thoiGianRa"];
            if (thoiGianRaTemp.ToString() != "")
                this.ThoiGianRa = (DateTime?)thoiGianRaTemp;
            else
                this.TongCong = (double)row["tongCong"];
            this.TrangThai = row["TrangThai"].ToString();
            this.IdBan = (int)row["iDBan"];
        }

        private int iD;
        private DateTime? thoiGianVao;
        private DateTime? thoiGianRa;
        private int idBan;
        private double tongCong;
        private string trangThai;

        public int ID { get => iD; set => iD = value; }
        public DateTime? ThoiGianVao { get => thoiGianVao; set => thoiGianVao = value; }
        public DateTime? ThoiGianRa { get => thoiGianRa; set => thoiGianRa = value; }
        public int IdBan { get => idBan; set => idBan = value; }
        public double TongCong { get => tongCong; set => tongCong = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
