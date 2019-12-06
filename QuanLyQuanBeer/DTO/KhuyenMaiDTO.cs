using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DTO
{
    public class KhuyenMaiDTO
    {
        public KhuyenMaiDTO(string id, string tenKM, int giamGia, double giaTien, string trangThai)
        {
            this.Id = id;
            this.TenKM = tenKM;
            this.GiamGia = giamGia;
            this.GiaTien = giaTien;
            this.TrangThai = trangThai;
        }
        public KhuyenMaiDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.TenKM = row["tenKM"].ToString();
            this.GiamGia = (int)row["giamGia"];
            this.GiaTien = (double)row["giaTien"];
            this.TrangThai = row["trangThai"].ToString();
        }

        private string id;
        private string tenKM;
        private int giamGia;
        private double giaTien;
        private string trangThai;

        public string Id { get => id; set => id = value; }
        public string TenKM { get => tenKM; set => tenKM = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
