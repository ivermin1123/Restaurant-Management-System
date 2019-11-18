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

namespace QuanLyQuanBeer
{
    public partial class TaiKhoan : UserControl
    {
        BindingSource accountList = new BindingSource();
        public TaiKhoan()
        {
            InitializeComponent();
            LoadAccount();
        }

        void LoadAccount()
        {
            dtgvTaiKhoan.DataSource = accountList;
            accountList.DataSource = TaiKhoanDAO.Instance.layDSTaiKhoan();
        }

    }
}
