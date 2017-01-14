using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace SgfReader
{
    public class Chart : Control
    {
        [DefaultValue(20)]
        public int Indent { get; set; }

        [DefaultValue(20)]
        public int Step { get; set; }

        public Chart()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.UserPaint, true);
            Step = 20;
            Indent = 20;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var rect = ClientRectangle;
            rect.Inflate(-Indent, -Indent);
            var step = Step;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //рисуем сетку
            using (var font = new Font(Font.FontFamily, 8f))
            using (var pen = new Pen(Color.FromArgb(50, Color.Navy), 1))
            {
                int i = 0;

                for (float x = rect.Left; x <= rect.Right; x += step)
                {
                    e.Graphics.DrawLine(pen, x, rect.Bottom, x, rect.Top);
                    e.Graphics.DrawString(i.ToString(), font, Brushes.Navy, x - 5, rect.Bottom + 5);
                    i++;
                }

                i = 0;
                for (float y = rect.Bottom; y >= rect.Top; y -= step)
                {
                    e.Graphics.DrawLine(pen, rect.Left, y, rect.Right + 5, y);
                    e.Graphics.DrawString(i.ToString(), font, Brushes.Navy, rect.Left - 15, y - 5);
                    i++;
                }
            }

            //рисуем оси
            using (Pen pen = new Pen(Color.Navy, 1))
            {
                pen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
                e.Graphics.DrawLine(pen, rect.Left, rect.Bottom, rect.Left, rect.Top - 10);
                e.Graphics.DrawLine(pen, rect.Left, rect.Bottom, rect.Right + 7, rect.Bottom);
            }
        }
    }
}