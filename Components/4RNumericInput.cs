using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4RTools.Components
{
    public partial class _4RNumericInput : NumericUpDown
    {
        private Color borderColor = Color.Blue;
        [DefaultValue(typeof(Color), "0,0,255")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                if (borderColor != value)
                {
                    borderColor = value;
                    Invalidate();
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (BorderStyle != BorderStyle.None)
            {
                using (var pen = new Pen(BorderColor, 3))
                    e.Graphics.DrawRectangle(pen,
                        ClientRectangle.Left, ClientRectangle.Top,
                        ClientRectangle.Width - 1, ClientRectangle.Height - 1);
            }
        }

        public _4RNumericInput()
        {
            InitializeComponent();
        }
    }
}
