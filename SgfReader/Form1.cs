using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SgfReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Punct_Click(object sender, EventArgs e)
        {
            this.Text = "123";
        }

        private void button_Next_Click(object sender, EventArgs e)
        {
            int move = ++this.g.Move;
            if (this.g.GameTree.Keys.Max() >= move)
            {
                int x;
                int y;
                x = this.g.GameTree[move][0];
                y = this.g.GameTree[move][1];
                int i = x - 1;
                int j = y - 1;
                this.points[i, j].Enabled = true;
                this.points[i, j].PerformClick();
                this.points[i, j].Enabled = false;
                this.Text = "---" + i + j;
            }
        }
    }
}
