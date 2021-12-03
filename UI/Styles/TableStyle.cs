using Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Styles
{
    public class TableStyle : Control
    {
        public RoundBorderButtonStyle btnTable { get; set; }
        public TableStyle()
        {
            Width = 150;
            Height = 150;
            var pnl = new Panel() { Dock = DockStyle.Fill, Padding = new Padding(5) };
            btnTable = new RoundBorderButtonStyle()
            {
                Dock = DockStyle.Fill,
                BackgroundImage = Properties.Resources.icons8_coffee_table_100,
                BackgroundImageLayout = ImageLayout.Stretch,
                FlatStyle = FlatStyle.Popup,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                ForeColor = Color.Black,
                BorderColor = Color.Black,
                BorderSize = 3
            };
            pnl.Controls.Add(btnTable);
            Controls.Add(pnl);
        }
        public TableStyle(ban ban) : this()
        {
            btnTable.Text = ban.ten_ban;
            btnTable.BackColor = (ban.thuoc_tinh == false)
                    ? Color.FromArgb(181, 234, 234) : Color.FromArgb(243, 139, 160);
        }
        public void Switch()
        {
            btnTable.BackColor = (btnTable.BackColor == Color.FromArgb(243, 139, 160))
                    ? Color.FromArgb(181, 234, 234) : Color.FromArgb(243, 139, 160);
        }
    }
}
