using QuanLyQuanBeer.ADO;
using QuanLyQuanBeer.DTO;
using System.Collections.Generic;
using System.Data;

namespace QuanLyQuanBeer.DAO
{
    public class MenuDAO
    {
        private static MenuDAO instance;
        public static MenuDAO Instance
        {
            get { if (instance == null) instance = new MenuDAO(); return instance; }
            private set { instance = value; }
        }
        private MenuDAO() { }

        public List<MenuDTO> GetListMenuByTable1(int id)
        {
            List<MenuDTO> danhSachMenu = new List<MenuDTO>();
            string query = ("USP_GetHoaDon @idBan =" + id + " ");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MenuDTO MenuDTO = new MenuDTO(item);
                danhSachMenu.Add(MenuDTO);
            }
            return danhSachMenu;
        }

        public DataTable GetListSP1(int idBan)
        {
            string query = ("USP_InBill @idBan =" + idBan);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public DataTable GetListSP2(int idBan)
        {
            string query = ("USP_InBill1 @idBan =" + idBan);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public List<MenuDTO> GetListMenuByTable(int id)
        {
            List<MenuDTO> danhSachMenu = new List<MenuDTO>();
            string query = ("USP_InBill @idBan =" + id);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MenuDTO MenuDTO = new MenuDTO(item);
                danhSachMenu.Add(MenuDTO);
            }
            return danhSachMenu;
        }

        public static List<MenuDTO> GetMenuDTOs(int idBan)
        {
            List<MenuDTO> danhSachMenu = new List<MenuDTO>();
            string query = "USP_InBill @idBan = " + idBan;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                danhSachMenu.Add(menu);
            }
            return danhSachMenu;
        }

        public static List<MenuDTO> GetListMenuByIDBill(int idBill)
        {
            List<MenuDTO> listmenu = new List<MenuDTO>();
            string query = "USP_GetHoaDonByIDBill @idHoaDon = " + idBill;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MenuDTO menu = new MenuDTO(item);
                listmenu.Add(menu);
            }
            return listmenu;
        }

        public DataTable GetListSP(int id)
        {
            string query = ("USP_GetHoaDon @idBan = " + id + " ");
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
