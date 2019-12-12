using System;
using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class HoaDonDTO
    {
        public HoaDonDTO(int iD, DateTime? thoiGianVao, DateTime? thoiGianRa, int idBan, string trangThai, string voucher, double khuyenMai, double vAT, double tongCong, string nhanVien)
        {
            this.ID = iD;
            this.ThoiGianVao = thoiGianVao;
            this.ThoiGianRa = thoiGianRa;
            this.IdBan = idBan;
            this.TrangThai = trangThai;
            this.Voucher = voucher;
            this.KhuyenMai = khuyenMai;
            this.VAT = vAT;
            this.TongCong = tongCong;
            this.NhanVien = nhanVien;
        }

        public HoaDonDTO(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.ThoiGianVao = (DateTime?)row["thoiGianVao"];
            var thoiGianRaTemp = row["thoiGianRa"];
            if (thoiGianRaTemp.ToString() != string.Empty)
                this.ThoiGianRa = (DateTime?)thoiGianRaTemp;
            else
                this.TrangThai = row["TrangThai"].ToString();
            this.IdBan = (int)row["iDBan"];
            if (row["voucher"] == DBNull.Value)
                row["voucher"] = string.Empty;
            this.Voucher = row["voucher"].ToString();
            this.KhuyenMai = (double)row["khuyenMai"];
            this.VAT = (double)row["vAT"];
            this.TongCong = (double)row["tongCong"];
            this.NhanVien = row["nhanVien"].ToString();
        }

        private int iD;
        private DateTime? thoiGianVao;
        private DateTime? thoiGianRa;
        private int idBan;
        private string trangThai;
        private string voucher;
        private double khuyenMai;
        private double vAT;
        private string nhanVien;
        private double tongCong;

        public int ID { get => iD; set => iD = value; }
        public DateTime? ThoiGianVao { get => thoiGianVao; set => thoiGianVao = value; }
        public DateTime? ThoiGianRa { get => thoiGianRa; set => thoiGianRa = value; }
        public int IdBan { get => idBan; set => idBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
        public string Voucher { get => voucher; set => voucher = value; }
        public double KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
        public double VAT { get => vAT; set => vAT = value; }
        public double TongCong { get => tongCong; set => tongCong = value; }
        public string NhanVien { get => nhanVien; set => nhanVien = value; }
    }
}