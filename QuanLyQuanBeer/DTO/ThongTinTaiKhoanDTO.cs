using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class ThongTinTaiKhoanDTO
    {
        public ThongTinTaiKhoanDTO(int iD, string hoTen, string soDienThoai, string diaChi, int cMND, int tuoi, string gioiTinh, string tenDangNhap)
        {
            this.ID = iD;
            this.HoTen = hoTen;
            this.SoDienThoai = soDienThoai;
            this.DiaChi = diaChi;
            this.CMND = cMND;
            this.Tuoi = tuoi;
            this.GioiTinh = gioiTinh;
            this.TenDangNhap = tenDangNhap;
        }

        public ThongTinTaiKhoanDTO(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.HoTen = row["hoTen"].ToString();
            this.SoDienThoai = "0" + row["soDienThoai"];
            this.DiaChi = row["diaChi"].ToString();
            this.CMND = (int)row["cMND"];
            this.Tuoi = (int)row["tuoi"];
            this.GioiTinh = row["gioiTinh"].ToString();
            this.TenDangNhap = row["tenDangNhap"].ToString();
        }

        private int iD;
        private string hoTen;
        private string soDienThoai;
        private string diaChi;
        private int cMND;
        private int tuoi;
        private string gioiTinh;
        private string tenDangNhap;

        public int ID { get => iD; set => iD = value; }
        public string HoTen { get => hoTen; set => hoTen = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public int CMND { get => cMND; set => cMND = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
    }
}