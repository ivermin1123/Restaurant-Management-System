using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyQuanBeer.DTO;
using QuanLyQuanBeer.DAO;

namespace QuanLyQuanBeer
{
    public partial class SoDo : UserControl
    {
        public SoDo()
        {
            InitializeComponent();
            LoadTable();
        }

        private void flpBan_Paint(object sender, PaintEventArgs e)
        {

        }
        void LoadTable()
        {
            List<Ban> tableList = BanDAO.Instance.LoadDsBan();
            foreach (Ban item in tableList)
            {
                btTang1.BackColor = Color.White;
                Button btn = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight, Image = Image.FromFile(@"D:\C#\Icon\banchuaxoabg1.jpg") };
                btn.Text = item.TenBan ;
                btn.ForeColor = Color.Black;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                /*switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.FromArgb(9, 115, 185); 
                        break;
                    default:
                        btn.BackColor = Color.FromArgb(128, 128, 128);
                        break;
                }*/
                flpBan.Controls.Add(btn);
            }
        }
    }
}
