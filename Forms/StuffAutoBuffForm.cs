using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using _4RTools.FormContainers;

namespace _4RTools.Forms
{
    public partial class StuffAutoBuffForm : Form
    {
        public StuffAutoBuffForm(Subject subject)
        {
            InitializeComponent();
            new AutobuffContainer(this, subject).StartConfiguration();
            this.BackColor = ProfileSingleton.GetCurrent().Theme.Panels.BackgroundColor;
        }
    }
}
