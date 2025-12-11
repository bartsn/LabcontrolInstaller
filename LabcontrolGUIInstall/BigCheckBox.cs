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
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class BigCheckBox : System.Windows.Forms.CheckBox
    {
        public BigCheckBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            pe.Graphics.Clear(BackColor);

            using (SolidBrush brush = new SolidBrush(ForeColor))
                pe.Graphics.DrawString(Text, Font, brush, 27, 4);

            //Point pt = new Point(18, 18);
            Point pt = new Point(pe.ClipRectangle.Left + 2, pe.ClipRectangle.Top + 4);
            //Rectangle rect = new Rectangle(pt, new Size(50, 50));
            Rectangle rect = new Rectangle(pt, ClientSize);
            int xmid = rect.Left + rect.Width / 2;
            int ymid = rect.Top + rect.Height / 2;
            //Rectangle rect = ClientRectangle;
            //pe.Graphics.FillRectangle(Brushes.Beige, rect);

            if (this.Checked)
            {
                //using (SolidBrush brush = new SolidBrush(Color.Green))
                //using (Font wing = new Font("Wingdings", 40f))
                FontFamily fontFamily = new FontFamily("Wingdings");
                Font font = new Font(
                   fontFamily,
                   80, FontStyle.Regular,
                   GraphicsUnit.Pixel);
                PointF pointF = new PointF(10, 10);
                SolidBrush solidBrush = new SolidBrush(Color.Green);
                {
                    float afm = font.Size;
                    float ascent = fontFamily.GetCellAscent(FontStyle.Regular);
                    float ascentPixel = font.Size * ascent / fontFamily.GetEmHeight(FontStyle.Regular);
                    float descent = fontFamily.GetCellDescent(FontStyle.Regular);
                    float descentPixel = font.Size * descent / fontFamily.GetEmHeight(FontStyle.Regular);
                    float totalHeight = ascentPixel + descentPixel;
                    ymid = (int)(ymid -(totalHeight / 2));
                    xmid = (int)(xmid - (totalHeight / 2));
                    pe.Graphics.DrawString("ü", font, solidBrush, xmid, ymid);
                }
            }
            //pe.Graphics.DrawRectangle(Pens.DarkSlateBlue, rect);

            //Rectangle fRect = ClientRectangle;
            /*
            if (Focused)
            {
                fRect.Inflate(-1, -1);
                using (Pen pen = new Pen(Brushes.Gray) { DashStyle = DashStyle.Dot })
                    //pevent.Graphics.DrawRectangle(pen, fRect);
                    pe.Graphics.DrawRectangle(pen, rect);
            }
            */
        }
        protected override void OnClick(EventArgs e)
        {
            // Increase the counter and redraw the control
            Invalidate();

            // Call the base method to invoke the Click event
            base.OnClick(e);
        }
    }
}
