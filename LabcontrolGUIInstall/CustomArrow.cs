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
        private int swapVal;
        public CustomArrow()
        {
            InitializeComponent(); 
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            
            base.OnPaint(pe);
            pe.Graphics.Clear(BackColor);
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 4);
            if (this.swapVal != 0)
                pen.StartCap = LineCap.ArrowAnchor;
            else
                pen.EndCap = LineCap.ArrowAnchor;
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
        public int swappen { get => swapVal; set => swapVal = value; }
    }
}
