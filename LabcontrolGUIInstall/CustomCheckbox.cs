using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    internal class CustomCheckbox : System.Windows.Forms.CheckBox
    {
        private Color ccol = Color.Green;
        public CustomCheckbox()
        {
            //Appearance = System.Windows.Forms.Appearance.Button;
            FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            TextAlign = ContentAlignment.MiddleRight;
            FlatAppearance.BorderSize = 0;
            AutoSize = false;
            Height = 16;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.custombox_Paint);
        }
        private void custombox_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 255), 8);
            pen.StartCap = LineCap.ArrowAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            e.Graphics.DrawLine(pen, 20, 175, 300, 175);
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            //base.OnPaint(pevent);

            pevent.Graphics.Clear(BackColor);

            using (SolidBrush brush = new SolidBrush(ForeColor))
                pevent.Graphics.DrawString(Text, Font, brush, 27, 4);

            Point pt = new Point(4, 4);
            Rectangle rect = new Rectangle(pt, new Size(16, 16));

            pevent.Graphics.FillRectangle(Brushes.Beige, rect);

            if (Checked)
            {
                using (SolidBrush brush = new SolidBrush(ccol))
                using (Font wing = new Font("Wingdings", 12f))
                    pevent.Graphics.DrawString("ü", wing, brush, 1, 2);
            }
            pevent.Graphics.DrawRectangle(Pens.DarkSlateBlue, rect);

            Rectangle fRect = ClientRectangle;

            if (Focused)
            {
                fRect.Inflate(-1, -1);
                using (Pen pen = new Pen(Brushes.Gray) { DashStyle = DashStyle.Dot })
                    pevent.Graphics.DrawRectangle(pen, fRect);
            }
        }
    }
}
/*
 * Onderstaande heb ik gejat van:
 * https://stackoverflow.com/questions/35252382/how-can-i-change-the-color-of-the-check-mark-of-a-checkbox/35252891
 * En de volgende link is ook interessant:
 * https://cowthulu.com/c-winforms-arbitrarily-large-checkbox/
 */
/*
public class ExpandableCheckBox : System.Windows.Forms.CheckBox
{
    public ExpandableCheckBox()
    {
        SetStyle(ControlStyles.UserPaint, true);
        SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        SetStyle(ControlStyles.ResizeRedraw, true);
    }
    private void checkBox1_Paint(object sender, PaintEventArgs e)
    {
        Point pt = new Point(e.ClipRectangle.Left + 2, e.ClipRectangle.Top + 4);
        Rectangle rect = new Rectangle(pt, new Size(22, 22));
        if (this.Checked)
        {
            using (Font wing = new Font("Wingdings", 14f))
                e.Graphics.DrawString("ü", wing, Brushes.DarkOrange, rect);
        }
        e.Graphics.DrawRectangle(Pens.DarkSlateBlue, rect);
    }

}
*/