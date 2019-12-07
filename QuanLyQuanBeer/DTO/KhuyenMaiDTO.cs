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
        public KhuyenMaiDTO(int id, string tenKM, int giamGia, double giamTien, string trangThai, double toiDa, double dieuKien, int idSanPham, int idLoaiKM)
        {
            this.Id = id;
            this.TenKM = tenKM;
            this.GiamGia = giamGia;
            this.GiamTien = giamTien;
            this.TrangThai = trangThai;
            this.ToiDa = toiDa;
            this.DieuKien = dieuKien;
            this.IdSanPham = idSanPham;
            this.IdLoaiKM = idLoaiKM;
        }
        public KhuyenMaiDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.TenKM = row["tenKM"].ToString();
            this.GiamGia = (int)row["giamGia"];
            this.GiamTien = (double)row["giamTien"];
            this.TrangThai = row["trangThai"].ToString();
            if (row["toiDa"] == DBNull.Value)
                row["toiDa"] = 0;
            this.ToiDa = (double)row["toiDa"];
            if (row["dieuKien"] == DBNull.Value)
                row["dieuKien"] = 0;
            this.DieuKien = (double)row["dieuKien"];
            if (row["idSanPham"] == DBNull.Value)
                row["idSanPham"] = 0;
            this.IdSanPham = (int)row["idSanPham"];
            if (row["idLoaiKM"] == DBNull.Value)
                row["idLoaiKM"] = 0;
            this.IdLoaiKM = (int)row["idLoaiKM"];
        }


        private int id;
        private string tenKM;
        private int giamGia;
        private double giamTien;
        private double toiDa;
        private double dieuKien;
        private int idSanPham;
        private int idLoaiKM;
        private string trangThai;

        public int Id { get => id; set => id = value; }
        public string TenKM { get => tenKM; set => tenKM = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }
        public double GiamTien { get => giamTien; set => giamTien = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public double ToiDa { get => toiDa; set => toiDa = value; }
        public double DieuKien { get => dieuKien; set => dieuKien = value; }
        public int IdLoaiKM { get => idLoaiKM; set => idLoaiKM = value; }
        public int IdSanPham { get => idSanPham; set => idSanPham = value; }
    }
}
