using System.Drawing;
using System.Windows.Forms;
using _4RTools.Model;

namespace _4RTools.Components
{
    public partial class _4RPanel : UserControl
    {


        public _4RPanel()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (SolidBrush brush = new SolidBrush(BackColor))
            using(Pen pen = new Pen(ProfileSingleton.GetCurrent().Theme.Panels.BorderColor))
            {
                e.Graphics.FillRectangle(brush, ClientRectangle);
                e.Graphics.DrawRectangle(pen, 1, 1, ClientSize.Width - 2, ClientSize.Height - 2);
            }
                
        }
    }
}
