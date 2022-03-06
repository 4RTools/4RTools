using System.Windows.Forms;

namespace _4RTools.Forms
{
    partial class Container
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.lblProcessName = new System.Windows.Forms.Label();
            this.processCB = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabPageAutobuffStuff = new System.Windows.Forms.TabPage();
            this.tabPageAutobuffSkill = new System.Windows.Forms.TabPage();
            this.tabLayout = new System.Windows.Forms.TabControl();
            this.tabPageSpammer = new System.Windows.Forms.TabPage();
            this.tabPageProfiles = new System.Windows.Forms.TabPage();
            this.lblLinkDiscord = new System.Windows.Forms.LinkLabel();
            this.lblLinkGithub = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelProfile = new System.Windows.Forms.Label();
            this.profileCB = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.languagePtBr = new System.Windows.Forms.Panel();
            this.languageEn = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.characterName = new System.Windows.Forms.Label();
            this.btnStatusToggle = new System.Windows.Forms.Button();
            this.lblStatusToggle = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabLayout.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProcessName
            // 
            resources.ApplyResources(this.lblProcessName, "lblProcessName");
            this.lblProcessName.Name = "lblProcessName";
            // 
            // processCB
            // 
            resources.ApplyResources(this.processCB, "processCB");
            this.processCB.FormattingEnabled = true;
            this.processCB.Name = "processCB";
            this.processCB.SelectedIndexChanged += new System.EventHandler(this.processCB_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            resources.ApplyResources(this.btnRefresh, "btnRefresh");
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabPageAutobuffStuff
            // 
            resources.ApplyResources(this.tabPageAutobuffStuff, "tabPageAutobuffStuff");
            this.tabPageAutobuffStuff.Name = "tabPageAutobuffStuff";
            this.tabPageAutobuffStuff.UseVisualStyleBackColor = true;
            // 
            // tabPageAutobuffSkill
            // 
            resources.ApplyResources(this.tabPageAutobuffSkill, "tabPageAutobuffSkill");
            this.tabPageAutobuffSkill.Name = "tabPageAutobuffSkill";
            this.tabPageAutobuffSkill.UseVisualStyleBackColor = true;
            // 
            // tabLayout
            // 
            resources.ApplyResources(this.tabLayout, "tabLayout");
            this.tabLayout.Controls.Add(this.tabPageAutobuffStuff);
            this.tabLayout.Controls.Add(this.tabPageAutobuffSkill);
            this.tabLayout.Controls.Add(this.tabPageSpammer);
            this.tabLayout.Controls.Add(this.tabPageProfiles);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            // 
            // tabPageSpammer
            // 
            resources.ApplyResources(this.tabPageSpammer, "tabPageSpammer");
            this.tabPageSpammer.Name = "tabPageSpammer";
            this.tabPageSpammer.UseVisualStyleBackColor = true;
            // 
            // tabPageProfiles
            // 
            resources.ApplyResources(this.tabPageProfiles, "tabPageProfiles");
            this.tabPageProfiles.Name = "tabPageProfiles";
            this.tabPageProfiles.UseVisualStyleBackColor = true;
            // 
            // lblLinkDiscord
            // 
            resources.ApplyResources(this.lblLinkDiscord, "lblLinkDiscord");
            this.lblLinkDiscord.Name = "lblLinkDiscord";
            this.lblLinkDiscord.TabStop = true;
            this.lblLinkDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkDiscord_LinkClicked);
            // 
            // lblLinkGithub
            // 
            resources.ApplyResources(this.lblLinkGithub, "lblLinkGithub");
            this.lblLinkGithub.Name = "lblLinkGithub";
            this.lblLinkGithub.TabStop = true;
            this.lblLinkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkGithub_LinkClicked);
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel2.Name = "panel2";
            // 
            // labelProfile
            // 
            resources.ApplyResources(this.labelProfile, "labelProfile");
            this.labelProfile.Name = "labelProfile";
            // 
            // profileCB
            // 
            resources.ApplyResources(this.profileCB, "profileCB");
            this.profileCB.FormattingEnabled = true;
            this.profileCB.Name = "profileCB";
            this.profileCB.SelectedIndexChanged += new System.EventHandler(this.profileCB_SelectedIndexChanged);
            // 
            // panel3
            // 
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.languagePtBr);
            this.panel3.Controls.Add(this.languageEn);
            this.panel3.Controls.Add(this.lblLinkGithub);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblLinkDiscord);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Name = "panel3";
            // 
            // languagePtBr
            // 
            resources.ApplyResources(this.languagePtBr, "languagePtBr");
            this.languagePtBr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.languagePtBr.Name = "languagePtBr";
            this.languagePtBr.Click += new System.EventHandler(this.languagePtBr_Click);
            // 
            // languageEn
            // 
            resources.ApplyResources(this.languageEn, "languageEn");
            this.languageEn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.languageEn.Name = "languageEn";
            this.languageEn.Click += new System.EventHandler(this.languageEn_Click);
            // 
            // panel4
            // 
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Name = "panel4";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblCharacterName
            // 
            resources.ApplyResources(this.lblCharacterName, "lblCharacterName");
            this.lblCharacterName.Name = "lblCharacterName";
            // 
            // characterName
            // 
            resources.ApplyResources(this.characterName, "characterName");
            this.characterName.ForeColor = System.Drawing.Color.DarkGreen;
            this.characterName.Name = "characterName";
            // 
            // btnStatusToggle
            // 
            resources.ApplyResources(this.btnStatusToggle, "btnStatusToggle");
            this.btnStatusToggle.BackColor = System.Drawing.Color.Red;
            this.btnStatusToggle.FlatAppearance.BorderSize = 0;
            this.btnStatusToggle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStatusToggle.Name = "btnStatusToggle";
            this.btnStatusToggle.UseVisualStyleBackColor = false;
            this.btnStatusToggle.Click += new System.EventHandler(this.btnToggleStatusHandler);
            // 
            // lblStatusToggle
            // 
            resources.ApplyResources(this.lblStatusToggle, "lblStatusToggle");
            this.lblStatusToggle.Name = "lblStatusToggle";
            // 
            // panel5
            // 
            resources.ApplyResources(this.panel5, "panel5");
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Name = "panel5";
            // 
            // notifyIconTray
            // 
            resources.ApplyResources(this.notifyIconTray, "notifyIconTray");
            this.notifyIconTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Container
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblStatusToggle);
            this.Controls.Add(this.btnStatusToggle);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.profileCB);
            this.Controls.Add(this.tabLayout);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.processCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Container";
            this.Load += new System.EventHandler(this.Container_Load);
            this.Resize += new System.EventHandler(this.containerResize);
            this.tabLayout.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.ComboBox processCB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabLayout;
        private System.Windows.Forms.TabPage tabPageAutobuffStuff;
        private System.Windows.Forms.LinkLabel lblLinkDiscord;
        private System.Windows.Forms.LinkLabel lblLinkGithub;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelProfile;
        public System.Windows.Forms.ComboBox profileCB;
        private System.Windows.Forms.TabPage tabPageAutobuffSkill;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Label characterName;
        private System.Windows.Forms.Button btnStatusToggle;
        private Label lblStatusToggle;
        private Panel panel5;
        private TabPage tabPageSpammer;
        private TabPage tabPageProfiles;
        private NotifyIcon notifyIconTray;
        private ImageList imageList1;
        private Panel languagePtBr;
        private Panel languageEn;
    }
}