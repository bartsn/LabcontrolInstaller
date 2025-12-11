using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CustomArrow : Button
    {
        public CustomArrow()
        {
            InitializeComponent(); 
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.Clear(BackColor);
            base.OnPaint(pe);

            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 8);
            pen.StartCap = LineCap.ArrowAnchor;
            //pen.EndCap = LineCap.RoundAnchor;
            Rectangle rect = ClientRectangle;
            
            pe.Graphics.DrawLine(pen, rect.X, rect.Y + rect.Height/2, rect.X+rect.Width, rect.Y + rect.Height / 2);
        }
        protected override void OnClick(EventArgs e)
        {
       
            Invalidate();

            // Call the base method to invoke the Click event
            base.OnClick(e);
        }
    }
}
