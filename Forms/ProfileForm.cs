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
                this.lbProfilesList.Items.Add(profile);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            new Profile(this.txtProfileName.Text).Save();
            this.txtProfileName.Text = "";
            System.Windows.Forms.MessageBox.Show("Cool! Your profile has been created successfully. :)");
            this.container.refreshProfileList();
        }

        private void btnRemoveProfile_Click(object sender, EventArgs e)
        {
            if (this.lbProfilesList.SelectedItem == null)
            {
                System.Windows.Forms.MessageBox.Show("No profile found! To delete a profile, first select an option from the Profile list.");
                return;
            }

            string selectedProfile = this.lbProfilesList.SelectedItem.ToString();
            if (selectedProfile == "Default")
            {
                System.Windows.Forms.MessageBox.Show("Cannot delete a Default profile!");
            } else
            {
                Profile.RemoveProfile(selectedProfile);
                this.lbProfilesList.Items.Remove(selectedProfile);
                this.container.refreshProfileList();
            }
        }
    }
}
