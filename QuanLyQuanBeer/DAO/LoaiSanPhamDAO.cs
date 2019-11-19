﻿using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyQuanBeer.DAO
{
    public class LoaiSanPhamDAO
    {
        private static LoaiSanPhamDAO instance;
        public static LoaiSanPhamDAO Instance
        {
            get { if (instance == null) instance = new LoaiSanPhamDAO(); return instance; }
            private set { LoaiSanPhamDAO.instance = value; }
        }
        private LoaiSanPhamDAO() { }

        public bool xoaLSP(string ten)
        {
            string query = "DELETE dbo.LoaiSanPham WHERE tenLoaiSanPham = N'" + ten + "'";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool ThemLSP(string tenLoaiSanPham)
        {
            string query = "themLoaiSanPham N'" + tenLoaiSanPham + "' ";
            return DataProvider.Instance.ExecuteNonQuery(query) > 0;
        }

        public bool capNhatLSP(string tenSP, int id)
        {
            string query = "UPDATE dbo.LoaiSanPham SET TenLoaiSanPham = N'" + tenSP + "' WHERE id = " + id + " ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public List<LoaiSanPham> GetListLoaiSP()
        {
            List<LoaiSanPham> danhSachLoaiSP = new List<LoaiSanPham>();

            string query = ("SELECT * From LoaiSanPham ");

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                LoaiSanPham loaiSP = new LoaiSanPham(item);
                danhSachLoaiSP.Add(loaiSP);
            }
            return danhSachLoaiSP;

        }

        public string GetLoaiSP(string tenLoaiSanPham)
        {
            string query = "SELECT * FROM dbo.LoaiSanPham WHERE TenLoaiSanPham = N'" + tenLoaiSanPham + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
            {
                LoaiSanPham sp = new LoaiSanPham(item);
                return sp.TenloaiSanPham;
            }
            return "";
        }
    }
}