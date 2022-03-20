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
            this.tabPageSpammer = new System.Windows.Forms.TabPage();
            this.tabPageAutobuffSkill = new System.Windows.Forms.TabPage();
            this.tabLayout = new System.Windows.Forms.TabControl();
            this.tabPageAutobuffStuff = new System.Windows.Forms.TabPage();
            this.tabPageMacroSongs = new System.Windows.Forms.TabPage();
            this.tabPageProfiles = new System.Windows.Forms.TabPage();
            this.lblLinkDiscord = new System.Windows.Forms.LinkLabel();
            this.lblLinkGithub = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelProfile = new System.Windows.Forms.Label();
            this.profileCB = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.characterName = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblStatusToggle = new System.Windows.Forms.Label();
            this.btnStatusToggle = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAutopot = new System.Windows.Forms.TabPage();
            this.tabPageYggAutopot = new System.Windows.Forms.TabPage();
            this.tabLayout.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
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
            this.processCB.Size = new System.Drawing.Size(181, 21);
            this.processCB.TabIndex = 2;
            this.processCB.SelectedIndexChanged += new System.EventHandler(this.processCB_SelectedIndexChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(197, 28);
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
            this.tabPageSpammer.Size = new System.Drawing.Size(424, 274);
            this.tabPageSpammer.TabIndex = 1;
            this.tabPageSpammer.Text = "Skill Spammer";
            this.tabPageSpammer.UseVisualStyleBackColor = true;
            // 
            // tabPageAutobuffSkill
            // 
            this.tabPageAutobuffSkill.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutobuffSkill.Name = "tabPageAutobuffSkill";
            this.tabPageAutobuffSkill.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutobuffSkill.Size = new System.Drawing.Size(424, 274);
            this.tabPageAutobuffSkill.TabIndex = 3;
            this.tabPageAutobuffSkill.Text = "Autobuff - Skills";
            this.tabPageAutobuffSkill.UseVisualStyleBackColor = true;
            // 
            // tabLayout
            // 
            this.tabLayout.Controls.Add(this.tabPageSpammer);
            this.tabLayout.Controls.Add(this.tabPageAutobuffSkill);
            this.tabLayout.Controls.Add(this.tabPageAutobuffStuff);
            this.tabLayout.Controls.Add(this.tabPageMacroSongs);
            this.tabLayout.Controls.Add(this.tabPageProfiles);
            this.tabLayout.Location = new System.Drawing.Point(15, 274);
            this.tabLayout.Name = "tabLayout";
            this.tabLayout.SelectedIndex = 0;
            this.tabLayout.Size = new System.Drawing.Size(432, 300);
            this.tabLayout.TabIndex = 6;
            // 
            // tabPageAutobuffStuff
            // 
            this.tabPageAutobuffStuff.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutobuffStuff.Name = "tabPageAutobuffStuff";
            this.tabPageAutobuffStuff.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutobuffStuff.Size = new System.Drawing.Size(424, 274);
            this.tabPageAutobuffStuff.TabIndex = 4;
            this.tabPageAutobuffStuff.Text = "Autobuff - Stuffs";
            this.tabPageAutobuffStuff.UseVisualStyleBackColor = true;
            // 
            // tabPageMacroSongs
            // 
            this.tabPageMacroSongs.Location = new System.Drawing.Point(4, 22);
            this.tabPageMacroSongs.Name = "tabPageMacroSongs";
            this.tabPageMacroSongs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMacroSongs.Size = new System.Drawing.Size(424, 274);
            this.tabPageMacroSongs.TabIndex = 6;
            this.tabPageMacroSongs.Text = "Macro Songs";
            this.tabPageMacroSongs.UseVisualStyleBackColor = true;
            // 
            // tabPageProfiles
            // 
            this.tabPageProfiles.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfiles.Name = "tabPageProfiles";
            this.tabPageProfiles.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfiles.Size = new System.Drawing.Size(424, 274);
            this.tabPageProfiles.TabIndex = 5;
            this.tabPageProfiles.Text = "Profiles";
            this.tabPageProfiles.UseVisualStyleBackColor = true;
            // 
            // lblLinkDiscord
            // 
            this.lblLinkDiscord.AutoSize = true;
            this.lblLinkDiscord.Location = new System.Drawing.Point(295, 16);
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
            this.lblLinkGithub.Location = new System.Drawing.Point(143, 16);
            this.lblLinkGithub.Name = "lblLinkGithub";
            this.lblLinkGithub.Size = new System.Drawing.Size(74, 13);
            this.lblLinkGithub.TabIndex = 9;
            this.lblLinkGithub.TabStop = true;
            this.lblLinkGithub.Text = "Github Project";
            this.lblLinkGithub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkGithub_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel1.Location = new System.Drawing.Point(256, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(32, 33);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Cursor = System.Windows.Forms.Cursors.Cross;
            this.panel2.Location = new System.Drawing.Point(104, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(32, 33);
            this.panel2.TabIndex = 11;
            // 
            // labelProfile
            // 
            this.labelProfile.AutoSize = true;
            this.labelProfile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelProfile.Location = new System.Drawing.Point(252, 9);
            this.labelProfile.Name = "labelProfile";
            this.labelProfile.Size = new System.Drawing.Size(48, 17);
            this.labelProfile.TabIndex = 15;
            this.labelProfile.Text = "Profile";
            // 
            // profileCB
            // 
            this.profileCB.FormattingEnabled = true;
            this.profileCB.Location = new System.Drawing.Point(256, 29);
            this.profileCB.Name = "profileCB";
            this.profileCB.Size = new System.Drawing.Size(181, 21);
            this.profileCB.TabIndex = 14;
            this.profileCB.SelectedIndexChanged += new System.EventHandler(this.profileCB_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.lblLinkGithub);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.lblLinkDiscord);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Location = new System.Drawing.Point(0, 580);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 43);
            this.panel3.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Location = new System.Drawing.Point(16, 66);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(420, 1);
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
            this.lblCharacterName.Location = new System.Drawing.Point(266, 190);
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
            this.characterName.Location = new System.Drawing.Point(266, 203);
            this.characterName.Name = "characterName";
            this.characterName.Size = new System.Drawing.Size(19, 13);
            this.characterName.TabIndex = 20;
            this.characterName.Text = "- -";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(255, 79);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 180);
            this.panel5.TabIndex = 18;
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "4ROTools";
            this.notifyIconTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconDoubleClick);
            // 
            // lblStatusToggle
            // 
            this.lblStatusToggle.AutoSize = true;
            this.lblStatusToggle.Location = new System.Drawing.Point(43, 70);
            this.lblStatusToggle.Name = "lblStatusToggle";
            this.lblStatusToggle.Size = new System.Drawing.Size(93, 13);
            this.lblStatusToggle.TabIndex = 22;
            this.lblStatusToggle.Text = "Press the End key";
            // 
            // btnStatusToggle
            // 
            this.btnStatusToggle.BackColor = System.Drawing.Color.Red;
            this.btnStatusToggle.FlatAppearance.BorderSize = 0;
            this.btnStatusToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusToggle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStatusToggle.Location = new System.Drawing.Point(50, 36);
            this.btnStatusToggle.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatusToggle.Name = "btnStatusToggle";
            this.btnStatusToggle.Size = new System.Drawing.Size(73, 28);
            this.btnStatusToggle.TabIndex = 21;
            this.btnStatusToggle.Text = "OFF";
            this.btnStatusToggle.UseVisualStyleBackColor = false;
            this.btnStatusToggle.Click += new System.EventHandler(this.btnToggleStatusHandler);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStatusToggle);
            this.groupBox1.Controls.Add(this.lblStatusToggle);
            this.groupBox1.Location = new System.Drawing.Point(265, 78);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 105);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Status";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAutopot);
            this.tabControl1.Controls.Add(this.tabPageYggAutopot);
            this.tabControl1.Location = new System.Drawing.Point(22, 83);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(218, 127);
            this.tabControl1.TabIndex = 25;
            // 
            // tabPageAutopot
            // 
            this.tabPageAutopot.Location = new System.Drawing.Point(4, 22);
            this.tabPageAutopot.Name = "tabPageAutopot";
            this.tabPageAutopot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAutopot.Size = new System.Drawing.Size(210, 101);
            this.tabPageAutopot.TabIndex = 0;
            this.tabPageAutopot.Text = "Autopot";
            this.tabPageAutopot.UseVisualStyleBackColor = true;
            // 
            // tabPageYggAutopot
            // 
            this.tabPageYggAutopot.Location = new System.Drawing.Point(4, 22);
            this.tabPageYggAutopot.Name = "tabPageYggAutopot";
            this.tabPageYggAutopot.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageYggAutopot.Size = new System.Drawing.Size(210, 101);
            this.tabPageYggAutopot.TabIndex = 1;
            this.tabPageYggAutopot.Text = "Yggdrasil";
            this.tabPageYggAutopot.UseVisualStyleBackColor = true;
            // 
            // Container
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(455, 625);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Container";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4ROTools - Versão Beta";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Container_Load);
            this.Resize += new System.EventHandler(this.containerResize);
            this.tabLayout.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.ComboBox processCB;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TabControl tabLayout;
        private System.Windows.Forms.TabPage tabPageSpammer;
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
        private Panel panel5;
        private TabPage tabPageAutobuffStuff;
        private TabPage tabPageMacroSongs;
        private NotifyIcon notifyIconTray;
        private TabPage tabPageProfiles;
        private Label lblStatusToggle;
        private Button btnStatusToggle;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPageAutopot;
        private TabPage tabPageYggAutopot;
    }
}