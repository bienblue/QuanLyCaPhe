using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Styles
{
    public class DataRowStyle<TModel> : UserControl
    {
        public TModel model;
        public EllipseButtonStyle editButton = new EllipseButtonStyle()
        {
            Width = 35,
            Height = 35,
            BackgroundImage = Properties.Resources.icons8_support_100,
            BackgroundImageLayout = ImageLayout.Stretch,
            BackColor = Color.RosyBrown
        };
        public EllipseButtonStyle removeButton = new EllipseButtonStyle()
        {
            Width = 35,
            Height = 35,
            BackgroundImage = Properties.Resources.icons8_trash_100,
            BackgroundImageLayout = ImageLayout.Stretch,
            BackColor = Color.RosyBrown
        };
        public DataRowStyle()
        {
            Height = 35;
        }
        public DataRowStyle(TModel model, int[] wSize, bool isEdit) : this()
        {
            this.model = model;
            var properties = typeof(TModel).GetProperties();
            var length = properties.Length;
            //Width = (length + 1) * 120;
            Width = 0;
            for(int i = 0, j = 0; i < length; i++)
            {
                if (properties[i].PropertyType == typeof(string)
                    || properties[i].PropertyType == typeof(DateTime)
                    || properties[i].PropertyType == typeof(int))
                {
                    string text;
                    if(properties[i].PropertyType == typeof(DateTime))
                        text = (properties[i].GetValue(model) as DateTime?).Value.ToString("dd/MM/yyyy");
                    else
                        text = properties[i].GetValue(model).ToString();
                    var lbl = NewLabel(text, wSize[j]);
                    lbl.Location = new Point(Width, 0);
                    Width += wSize[j];
                    Controls.Add(lbl);
                    j++;
                }
            }
            if (!isEdit)
                return;
            editButton.Location = new Point(Width, 0);
            removeButton.Location = new Point(Width+ 35, 0);
            Width += 70;
            Controls.Add(editButton);
            Controls.Add(removeButton);
        }
        public DataRowStyle(List<string> list, int[] wSize) : this()
        {
            Width = 0;
            for (int i = 0; i < list.Count; i++)
            {
                var lbl = new Label();
                lbl = NewLabel(list[i], wSize[i]);
                lbl.Location = new Point(Width, 0);
                Width += wSize[i];
                Controls.Add(lbl);
            }
        }
        Label NewLabel(string text, int w)
        {
            return new Label()
            {
                Text = text,
                AutoSize = false,
                TextAlign = ContentAlignment.MiddleLeft,
                Width = w,
                Height = 35,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 14), 
                ForeColor = Color.Black
            };
        }
    }
    public class DataTableStyle<TModel> : UserControl
    {
        //public List<TModel> models = new List<TModel>();
        //public List<string> headers = new List<string>();
        int[] wSize;
        public List<DataRowStyle<TModel>> rowStyles = new List<DataRowStyle<TModel>>();
        Panel pnlContainHeader, pnlHeader, pnlData;
        public DataTableStyle()
        {
            Dock = DockStyle.Fill;
            pnlContainHeader = new Panel()
            {
                Height = 35,
                Dock = DockStyle.Top,
                BackColor = Color.FromArgb(153, 180, 209)
            };
            pnlHeader = new Panel()
            {
                Height = 35,
                AutoSize = true,
                Location = new Point(0, 0)
            };
            pnlData = new Panel()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.White
            };
            pnlContainHeader.Controls.Add(pnlHeader);
            Controls.Add(pnlData);
            pnlData.Dock = DockStyle.Fill;
            Controls.Add(pnlContainHeader);

            pnlData.Scroll += new ScrollEventHandler(delegate
            {
                pnlHeader.Location = new Point(pnlData.AutoScrollPosition.X, 0);
            });
        }
        public DataTableStyle(List<string> headers, List<TModel> models, bool isEdit) : this()
        {
            wSize = new int[headers.Count];
            for(int i = 0; i < headers.Count; i++)
            {
                var s = TextRenderer.MeasureText(headers[i], new Font("Segoe UI", 14)).Width + 10;
                wSize[i] = Math.Max(wSize[i], s);
            }
            var properties = typeof(TModel).GetProperties();
            foreach (var model in models)
            {                
                for (int i = 0, j = 0; i < properties.Length; i++)
                {
                    if (properties[i].PropertyType == typeof(string)
                        || properties[i].PropertyType == typeof(DateTime)
                        || properties[i].PropertyType == typeof(int))
                    {
                        string text;
                        if (properties[i].PropertyType == typeof(DateTime))
                            text = (properties[i].GetValue(model) as DateTime?).Value.ToString("dd/MM/yyyy");
                        else
                            text = properties[i].GetValue(model).ToString();
                        var s = TextRenderer.MeasureText(text, new Font("Segoe UI", 14)).Width + 10;
                        wSize[i] = Math.Max(wSize[j], s);
                        j++;
                    }
                }
            }
            for (int i = 0; i < models.Count; i++)
            {
                var row = new DataRowStyle<TModel>(models[i], wSize, isEdit) { Location = new Point(0, 35 * i) };
                pnlData.Controls.Add(row);
                rowStyles.Add(row);
            }
            pnlHeader.Controls.Add(new DataRowStyle<TModel>(headers, wSize));
        }
    }
}
