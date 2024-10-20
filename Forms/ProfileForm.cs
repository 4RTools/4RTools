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
            this.RefreshProfileList();
        }

        private void RefreshProfileList()
        {
            foreach (string profile in Profile.ListAll())
            {
                int profileIndex = this.lbProfilesList.Items.IndexOf(profile);
                if (profile != "Default" && profileIndex == -1) { this.lbProfilesList.Items.Add(profile); };
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newProfileName = this.txtProfileName.Text;
            if (string.IsNullOrEmpty(newProfileName)) { return; }

            ProfileSingleton.Create(newProfileName);
            this.RefreshProfileList();
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
                MessageBox.Show("Cannot delete the Default profile!");
            } else
            {
                ProfileSingleton.Delete(selectedProfile);
                this.lbProfilesList.Items.Remove(selectedProfile);
                this.RefreshProfileList();
                this.container.refreshProfileList();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.lbProfilesList.SelectedItem == null)
            {
                MessageBox.Show("To edit a profile, first select one from the Profile list.");
                return;
            }

            var selectedProfile = this.lbProfilesList.Items[this.lbProfilesList.SelectedIndex].ToString();

            if (selectedProfile == "Default")
            {
                MessageBox.Show("Cannot delete the Default profile!");
            }
            else {
                EditProfileName editProfileName = new EditProfileName();
                editProfileName.SetProfileName(selectedProfile);
                editProfileName.ShowDialog();

                if (editProfileName.DialogResult == DialogResult.OK) {
                    this.RefreshProfileList();
                    this.container.refreshProfileList();
                };
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (this.lbProfilesList.SelectedItem == null)
            {
                MessageBox.Show("To copy a profile, first select one from the Profile list.");
                return;
            }

            var selectedProfile = this.lbProfilesList.Items[this.lbProfilesList.SelectedIndex].ToString();
            if (selectedProfile == "Default")
            {
                MessageBox.Show("Cannot delete the Default profile!");
            }
            else {
                ProfileSingleton.Copy(selectedProfile);
                this.RefreshProfileList();
                this.container.refreshProfileList();
            }
        }
    }
}
