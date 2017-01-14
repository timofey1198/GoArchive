using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SgfReader
{
    class Punct:Button
    {
        public Punct(int i, int j)
        {
            int x = i + 1;
            int y = Settings1.Default.BoardSize - j;
            X = x;
            Y = y;
            int size = Settings1.Default.BoardSize;

            if (x == 1)
            {
                if (y == 1)
                    this.BackgroundImage = global::SgfReader.Properties.Resources.point_down_left;
                if (y == size)
                    this.BackgroundImage = global::SgfReader.Properties.Resources.point_up_left;
                if (y > 1 && y < size)
                    this.BackgroundImage = global::SgfReader.Properties.Resources.point_left;
            }
            if (x == size)
            {
                if (y == 1)
                    this.BackgroundImage = global::SgfReader.Properties.Resources.point_down_right;
                if (y == size)
                    this.BackgroundImage = global::SgfReader.Properties.Resources.point_up_right;
                if (y > 1 && y < size)
                    this.BackgroundImage = global::SgfReader.Properties.Resources.point_right;
            }
            if (x > 1 && x < size)
            {
                if (y == 1)
                    this.BackgroundImage = global::SgfReader.Properties.Resources.point_down;
                if (y == size)
                    this.BackgroundImage = global::SgfReader.Properties.Resources.point_up;
                if (y > 1 && y < size)
                    this.BackgroundImage = global::SgfReader.Properties.Resources.point;
            }

            this.BackgroundImageLayout = ImageLayout.Center;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Location = new Point(Settings1.Default.BoardStartX + i*31, Settings1.Default.BoardStartY + j*31);
            this.Margin = new Padding(0);
            this.Name = "point";
            this.Size = new Size(31, 31);
            this.TabIndex = i + j*size;
            this.UseVisualStyleBackColor = true;
        }

        public int X { get; }
        public int Y { get; }

        public void Punct_Click(object sender, EventArgs e)
        {
            int size = Settings1.Default.BoardSize;
            int x = X;
            int y = Y;

            if (Settings1.Default.Move % 2 == 0)
            {
                if (x == 1)
                {
                    if (y == 1)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_down_left_b;
                    if (y == size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_up_left_b;
                    if (y > 1 && y < size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_left_b;
                }
                if (x == size)
                {
                    if (y == 1)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_down_right_b;
                    if (y == size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_up_right_b;
                    if (y > 1 && y < size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_right_b;
                }
                if (x > 1 && x < size)
                {
                    if (y == 1)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_down_b;
                    if (y == size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_up_b;
                    if (y > 1 && y < size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_b;
                }
            }
            else
            {
                if (x == 1)
                {
                    if (y == 1)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_down_left_w;
                    if (y == size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_up_left_w;
                    if (y > 1 && y < size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_left_w;
                }
                if (x == size)
                {
                    if (y == 1)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_down_right_w;
                    if (y == size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_up_right_w;
                    if (y > 1 && y < size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_right_w;
                }
                if (x > 1 && x < size)
                {
                    if (y == 1)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_down_w;
                    if (y == size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_up_w;
                    if (y > 1 && y < size)
                        this.BackgroundImage = global::SgfReader.Properties.Resources.point_w;
                }
            }
            Settings1.Default.Move++;
        }
    }
}
