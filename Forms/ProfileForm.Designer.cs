namespace _4RTools.Forms
{
    partial class ProfileForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveProfile = new System.Windows.Forms.Button();
            this.lblProfilesList = new System.Windows.Forms.Label();
            this.lbProfilesList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtProfileName
            // 
            resources.ApplyResources(this.txtProfileName, "txtProfileName");
            this.txtProfileName.Name = "txtProfileName";
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnRemoveProfile
            // 
            resources.ApplyResources(this.btnRemoveProfile, "btnRemoveProfile");
            this.btnRemoveProfile.Name = "btnRemoveProfile";
            this.btnRemoveProfile.UseVisualStyleBackColor = true;
            this.btnRemoveProfile.Click += new System.EventHandler(this.btnRemoveProfile_Click);
            // 
            // lblProfilesList
            // 
            resources.ApplyResources(this.lblProfilesList, "lblProfilesList");
            this.lblProfilesList.Name = "lblProfilesList";
            // 
            // lbProfilesList
            // 
            resources.ApplyResources(this.lbProfilesList, "lbProfilesList");
            this.lbProfilesList.FormattingEnabled = true;
            this.lbProfilesList.Name = "lbProfilesList";
            // 
            // ProfileForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbProfilesList);
            this.Controls.Add(this.lblProfilesList);
            this.Controls.Add(this.btnRemoveProfile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtProfileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProfileName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemoveProfile;
        private System.Windows.Forms.Label lblProfilesList;
        private System.Windows.Forms.ListBox lbProfilesList;
    }
}