using System;
using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class VoucherDTO
    {
        public VoucherDTO(string id, string tenVoucher, int giamGia, double giamTien, DateTime hanSuDung, string trangThai)
        {
            this.Id = id;
            this.TenVoucher = tenVoucher;
            this.GiamGia = giamGia;
            this.GiamTien = giamTien;
            this.HanSuDung = hanSuDung;
            this.TrangThai = trangThai;
        }

        public VoucherDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.TenVoucher = row["tenVoucher"].ToString();
            this.GiamGia = (int)row["giamGia"];
            this.GiamTien = (double)row["giamTien"];
            this.HanSuDung = (DateTime)row["hanSuDung"];
            this.TrangThai = row["trangThai"].ToString();
        }

        private string id;
        private string tenVoucher;
        private int giamGia;
        private double giamTien;
        private DateTime hanSuDung;
        private string trangThai;

        public string Id { get => id; set => id = value; }
        public string TenVoucher { get => tenVoucher; set => tenVoucher = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }
        public double GiamTien { get => giamTien; set => giamTien = value; }
        public DateTime HanSuDung { get => hanSuDung; set => hanSuDung = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}