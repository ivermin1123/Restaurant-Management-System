using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DTO
{
    public class Ban
    {
        public Ban(int iD, string tenBan, string trangThai)
        {
            this.ID = iD;
            this.TenBan = tenBan;
            this.TrangThai = trangThai;
        }

        public Ban(DataRow row)
        {
            this.ID = (int)row["iD"];
            this.TenBan = row["tenBan"].ToString();
            this.TrangThai = row["trangThai"].ToString();
        }

        private int iD;
        private string tenBan;
        private string trangThai;

        public int ID { get => iD; set => iD = value; }
        public string TenBan { get => tenBan; set => tenBan = value; }
        public string TrangThai { get => trangThai; set => trangThai = value; }
    }
}
