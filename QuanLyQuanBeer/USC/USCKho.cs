using QuanLyQuanBeer.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyQuanBeer.USC
{
    public partial class USCKho : UserControl
    {
        private BindingSource listKho = new BindingSource();

        public USCKho()
        {
            InitializeComponent();
            LoadKho();
        }

        private void LoadKho()
        {
            dtgvKho.DataSource = listKho;
            listKho.DataSource = KhoDAO.Instance.GetListKho();
            dtgvKho.Columns[0].HeaderText = "ID";
            dtgvKho.Columns[0].FillWeight = 25;
            dtgvKho.Columns[1].HeaderText = "Tên sản phẩm";
            dtgvKho.Columns[2].HeaderText = "SL";
            dtgvKho.Columns[3].HeaderText = "Đơn vị";
            dtgvKho.Columns[4].HeaderText = "Giá";
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            fThemSP f = new fThemSP();
            f.ShowDialog();
            LoadKho();
        }
    }
}