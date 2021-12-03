using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Styles
{
    public class TabHeaderStyle : Control
    {
        public EllipseButtonStyle btnCloseTab { get; set; }
        public Label lblTitle { get; set; }
        public TabHeaderStyle()
        {
            Width = 150;
            Height = 25;
            BackColor = Color.FromArgb(187, 128, 130);
            btnCloseTab = new EllipseButtonStyle()
            {
                FlatStyle = FlatStyle.Flat,
                Width = Height = 25,
                BackgroundImage = Properties.Resources.icons8_cancel_64,
                BackgroundImageLayout = ImageLayout.Stretch,
                Dock = DockStyle.Right,
            };
            lblTitle = new Label()
            {
                Font = new Font("Segoe UI", 12),
                ForeColor = Color.White,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Dock = DockStyle.Fill
            };
            Controls.Add(lblTitle);
            Controls.Add(btnCloseTab);
        }
        public TabHeaderStyle(string title) : this()
        {
            lblTitle.Text = title;
        }
    }
}
