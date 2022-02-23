using System;
using _4RTools.Model;
using System.Windows.Forms;

namespace _4RTools.Forms
{
    public partial class ProfileForm: Form
    {
        private Container container;
        public ProfileForm(Container container)
        {
            InitializeComponent();
            this.container = container;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            new Profile(this.txtProfileName.Text).Save();
            this.container.refreshProfileList();
        }

        private void btnRemoveProfile_Click(object sender, EventArgs e)
        {
            Profile.RemoveProfile(this.container.profileCB.SelectedItem.ToString());
            this.container.profileCB.Items.RemoveAt(this.container.profileCB.SelectedIndex);
            this.container.refreshProfileList();
        }
    }
}
