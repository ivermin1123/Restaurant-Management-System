using System.Data;

namespace QuanLyQuanBeer.DTO
{
    public class LoaiKhuyenMaiDTO
    {
        public LoaiKhuyenMaiDTO(int id, string tenLoaiKM)
        {
            this.Id = id;
            this.TenLoaiKM = tenLoaiKM;
        }

        public LoaiKhuyenMaiDTO(DataRow row)
        {
            this.Id = (int)row["id"];
            this.TenLoaiKM = row["tenLoaiKM"].ToString();
        }

        private int id;
        private string tenLoaiKM;

        public int Id { get => id; set => id = value; }
        public string TenLoaiKM { get => tenLoaiKM; set => tenLoaiKM = value; }
    }
}