using _4RTools.Model;
using _4RTools.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4RTools.Forms
{
    public partial class EditProfileName : Form
    {
        private string tmpProfileName;
        public EditProfileName()
        {
            InitializeComponent();
        }

        public void SetProfileName(string name)
        {
            this.txtProfileName.Text = name;
            this.tmpProfileName = name;
        }

        private void onTextChange(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                this.btnSave.Enabled = false;
            }
            else
            {
                this.btnSave.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ProfileSingleton.Rename(this.tmpProfileName, this.txtProfileName.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"[Edit Profile Name] {ex.Message}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
