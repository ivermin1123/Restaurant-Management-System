using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanBeer.DAO;

namespace QuanLyQuanBeer.USC
{
    public partial class USCLoaiKM : UserControl
    {
        BindingSource listKM = new BindingSource();
        public USCLoaiKM()
        {
            InitializeComponent();
            LoadKM();
        }

        void LoadKM()
        {
            dtgvLoaiKM.DataSource = listKM;
            listKM.DataSource = LoaiKhuyenMaiDAO.Instance.GetListLoaiSP();
            dtgvLoaiKM.Columns[0].HeaderText = "ID";
            dtgvLoaiKM.Columns[1].HeaderText = "Loại khuyến mại";
        }

    }
}
