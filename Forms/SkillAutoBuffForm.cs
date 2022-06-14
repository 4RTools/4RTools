using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.FormContainers;
using _4RTools.Model;

namespace _4RTools.Forms
{
    public partial class SkillAutoBuffForm : Form
    {
        public SkillAutoBuffForm(Subject subject)
        {
            InitializeComponent();
            new AutobuffContainer(this, subject).StartConfiguration();
            this.BackColor = ProfileSingleton.GetCurrent().Theme.Panels.BackgroundColor;
        }
    }
}
