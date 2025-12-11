using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void checkBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(BackColor);
            Point pt = new Point(e.ClipRectangle.Left + 2, e.ClipRectangle.Top + 4);
            Rectangle rect = new Rectangle(pt, new Size(42, 42));
            if (checkBox1.Checked)
            {
                using (Font wing = new Font("Wingdings", 40f))
                    e.Graphics.DrawString("ü", wing, Brushes.Green, rect);
            }
            //e.Graphics.DrawRectangle(Pens.DarkSlateBlue, rect);
        }
    }
}
