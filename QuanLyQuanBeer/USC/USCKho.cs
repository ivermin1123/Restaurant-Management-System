using QuanLyQuanBeer.DAO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuanLyQuanBeer.USC
{
    public partial class USCKho : UserControl
    {
        BindingSource listKho = new BindingSource();
        public USCKho()
        {
            InitializeComponent();
            LoadKho();
        }

        void LoadKho()
        {
            dtgvKho.DataSource = listKho;
            listKho.DataSource = KhoDAO.Instance.GetListKho();
        }
    }
}
