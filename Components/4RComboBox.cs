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

namespace _4RTools.Components
{
    [DefaultEvent("SelectedIndexChanged")]
    public partial class _4RComboBox : UserControl
    {
        private Color backColor = Color.FromArgb(252, 220, 202);
        private Color iconColor = Color.FromArgb(91, 55, 21);
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.FromArgb(91, 55, 21);
        private int borderSize = 1;



        //Items
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        [Category("4R ComboBox")]
        public new Color BackColor
        {
            get => backColor; 
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }
        [Category("4R ComboBox")]
        public Color IconColor
        {
            get => iconColor; 
            set
            {
                iconColor = value;
                btnIcon.Invalidate(); //Redraw Icon
            }
        }
        [Category("4R ComboBox")]
        public Color ListBackColor
        {
            get => listBackColor; 
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }
        [Category("4R ComboBox")]
        public Color ListTextColor
        {
            get => listTextColor; 
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }
        [Category("4R ComboBox")]
        public Color BorderColor
        {
            get => borderColor; 
            set
            {
                borderColor = value;
                base.BackColor = borderColor;
            }
        }
        [Category("4R ComboBox")]
        public int BorderSize
        {
            get => borderSize; 
            set
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjusteComboBoxDimensions();
            }
        }
        [Category("4R ComboBox")]
        public override Color ForeColor
        {
            get => base.ForeColor; 
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }
        [Category("4R ComboBox")]
        public override Font Font
        {
            get => base.Font; 
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;
            }
        }
        [Category("4R ComboBox")]
        public string Texts
        {
            get => lblText.Text; set => lblText.Text = value;
        }
        [Category("4R ComboBox")]
        public ComboBoxStyle DropDownStyle
        {
            get => cmbList.DropDownStyle; 
            set
            {
                if(cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        //Data
        [Category("4R ComboBox")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items { get => cmbList.Items; }

        [Category("4R ComboBox")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        [RefreshProperties(RefreshProperties.Repaint)]
        public object DataSource { get => cmbList.DataSource; set => cmbList.DataSource = value; }

        [Category("4R ComboBox")]
        [Browsable(false)]
        [Bindable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem { get => cmbList.SelectedItem; set => cmbList.SelectedItem = value; }

        [Category("4R ComboBox")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex { get => cmbList.SelectedIndex; set => cmbList.SelectedIndex =  value; }

        //Events
        public event EventHandler OnSelectedIndexChanged;

        public _4RComboBox()
        {
            InitializeComponent();
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            this.SuspendLayout();

            //Dropdown List
            cmbList.BackColor = ListBackColor;
            cmbList.Font = new Font(this.Font.Name, 10f);
            cmbList.ForeColor = ListTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged); //Default Event
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged); //To Refresh Text

            //Button Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = BackColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click); //OPen Dropdown List;
            btnIcon.Paint += new PaintEventHandler(Icon_Paint); //Draw Icon


            //Label Text
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = BackColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            lblText.Click += new EventHandler(Surface_Click);
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseEnter += new EventHandler(Surface_MouseLeave);


            //User Control
            this.Controls.Add(lblText);
            this.Controls.Add(btnIcon);
            this.Controls.Add(cmbList);
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(180, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(BorderSize);
            base.BackColor = BorderColor;
            this.ResumeLayout();
            AdjusteComboBoxDimensions();

        }


        private void AdjusteComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            //Select Combo box
            this.OnClick(e);
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Field
            int iconWidth = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidth) / 2, (btnIcon.Height - iconHeight) / 2, iconWidth, iconHeight);
            Graphics graph = e.Graphics;

            //Draw arrow icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(IconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidth / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidth / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            cmbList.Select();
            cmbList.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Refresh Text
            lblText.Text = cmbList.Text;
        }

        // Default Event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);

            //Refresh Text
            lblText.Text = cmbList.Text;
        }


        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
        }
    }
}
