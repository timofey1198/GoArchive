using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SgfReader
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            int size = Settings1.Default.BoardSize;
            this.points = new Punct[size, size];
            this.SuspendLayout();
            // 
            // points
            //
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    points[i, j] = new Punct(i, j);
                    points[i, j].Click += new EventHandler(points[i, j].Punct_Click);
                }
            }

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    this.Controls.Add(points[i, j]);
                }
            }
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Punct[,] points;
    }
}

