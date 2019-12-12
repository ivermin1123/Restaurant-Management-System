namespace QuanLyQuanBeer.DAO
{
    public class LoaiKhoDAO
    {
        private static LoaiKhoDAO instance;

        public static LoaiKhoDAO Instance
        {
            get { if (instance == null) instance = new LoaiKhoDAO(); return instance; }
            private set { LoaiKhoDAO.instance = value; }
        }

        private LoaiKhoDAO()
        {
        }
    }
}