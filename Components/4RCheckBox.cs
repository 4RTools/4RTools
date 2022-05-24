using System;
using System.Drawing;
using System.Windows.Forms;

namespace _4RTools.Components
{
    public partial class _4RCheckBox : CheckBox
    {
        public _4RCheckBox()
        {
            InitializeComponent();
            this.ForeColor = Color.FromArgb(252,220, 202);
            this.AutoSize = false;
        }
        private int boxsize = 18;
        private int boxlocatx = 0;
        private int boxlocaty = 0;
        private int textX = 14;
        private int textY = 4;
        private String text = "";

        public String DisplayText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }


        public int TextLocation_X
        {
            get { return textX; }
            set { textX = value; Invalidate(); }
        }
        public int TextLocation_Y
        {
            get { return textY; }
            set { textY = value; Invalidate(); }
        }
        public int BoxSize
        {
            get { return boxsize; }
            set { boxsize = value; Invalidate(); }
        }
        public int BoxLocation_X
        {
            get { return boxlocatx; }
            set { boxlocatx = value; Invalidate(); }
        }
        public int BoxLocation_Y
        {
            get { return boxlocaty; }
            set { boxlocaty = value; Invalidate(); }
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.AutoSize = false;
            text = this.Text;
            if (textX == 100 && textY == 25)
            {
                textX = ((this.Width) / 3) + 10;
                textY = (this.Height / 2) - 1;
            }
            //drawing string & filling gradient rectangle

            Point p = new Point(textX, textY);
            SolidBrush frcolor = new SolidBrush(this.ForeColor);
            SolidBrush frcolor2 = new SolidBrush(Color.FromArgb(91,55,21));
            SolidBrush frcolor3 = new SolidBrush(Color.FromArgb(239,181,97));
            e.Graphics.DrawString(text, this.Font, frcolor, p);
            Rectangle rc = new Rectangle(boxlocatx, boxlocaty, boxsize, boxsize);
            //drawing check box

            if(this.CheckState == CheckState.Indeterminate)
            {
                e.Graphics.FillRectangle(frcolor3, ClientRectangle);
            }
            else if(this.CheckState == CheckState.Checked)
            {
                e.Graphics.FillRectangle(frcolor2, ClientRectangle);
            }
            else
            {
                e.Graphics.FillRectangle(frcolor, ClientRectangle);
            }

            ControlPaint.DrawCheckBox(e.Graphics, rc, this.Checked ? ButtonState.Checked : ButtonState.Normal);
        }
    }
}
