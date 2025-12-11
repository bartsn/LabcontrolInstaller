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
    public partial class CustomControl1 : Button
    {
        private int _counter = 0;
        public CustomControl1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {

            // Draw the control
            base.OnPaint(pe);

            // Paint our string on top of it
            pe.Graphics.DrawString($"Clicked {_counter} times", Font, Brushes.Purple, new PointF(3, 3));
        }
        protected override void OnClick(EventArgs e)
        {
            // Increase the counter and redraw the control
            _counter++;
            Invalidate();

            // Call the base method to invoke the Click event
            base.OnClick(e);
        }
    }
}
