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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Container));
            this.lblProcessName = new System.Windows.Forms.Label();
            this.processCB = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabPageSpammer = new System.Windows.Forms.TabPage();
            this.tabPageAutobuffSkill = new System.Windows.Forms.TabPage();
            this.atkDefMode = new System.Windows.Forms.TabControl();
            this.tabPageAutobuffStuff = new System.Windows.Forms.TabPage();
            this.tabPageMacroSongs = new System.Windows.Forms.TabPage();
            this.atkDef = new System.Windows.Forms.TabPage();
            this.tabMacroSwitch = new System.Windows.Forms.TabPage();
            this.tabPageProfiles = new System.Windows.Forms.TabPage();
            this.tabPageServer = new System.Windows.Forms.TabPage();
            this.lblLinkDiscord = new System.Windows.Forms.LinkLabel();
            this.lblLinkGithub = new System.Windows.Forms.LinkLabel();
            this.panelDiscImage = new System.Windows.Forms.Panel();
            this.panelGithubImage = new System.Windows.Forms.Panel();
            this.labelProfile = new System.Windows.Forms.Label();
            this.profileCB = new System.Windows.Forms.ComboBox();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.websiteLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.characterName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControlAutopot = new System.Windows.Forms.TabControl();
            this.tabPageAutopot = new System.Windows.Forms.TabPage();
            this.tabPageYggAutopot = new System.Windows.Forms.TabPage();
            this.tabPageSkillTimer = new System.Windows.Forms.TabPage();
            this.panelAdvertisement = new System.Windows.Forms.Panel();
            this.atkDefMode.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.tabControlAutopot.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProcessName.Location = new System.Drawing.Point(12, 9);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(109, 17);
            this.lblProcessName.TabIndex = 3;
            this.lblProcessName.Text = "Ragnarok Client";
            // 
            // processCB
            // 
            this.processCB.FormattingEnabled = true;
            this.processCB.Location = new System.Drawing.Point(17, 29);
            this.processCB.Name = "processCB";
            this.processCB.Size = new System.Drawing.Size(184, 21);
            this.processCB.TabIndex = 2;
            this.processCB.SelectedIndexChanged += new System.EventHandler(this.processCB_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(201, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(19, 22);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tabPageSpammer
            // 
            this.tabPageSpammer.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpammer.Name = "tabPageSpammer";
            this.tabPageSpammer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpammer.Size = new System.Drawing.Size(563, 274);
            this.tabPageSpammer.TabIndex = 1;
            this.tabPageSpammer.Text = "Skill Spammer";
            this.tabPageSpammer.UseVisualStyleBackColor = true;
            // 
            // tabPageAutobuffSkill
            // 
            this.tabPageAutobuffSkill.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutobuffSkill.Name = "tabPageAutobuffSkill";
            this.tabPageAutobuffSkill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutobuffSkill.Size = new System.Drawing.Size(563, 274);
            this.tabPageAutobuffSkill.TabIndex = 3;
            this.tabPageAutobuffSkill.Text = "Autobuff - Skills";
            this.tabPageAutobuffSkill.UseVisualStyleBackColor = true;
            // 
            // atkDefMode
            // 
            this.atkDefMode.Controls.Add(this.tabPageSpammer);
            this.atkDefMode.Controls.Add(this.tabPageAutobuffSkill);
            this.atkDefMode.Controls.Add(this.tabPageAutobuffStuff);
            this.atkDefMode.Controls.Add(this.tabPageMacroSongs);
            this.atkDefMode.Controls.Add(this.atkDef);
            this.atkDefMode.Controls.Add(this.tabMacroSwitch);
            this.atkDefMode.Controls.Add(this.tabPageProfiles);
            this.atkDefMode.Controls.Add(this.tabPageServer);
            this.atkDefMode.Location = new System.Drawing.Point(15, 274);
            this.atkDefMode.Name = "atkDefMode";
            this.atkDefMode.SelectedIndex = 0;
            this.atkDefMode.Size = new System.Drawing.Size(571, 300);
            this.atkDefMode.TabIndex = 6;
            // 
            // tabPageAutobuffStuff
            // 
            this.tabPageAutobuffStuff.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutobuffStuff.Name = "tabPageAutobuffStuff";
            this.tabPageAutobuffStuff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutobuffStuff.Size = new System.Drawing.Size(563, 274);
            this.tabPageAutobuffStuff.TabIndex = 4;
            this.tabPageAutobuffStuff.Text = "Autobuff - Stuffs";
            this.tabPageAutobuffStuff.UseVisualStyleBackColor = true;
            // 
            // tabPageMacroSongs
            // 
            this.tabPageMacroSongs.Location = new System.Drawing.Point(4, 22);
            this.tabPageMacroSongs.Name = "tabPageMacroSongs";
            this.tabPageMacroSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMacroSongs.Size = new System.Drawing.Size(563, 274);
            this.tabPageMacroSongs.TabIndex = 6;
            this.tabPageMacroSongs.Text = "Macro Songs";
            this.tabPageMacroSongs.UseVisualStyleBackColor = true;
            // 
            // atkDef
            // 
            this.atkDef.Location = new System.Drawing.Point(4, 22);
            this.atkDef.Name = "atkDef";
            this.atkDef.Padding = new System.Windows.Forms.Padding(3);
            this.atkDef.Size = new System.Drawing.Size(563, 274);
            this.atkDef.TabIndex = 5;
            this.atkDef.Text = "ATK x DEF Mode";
            this.atkDef.UseVisualStyleBackColor = true;
            // 
            // tabMacroSwitch
            // 
            this.tabMacroSwitch.Location = new System.Drawing.Point(4, 22);
            this.tabMacroSwitch.Name = "tabMacroSwitch";
            this.tabMacroSwitch.Padding = new System.Windows.Forms.Padding(3);
            this.tabMacroSwitch.Size = new System.Drawing.Size(563, 274);
            this.tabMacroSwitch.TabIndex = 8;
            this.tabMacroSwitch.Text = "Macro Switch";
            this.tabMacroSwitch.UseVisualStyleBackColor = true;
            // 
            // tabPageProfiles
            // 
            this.tabPageProfiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfiles.Name = "tabPageProfiles";
            this.tabPageProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfiles.Size = new System.Drawing.Size(563, 274);
            this.tabPageProfiles.TabIndex = 7;
            this.tabPageProfiles.Text = "Profiles";
            this.tabPageProfiles.UseVisualStyleBackColor = true;
            // 
            // tabPageServer
            // 
            this.tabPageServer.Location = new System.Drawing.Point(4, 22);
            this.tabPageServer.Name = "tabPageServer";
            this.tabPageServer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageServer.Size = new System.Drawing.Size(563, 274);
            this.tabPageServer.TabIndex = 9;
            this.tabPageServer.Text = "Servers";
            this.tabPageServer.UseVisualStyleBackColor = true;
            // 
            // lblLinkDiscord
            // 
            this.lblLinkDiscord.AutoSize = true;
            this.lblLinkDiscord.Location = new System.Drawing.Point(795, 16);
            this.lblLinkDiscord.Name = "lblLinkDiscord";
            this.lblLinkDiscord.Size = new System.Drawing.Size(92, 13);
            this.lblLinkDiscord.TabIndex = 8;
            this.lblLinkDiscord.TabStop = true;
            this.lblLinkDiscord.Text = "Join in our discord";
            this.lblLinkDiscord.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkDiscord_LinkClicked);
            // 
            // lblLinkGithub
            // 
            this.lblLinkGithub.AutoSize = true;
            this.lblLinkGithub.Location = new System.Drawing.Point(70, 16);
            this.lblLinkGithub.Name = "lblLinkGithub";
            this.lblLinkGithub.Size = new System.Drawing.Size(74, 13);
            this.lblLinkGithub.TabIndex = 9;
            this.lblLinkGithub.TabStop = true;
            this.lblLinkGithub.Text = "Github Project";
            this.lblLinkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkGithub_LinkClicked);
            // 
            // panelDiscImage
            // 
            this.panelDiscImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDiscImage.BackgroundImage")));
            this.panelDiscImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelDiscImage.Location = new System.Drawing.Point(756, 6);
            this.panelDiscImage.Name = "panelDiscImage";
            this.panelDiscImage.Size = new System.Drawing.Size(32, 33);
            this.panelDiscImage.TabIndex = 10;
            // 
            // panelGithubImage
            // 
            this.panelGithubImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGithubImage.BackgroundImage")));
            this.panelGithubImage.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panelGithubImage.Location = new System.Drawing.Point(31, 6);
            this.panelGithubImage.Name = "panelGithubImage";
            this.panelGithubImage.Size = new System.Drawing.Size(32, 33);
            this.panelGithubImage.TabIndex = 11;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProfile.Location = new System.Drawing.Point(401, 10);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(48, 17);
            this.labelProfile.TabIndex = 15;
            this.labelProfile.Text = "Profile";
            // 
            // profileCB
            // 
            this.profileCB.FormattingEnabled = true;
            this.profileCB.Location = new System.Drawing.Point(405, 30);
            this.profileCB.Name = "profileCB";
            this.profileCB.Size = new System.Drawing.Size(181, 21);
            this.profileCB.TabIndex = 14;
            this.profileCB.SelectedIndexChanged += new System.EventHandler(this.profileCB_SelectedIndexChanged);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFooter.Controls.Add(this.websiteLinkLabel);
            this.panelFooter.Controls.Add(this.panel1);
            this.panelFooter.Controls.Add(this.lblLinkGithub);
            this.panelFooter.Controls.Add(this.panelGithubImage);
            this.panelFooter.Controls.Add(this.lblLinkDiscord);
            this.panelFooter.Controls.Add(this.panelDiscImage);
            this.panelFooter.Location = new System.Drawing.Point(-3, 580);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(903, 43);
            this.panelFooter.TabIndex = 16;
            // 
            // websiteLinkLabel
            // 
            this.websiteLinkLabel.AutoSize = true;
            this.websiteLinkLabel.Location = new System.Drawing.Point(403, 16);
            this.websiteLinkLabel.Name = "websiteLinkLabel";
            this.websiteLinkLabel.Size = new System.Drawing.Size(91, 13);
            this.websiteLinkLabel.TabIndex = 12;
            this.websiteLinkLabel.TabStop = true;
            this.websiteLinkLabel.Text = "WebSite 4RTools";
            this.websiteLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.websiteLinkLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(366, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 33);
            this.panel1.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(16, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(568, 1);
            this.panel4.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Location = new System.Drawing.Point(362, 210);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(87, 13);
            this.lblCharacterName.TabIndex = 19;
            this.lblCharacterName.Text = "Character Name:";
            // 
            // characterName
            // 
            this.characterName.AutoSize = true;
            this.characterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.characterName.ForeColor = System.Drawing.Color.DarkGreen;
            this.characterName.Location = new System.Drawing.Point(362, 223);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(19, 13);
            this.characterName.TabIndex = 20;
            this.characterName.Text = "- -";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(302, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 180);
            this.panel5.TabIndex = 18;
            // 
            // tabControlAutopot
            // 
            this.tabControlAutopot.Controls.Add(this.tabPageAutopot);
            this.tabControlAutopot.Controls.Add(this.tabPageYggAutopot);
            this.tabControlAutopot.Controls.Add(this.tabPageSkillTimer);
            this.tabControlAutopot.Location = new System.Drawing.Point(22, 83);
            this.tabControlAutopot.Name = "tabControlAutopot";
            this.tabControlAutopot.SelectedIndex = 0;
            this.tabControlAutopot.Size = new System.Drawing.Size(204, 127);
            this.tabControlAutopot.TabIndex = 25;
            // 
            // tabPageAutopot
            // 
            this.tabPageAutopot.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutopot.Name = "tabPageAutopot";
            this.tabPageAutopot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutopot.Size = new System.Drawing.Size(196, 101);
            this.tabPageAutopot.TabIndex = 0;
            this.tabPageAutopot.Text = "Autopot";
            this.tabPageAutopot.UseVisualStyleBackColor = true;
            // 
            // tabPageYggAutopot
            // 
            this.tabPageYggAutopot.Location = new System.Drawing.Point(4, 22);
            this.tabPageYggAutopot.Name = "tabPageYggAutopot";
            this.tabPageYggAutopot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYggAutopot.Size = new System.Drawing.Size(196, 101);
            this.tabPageYggAutopot.TabIndex = 1;
            this.tabPageYggAutopot.Text = "Yggdrasil";
            this.tabPageYggAutopot.UseVisualStyleBackColor = true;
            // 
            // tabPageSkillTimer
            // 
            this.tabPageSkillTimer.Location = new System.Drawing.Point(4, 22);
            this.tabPageSkillTimer.Name = "tabPageSkillTimer";
            this.tabPageSkillTimer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSkillTimer.Size = new System.Drawing.Size(196, 101);
            this.tabPageSkillTimer.TabIndex = 2;
            this.tabPageSkillTimer.Text = "Skill Timer";
            this.tabPageSkillTimer.UseVisualStyleBackColor = true;
            // 
            // panelAdvertisement
            // 
            this.panelAdvertisement.Location = new System.Drawing.Point(596, 24);
            this.panelAdvertisement.Name = "panelAdvertisement";
            this.panelAdvertisement.Size = new System.Drawing.Size(292, 556);
            this.panelAdvertisement.TabIndex = 26;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 624);
            this.Controls.Add(this.panelAdvertisement);
            this.Controls.Add(this.tabControlAutopot);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.characterName);
            this.Controls.Add(this.lblCharacterName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.labelProfile);
            this.Controls.Add(this.profileCB);
            this.Controls.Add(this.atkDefMode);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.processCB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4ROTools - Versão Beta";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Container_Load);
            this.Resize += new System.EventHandler(this.containerResize);
            this.atkDefMode.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelFooter.PerformLayout();
            this.tabControlAutopot.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.ComboBox processCB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl atkDefMode;
        private System.Windows.Forms.TabPage tabPageSpammer;
        private System.Windows.Forms.LinkLabel lblLinkDiscord;
        private System.Windows.Forms.LinkLabel lblLinkGithub;
        private System.Windows.Forms.Panel panelDiscImage;
        private System.Windows.Forms.Panel panelGithubImage;
        private System.Windows.Forms.Label labelProfile;
        public System.Windows.Forms.ComboBox profileCB;
        private System.Windows.Forms.TabPage tabPageAutobuffSkill;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Label characterName;
        private Panel panel5;
        private TabPage tabPageAutobuffStuff;
        private TabPage tabPageMacroSongs;
        private TabPage atkDef;
        private TabControl tabControlAutopot;
        private TabPage tabPageAutopot;
        private TabPage tabPageYggAutopot;
        private LinkLabel websiteLinkLabel;
        private Panel panel1;
        private TabPage tabPageProfiles;
        private TabPage tabMacroSwitch;
        private TabPage tabPageSkillTimer;
        private TabPage tabPageServer;
        private Panel panelAdvertisement;
    }
}