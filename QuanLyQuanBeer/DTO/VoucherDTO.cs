using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DTO
{
    public class VoucherDTO
    {
        public VoucherDTO(string id, string tenVoucher, int giamGia, double giaTien, DateTime hanSuDung)
        {
            this.Id = id;
            this.TenVoucher = tenVoucher;
            this.GiamGia = giamGia;
            this.GiaTien = giaTien;
            this.HanSuDung = hanSuDung;
        }
        public VoucherDTO(DataRow row)
        {
            this.Id = row["id"].ToString();
            this.TenVoucher = row["tenKM"].ToString();
            this.GiamGia = (int)row["giamGia"];
            this.GiaTien = (double)row["giaTien"];
            this.HanSuDung = (DateTime)row["hanSuDung"];
        }

        private string id;
        private string tenVoucher;
        private int giamGia;
        private double giaTien;
        private DateTime hanSuDung;

        public string Id { get => id; set => id = value; }
        public string TenVoucher { get => tenVoucher; set => tenVoucher = value; }
        public int GiamGia { get => giamGia; set => giamGia = value; }
        public double GiaTien { get => giaTien; set => giaTien = value; }
        public DateTime HanSuDung { get => hanSuDung; set => hanSuDung = value; }
    }
}
