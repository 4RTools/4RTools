using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _4RTools.Forms;
using _4RTools.Model;
using _4RTools.Utils;

namespace _4RTools.FormContainers
{
    public partial class AutopotContainer : Form
    {
        public AutopotContainer(Subject subject)
        {
            InitializeComponent();
            AttachFormToPanel(new AutopotForm(subject, ProfileSingleton.GetCurrent().Autopot), panelAutopot);
            AttachFormToPanel(new AutopotForm(subject, ProfileSingleton.GetCurrent().AutopotYgg), panelAutopotYgg);
            AttachFormToPanel(new StatusEffectForm(subject), panelStatus);
        }

        private void AttachFormToPanel(Form f, Panel p)
        {
            Form childForm = f;
            p.Controls.Clear();
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            p.Controls.Add(childForm);
            p.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelAutopotYgg_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
