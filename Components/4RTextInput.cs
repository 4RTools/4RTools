using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using _4RTools.Model;

namespace _4RTools.Components
{
    [DefaultEvent("_TextChanged")]
    public partial class _4RTextInput : UserControl
    {

        private Color borderColor = ProfileSingleton.GetCurrent().Theme.Controls.TextInputBorderColor;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = ProfileSingleton.GetCurrent().Theme.Controls.TextInputFocusBorderColor;


        public _4RTextInput()
        {
            InitializeComponent();
            textBox1.BackColor = ProfileSingleton.GetCurrent().Theme.Controls.TextInputBackColor;
        }

        //Events
        public event EventHandler _TextChanged;


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw Border;
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!textBox1.Focused)
                {
                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                }

               
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        [Category("4R Custom Components")]
        public override Color ForeColor
        {
            get => base.ForeColor; 
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        [Category("4R Custom Components")]
        public override Font Font
        {
            get => base.Font; 
            set
            {
                base.Font = value;
                textBox1.Font = value;
            }
        }

        [Category("4R Custom Components")]
        public string Value
        {
            get => textBox1.Text; 
            set
            {
                textBox1.Text = value;
            }
        }

        public int BorderSize { get => borderSize; set {
                borderSize = value;
                this.Invalidate();
            } }
        [Category("4R Custom Components")]
        public bool UnderlinedStyle { get => underlinedStyle; set {
                underlinedStyle = value;
                this.Invalidate();
        } }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(_TextChanged != null)
            {
                _TextChanged.Invoke(sender, e);
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            this.OnClick(e);
        }

        private void textBox1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            this.OnMouseDown(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                Key thisk = (Key)Enum.Parse(typeof(Key), e.KeyCode.ToString());

                switch (thisk)
                {
                    case Key.Escape:
                    case Key.Back:
                        textBox1.Text = Key.None.ToString();
                        break;
                    default:
                        textBox1.Text = e.KeyCode.ToString();
                        break;
                }
                textBox1.Enabled = false;
                textBox1.Enabled = true;
                this.Invalidate();
                e.Handled = true;
            }
            catch { }
        }


        private void textBox1_Enter(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            this.Invalidate();
        }
    }
}
