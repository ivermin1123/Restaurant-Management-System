using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DTO
{
    public class LoaiSanPham
    {
        public LoaiSanPham(int iD, string tenLoaiSanPham)
        {
            this.ID = iD;
            this.TenloaiSanPham = tenLoaiSanPham;
        }

        public LoaiSanPham(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.TenloaiSanPham = row["tenLoaiSanPham"].ToString();
        }

        private int iD;
        private string tenloaiSanPham;

        public int ID { get => iD; set => iD = value; }
        public string TenloaiSanPham { get => tenloaiSanPham; set => tenloaiSanPham = value; }
    }
}
