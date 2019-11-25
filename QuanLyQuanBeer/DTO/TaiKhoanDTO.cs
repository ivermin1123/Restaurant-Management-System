using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class TaiKhoanDTO
    {
        public TaiKhoanDTO(string tenDangNhap, string matKhau, string loaiTaiKhoan)
        {
            this.TenDangNhap = tenDangNhap;
            this.MatKhau = matKhau;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }

        public TaiKhoanDTO(DataRow row)
        {
            this.TenDangNhap = row["tenDangNhap"].ToString();
            this.MatKhau = row["matKhau"].ToString();
            this.LoaiTaiKhoan = row["loaiTaiKhoan"].ToString();
        }

        private string tenDangNhap;
        private string matKhau;
        private string loaiTaiKhoan;

        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string LoaiTaiKhoan { get => loaiTaiKhoan; set => loaiTaiKhoan = value; }
    }
}
