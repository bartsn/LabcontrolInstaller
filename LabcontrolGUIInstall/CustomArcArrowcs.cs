using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows;

namespace WindowsFormsApp1
{
    public partial class CustomArcArrowcs : System.Windows.Forms.Button
    {
        private int startAngle1;
        private int endAngle1;
     
        private int swapVal;
        public CustomArcArrowcs()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            pe.Graphics.Clear(BackColor);
            //pe.Graphics.TranslateTransform(75F, -45.0F);
            //pe.Graphics.RotateTransform(rotateAngle);
            Pen pen1 = new Pen(Color.FromArgb(255, 0, 0, 255), 4);
            Pen pen2 = new Pen(Color.FromArgb(255, 0, 0, 255), 4);
            pen1.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            pen2.StartCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;

            Rectangle rect = ClientRectangle;
            //rect.Width = rect.Width - 2*Padding.Left;
            //rect.Height = rect.Height - 2*this.Padding.Top;
            Padding marge  = this.Padding;
            int radius = (Math.Min(rect.Width, rect.Height) / 2) ;
            //pe.Graphics.DrawArc(pen, rect.X+10, rect.Y+10, rect.Width-20, rect.Height-20, 
            //    startAngle, endAngle);
            if (this.swapVal == 0)
            {
                pe.Graphics.DrawLine(pen1, rect.X, rect.Y + Padding.Top + 1,
                                    rect.Width / 2 - (Padding.Right + Padding.Left), rect.Y + Padding.Top + 1);
                pe.Graphics.DrawArc(pen1, rect.X, rect.Y + Padding.Top, rect.Width - radius / 2,
                                    rect.Height - (Padding.Top + Padding.Bottom),
                    startAngle - 90, endAngle);
                pe.Graphics.DrawLine(pen2, rect.X, rect.Y + rect.Height - this.Padding.Bottom,
                                    rect.Width / 2 - (Padding.Right + Padding.Left),
                                    rect.Y + rect.Height - this.Padding.Bottom);
            }
            else {
                pe.Graphics.DrawLine(pen2, rect.X+rect.Width / 2 - (Padding.Right + Padding.Left), 
                                     rect.Y + Padding.Top + 1,
                                        rect.X + rect.Width - (Padding.Right + Padding.Left), 
                                        rect.Y + Padding.Top + 1);
                pe.Graphics.DrawArc(pen2, rect.X+ Padding.Right , 
                                    rect.Y + Padding.Top, 
                                    rect.Width + Padding.Right - radius / 2,
                                    rect.Height - (Padding.Top + Padding.Bottom)
                     , startAngle + 90, endAngle);
                pe.Graphics.DrawLine(pen1, rect.X + rect.Width / 2 - (Padding.Right + Padding.Left),
                                    rect.Y + rect.Height - this.Padding.Bottom,
                                    rect.X + rect.Width - (Padding.Right + Padding.Left), 
                                    rect.Y + rect.Height - this.Padding.Bottom);
            }
            //pe.Graphics.DrawArc(pen, rect.X + (this.Padding.Left), rect.Y + this.Padding.Top, rect.Width - 2 * Padding.Left, rect.Height - 2 * this.Padding.Top,
            //    startAngle - 91, endAngle - 89);
        }


        //[Description("The startangle of the arc"), Category("Appearance")]
        //[System.ComponentModel.Category("startAngle"),
        //System.ComponentModel.Description("Specifies the start angle."),
        //System.ComponentModel.DefaultValue(0)]
        public int endAngle { get => endAngle1; set => endAngle1 = value; }
        //[System.ComponentModel.Category("endAngle"),
        //System.ComponentModel.Description("Specifies the end angle."),
        //System.ComponentModel.DefaultValue(180)]
        
        public int startAngle { get => startAngle1; set => startAngle1 = value; }
        public int swappen { get => swapVal; set => swapVal = value; }
    }
}
