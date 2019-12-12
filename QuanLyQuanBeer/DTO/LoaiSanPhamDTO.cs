using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class LoaiSanPhamDTO
    {
        public LoaiSanPhamDTO(int iD, string tenLoaiSanPham, string danhMuc)
        {
            this.ID = iD;
            this.TenloaiSanPham = tenLoaiSanPham;
            this.DanhMuc = danhMuc;
        }

        public LoaiSanPhamDTO(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.TenloaiSanPham = row["tenLoaiSanPham"].ToString();
            this.DanhMuc = row["danhMuc"].ToString();
        }

        private int iD;
        private string tenloaiSanPham;
        private string danhMuc;

        public int ID { get => iD; set => iD = value; }
        public string TenloaiSanPham { get => tenloaiSanPham; set => tenloaiSanPham = value; }
        public string DanhMuc { get => danhMuc; set => danhMuc = value; }
    }
}