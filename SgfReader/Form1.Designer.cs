using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

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
            this.button_Next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Next
            // 
            this.button_Next.Location = new System.Drawing.Point(44, 13);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(75, 23);
            this.button_Next.TabIndex = 0;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = true;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
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
            this.ClientSize = new System.Drawing.Size(size*40, size*35 + 30);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    this.Controls.Add(points[i, j]);
                }
            }
            this.Controls.Add(button_Next);
            this.Name = "Form1";
            this.ResumeLayout(false);
        }

        #endregion
        private Punct[,] points;
        private Button button_Next;
        private Game g = new Game("E://1.sgf");
    }
}

