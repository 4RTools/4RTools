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
            _4RTextBox.BackColor = ProfileSingleton.GetCurrent().Theme.Controls.TextInputBackColor;
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

                if (!_4RTextBox.Focused)
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
            if (_4RTextBox.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                _4RTextBox.Multiline = true;
                _4RTextBox.MinimumSize = new Size(0, txtHeight);
                _4RTextBox.Multiline = false;

                this.Height = _4RTextBox.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        [Category("4R Custom Components")]
        public override Color ForeColor
        {
            get => base.ForeColor; 
            set
            {
                base.ForeColor = value;
                _4RTextBox.ForeColor = value;
            }
        }

        [Category("4R Custom Components")]
        public string InputName
        {
            get => base.Name;
            set {
                base.Name = value;
                _4RTextBox.Name = value;
            }
        }

        [Category("4R Custom Components")]
        public override Font Font
        {
            get => base.Font; 
            set
            {
                base.Font = value;
                _4RTextBox.Font = value;
            }
        }


        [Category("4R Custom Components")]
        public string Value
        {
            get => _4RTextBox.Text; 
            set
            {
                _4RTextBox.Text = value;
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
                        _4RTextBox.Text = Key.None.ToString();
                        break;
                    default:
                        _4RTextBox.Text = e.KeyCode.ToString();
                        break;
                }
                _4RTextBox.Enabled = false;
                _4RTextBox.Enabled = true;
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
