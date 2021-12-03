using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Styles
{
    public class NavItemStyle : Control
    {
        public RoundBorderButtonStyle btnItem { get; set; }
        public NavItemStyle()
        {
            Dock = DockStyle.Top;
            Width = 300;
            Height = 50;
            btnItem = new RoundBorderButtonStyle()
            {
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 20),
                TextColor = Color.White,
                BorderColor = Color.White,
                BorderSize = 2,
                BackgroundColor = Color.Transparent,
                FlatStyle = FlatStyle.Popup
            };
            Controls.Add(btnItem);
        }
        public NavItemStyle(string display) : this()
        {
            btnItem.Text = display;
        }
    }
}
