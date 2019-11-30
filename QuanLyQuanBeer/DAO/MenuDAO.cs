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
        public List<MenuDTO> GetListMenuByTable(int id)
        {
            List<MenuDTO> danhSachMenu = new List<MenuDTO>();
            string query = ("USP_GetHoaDon @idBan = " + id + " ");
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                MenuDTO MenuDTO = new MenuDTO(item);
                danhSachMenu.Add(MenuDTO);
            }
            return danhSachMenu;
        }

        public DataTable GetListSP(int id)
        {
            string query = ("USP_GetHoaDon @idBan = " + id + " ");
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
