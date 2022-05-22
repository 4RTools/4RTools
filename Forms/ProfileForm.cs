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

            foreach (string profile in Profile.ListAll())
            {
                if (profile != "Default") { this.lbProfilesList.Items.Add(profile); };
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newProfileName = this.txtProfileName.Text;
            if (string.IsNullOrEmpty(newProfileName)) { return; }

            ProfileSingleton.Create(newProfileName);
            this.lbProfilesList.Items.Add(newProfileName);
            this.container.refreshProfileList();
            this.txtProfileName.Text = ""; // clear text box
        }

        private void btnRemoveProfile_Click(object sender, EventArgs e)
        {
            if (this.lbProfilesList.SelectedItem == null)
            {
                MessageBox.Show("No profile found! To delete a profile, first select an option from the Profile list.");
                return;
            }

            string selectedProfile = this.lbProfilesList.SelectedItem.ToString();
            if (selectedProfile == "Default")
            {
                MessageBox.Show("Cannot delete a Default profile!");
            } else
            {
                ProfileSingleton.Delete(selectedProfile);
                this.lbProfilesList.Items.Remove(selectedProfile);
                this.container.refreshProfileList();
            }
        }
    }
}
