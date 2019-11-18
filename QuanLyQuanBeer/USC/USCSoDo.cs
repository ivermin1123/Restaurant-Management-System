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
                Button btn = new Button() { Width = BanDAO.TableWidth, Height = BanDAO.TableHeight
                    //, BackgroundImage =  Image.FromFile(@"D:\C#\Icon\Bàn có màu.png")
            };
                btn.Text = item.TenBan + Environment.NewLine + item.TrangThai;
                //btn.ForeColor = Color.White;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                switch (item.TrangThai)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.LightGray;
                        break;
                }
                flpBan.Controls.Add(btn);
            }
        }
    }
}
