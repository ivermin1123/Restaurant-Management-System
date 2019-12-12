using QuanLyQuanBeer.DAO;
using System.Windows.Forms;

namespace QuanLyQuanBeer.USC
{
    public partial class USCLoaiKM : UserControl
    {
        private BindingSource listKM = new BindingSource();

        public USCLoaiKM()
        {
            InitializeComponent();
            LoadKM();
        }

        private void LoadKM()
        {
            dtgvLoaiKM.DataSource = listKM;
            listKM.DataSource = LoaiKhuyenMaiDAO.Instance.GetListLoaiSP();
            dtgvLoaiKM.Columns[0].HeaderText = "ID";
            dtgvLoaiKM.Columns[1].HeaderText = "Loại khuyến mại";
        }
    }
}