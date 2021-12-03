using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Styles
{
    public class EllipsePictureStyle : PictureBox
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            Region = new System.Drawing.Region(graphics);
            base.OnPaint(pevent);
        }
        public EllipsePictureStyle()
        {
            BackgroundImage = Properties.Resources.avatar;
            BackgroundImageLayout = ImageLayout.Stretch;            
        }
    }
}
