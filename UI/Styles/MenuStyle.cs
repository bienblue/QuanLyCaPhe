using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Styles
{
    public partial class MenuStyle : UserControl
    {
        public List<MenuRowStyle> menuRowStyles = new List<MenuRowStyle>();
        public List<hanghoa> hanghoas = new List<hanghoa>();
        public MenuStyle()
        {
            InitializeComponent();
        }

        public MenuStyle(List<hanghoa> hanghoas) : this()
        {
            this.hanghoas = hanghoas;
            pnlDrinks.Controls.Clear();
            foreach(var hh in hanghoas)
            {
                var row = new MenuRowStyle();
                row.lblName.Text = hh.ten_hh;
                row.lblPrice.Text = hh.gia_sp.ToString();
                row.Dock = DockStyle.Top;
                menuRowStyles.Add(row);
                pnlDrinks.Controls.Add(row);
            }
        }

        private void btnType_Click(object sender, EventArgs e)
        {
            pnlDrinks.Visible = !pnlDrinks.Visible;
        }
    }
}
