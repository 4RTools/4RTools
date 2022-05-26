using System.Drawing;
using _4RTools.Model;
namespace _4RTools.Forms
{
    partial class NewContainer
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
            System.Windows.Forms.Panel panelDividerBottom;
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Panel panel2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewContainer));
            _4RTools.Model.InternalPanels internalPanels1 = new _4RTools.Model.InternalPanels();
            _4RTools.Model.Header header1 = new _4RTools.Model.Header();
            _4RTools.Model.Menu menu1 = new _4RTools.Model.Menu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.appStatePanel = new System.Windows.Forms.Panel();
            this.btnRefreshProcess = new System.Windows.Forms.Button();
            this.profileCB = new _4RTools.Components._4RComboBox();
            this.processCB = new _4RTools.Components._4RComboBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblCharacterName = new System.Windows.Forms.Label();
            this.lblCharacter = new System.Windows.Forms.Label();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            this.btnMimimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnProfiles = new System.Windows.Forms.Button();
            this.btnMacroSongs = new System.Windows.Forms.Button();
            this.btnAutobuffStuff = new System.Windows.Forms.Button();
            this.btnAtkDef = new System.Windows.Forms.Button();
            this.btnSpammer = new System.Windows.Forms.Button();
            this.btnAutobuff = new System.Windows.Forms.Button();
            this.btnMacroSwitch = new System.Windows.Forms.Button();
            this.btnAutopot = new System.Windows.Forms.Button();
            panelDividerBottom = new System.Windows.Forms.Panel();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDividerBottom
            // 
            panelDividerBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            panelDividerBottom.Location = new System.Drawing.Point(0, 512);
            panelDividerBottom.Name = "panelDividerBottom";
            panelDividerBottom.Size = new System.Drawing.Size(950, 1);
            panelDividerBottom.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            panel1.Location = new System.Drawing.Point(0, 520);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(950, 10);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(170)))), ((int)(((byte)(147)))));
            panel2.Location = new System.Drawing.Point(240, 72);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(650, 1);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 524);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(483, 523);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 26);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // appStatePanel
            // 
            this.appStatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.appStatePanel.Location = new System.Drawing.Point(737, 521);
            this.appStatePanel.Name = "appStatePanel";
            this.appStatePanel.Size = new System.Drawing.Size(185, 30);
            this.appStatePanel.TabIndex = 9;
            // 
            // btnRefreshProcess
            // 
            this.btnRefreshProcess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            this.btnRefreshProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshProcess.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshProcess.Image")));
            this.btnRefreshProcess.Location = new System.Drawing.Point(441, 521);
            this.btnRefreshProcess.Name = "btnRefreshProcess";
            this.btnRefreshProcess.Size = new System.Drawing.Size(30, 30);
            this.btnRefreshProcess.TabIndex = 10;
            this.btnRefreshProcess.UseVisualStyleBackColor = true;
            this.btnRefreshProcess.Click += new System.EventHandler(this.btnRefreshProcess_Click);
            // 
            // profileCB
            // 
            this.profileCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.profileCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            this.profileCB.BorderSize = 1;
            this.profileCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.profileCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.profileCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            this.profileCB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            this.profileCB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.profileCB.ListTextColor = System.Drawing.Color.DimGray;
            this.profileCB.Location = new System.Drawing.Point(508, 521);
            this.profileCB.MinimumSize = new System.Drawing.Size(200, 30);
            this.profileCB.Name = "profileCB";
            this.profileCB.Padding = new System.Windows.Forms.Padding(1);
            this.profileCB.Size = new System.Drawing.Size(200, 30);
            this.profileCB.TabIndex = 8;
            this.profileCB.Texts = "Choose Profile";
            this.profileCB.OnSelectedIndexChanged += new System.EventHandler(this.onProfileChanged);
            // 
            // processCB
            // 
            this.processCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.processCB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            this.processCB.BorderSize = 1;
            this.processCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.processCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.processCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            this.processCB.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            this.processCB.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.processCB.ListTextColor = System.Drawing.Color.DimGray;
            this.processCB.Location = new System.Drawing.Point(239, 521);
            this.processCB.MinimumSize = new System.Drawing.Size(200, 30);
            this.processCB.Name = "processCB";
            this.processCB.Padding = new System.Windows.Forms.Padding(1);
            this.processCB.Size = new System.Drawing.Size(200, 30);
            this.processCB.TabIndex = 0;
            this.processCB.Texts = "Choose Process";
            this.processCB.OnSelectedIndexChanged += new System.EventHandler(this.onProcessChange);
            // 
            // panelDesktop
            // 
            internalPanels1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.panelDesktop.BackColor = internalPanels1.BackgroundColor;
            this.panelDesktop.Location = new System.Drawing.Point(206, 75);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(728, 435);
            this.panelDesktop.TabIndex = 4;
            // 
            // panelTitle
            // 
            header1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            header1.CharacterNameColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(125)))), ((int)(((byte)(54)))));
            header1.ModuleNameColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            this.panelTitle.BackColor = header1.BackgroundColor;
            this.panelTitle.Controls.Add(this.lblCharacterName);
            this.panelTitle.Controls.Add(this.lblCharacter);
            this.panelTitle.Controls.Add(this.pbIcon);
            this.panelTitle.Controls.Add(this.btnMimimize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(206, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(728, 73);
            this.panelTitle.TabIndex = 3;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // lblCharacterName
            // 
            this.lblCharacterName.AutoSize = true;
            this.lblCharacterName.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Bold);
            this.lblCharacterName.ForeColor = System.Drawing.Color.Red;
            this.lblCharacterName.Location = new System.Drawing.Point(181, 51);
            this.lblCharacterName.Name = "lblCharacterName";
            this.lblCharacterName.Size = new System.Drawing.Size(84, 12);
            this.lblCharacterName.TabIndex = 4;
            this.lblCharacterName.Text = "Not Selected";
            this.lblCharacterName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCharacter
            // 
            this.lblCharacter.AutoSize = true;
            this.lblCharacter.Font = new System.Drawing.Font("Lucida Sans", 8F, System.Drawing.FontStyle.Bold);
            this.lblCharacter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            this.lblCharacter.Location = new System.Drawing.Point(80, 51);
            this.lblCharacter.Name = "lblCharacter";
            this.lblCharacter.Size = new System.Drawing.Size(104, 12);
            this.lblCharacter.TabIndex = 3;
            this.lblCharacter.Text = "Character Name:";
            // 
            // pbIcon
            // 
            this.pbIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbIcon.Image")));
            this.pbIcon.Location = new System.Drawing.Point(15, 12);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(60, 57);
            this.pbIcon.TabIndex = 2;
            this.pbIcon.TabStop = false;
            // 
            // btnMimimize
            // 
            this.btnMimimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMimimize.FlatAppearance.BorderSize = 0;
            this.btnMimimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMimimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMimimize.Image")));
            this.btnMimimize.Location = new System.Drawing.Point(669, 0);
            this.btnMimimize.Name = "btnMimimize";
            this.btnMimimize.Size = new System.Drawing.Size(28, 25);
            this.btnMimimize.TabIndex = 1;
            this.btnMimimize.UseVisualStyleBackColor = true;
            this.btnMimimize.Click += new System.EventHandler(this.btnMimimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(697, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 25);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = header1.ModuleNameColor;
            this.lblTitle.Location = new System.Drawing.Point(77, 19);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTitle.Size = new System.Drawing.Size(67, 23);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Teste";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMenu
            // 
            menu1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            menu1.ButtonActiveHighlightColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            menu1.ButtonsBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(97)))));
            menu1.ButtonsForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(55)))), ((int)(((byte)(21)))));
            menu1.LabelVersionColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.panelMenu.BackColor = menu1.BackgroundColor;
            this.panelMenu.Controls.Add(this.lblVersion);
            this.panelMenu.Controls.Add(this.btnProfiles);
            this.panelMenu.Controls.Add(this.btnMacroSongs);
            this.panelMenu.Controls.Add(this.btnAutobuffStuff);
            this.panelMenu.Controls.Add(this.btnAtkDef);
            this.panelMenu.Controls.Add(this.btnSpammer);
            this.panelMenu.Controls.Add(this.btnAutobuff);
            this.panelMenu.Controls.Add(this.btnMacroSwitch);
            this.panelMenu.Controls.Add(this.btnAutopot);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(206, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Lucida Sans", 10F, System.Drawing.FontStyle.Bold);
            this.lblVersion.ForeColor = menu1.LabelVersionColor;
            this.lblVersion.Location = new System.Drawing.Point(80, 536);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(50, 16);
            this.lblVersion.TabIndex = 8;
            this.lblVersion.Text = "label1";
            // 
            // btnProfiles
            // 
            this.btnProfiles.BackColor = menu1.ButtonsBackgroundColor;
            this.btnProfiles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProfiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfiles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(97)))));
            this.btnProfiles.FlatAppearance.BorderSize = 0;
            this.btnProfiles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfiles.Font = new System.Drawing.Font("Lucida Sans", 14.75F);
            this.btnProfiles.ForeColor = menu1.ButtonsForegroundColor;
            this.btnProfiles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfiles.Location = new System.Drawing.Point(1, 402);
            this.btnProfiles.Name = "btnProfiles";
            this.btnProfiles.Size = new System.Drawing.Size(205, 42);
            this.btnProfiles.TabIndex = 7;
            this.btnProfiles.Tag = "Profiles";
            this.btnProfiles.Text = "Profiles";
            this.btnProfiles.UseVisualStyleBackColor = false;
            // 
            // btnMacroSongs
            // 
            this.btnMacroSongs.BackColor = menu1.ButtonsBackgroundColor;
            this.btnMacroSongs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMacroSongs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMacroSongs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(97)))));
            this.btnMacroSongs.FlatAppearance.BorderSize = 0;
            this.btnMacroSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMacroSongs.Font = new System.Drawing.Font("Lucida Sans", 14.75F);
            this.btnMacroSongs.ForeColor = menu1.ButtonsForegroundColor;
            this.btnMacroSongs.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMacroSongs.Location = new System.Drawing.Point(0, 273);
            this.btnMacroSongs.Name = "btnMacroSongs";
            this.btnMacroSongs.Size = new System.Drawing.Size(206, 42);
            this.btnMacroSongs.TabIndex = 4;
            this.btnMacroSongs.Tag = "MacroSongs";
            this.btnMacroSongs.Text = "Macro Songs";
            this.btnMacroSongs.UseVisualStyleBackColor = false;
            this.btnMacroSongs.Click += new System.EventHandler(this.onClickButton);
            // 
            // btnAutobuffStuff
            // 
            this.btnAutobuffStuff.BackColor = menu1.ButtonsBackgroundColor;
            this.btnAutobuffStuff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutobuffStuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutobuffStuff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(97)))));
            this.btnAutobuffStuff.FlatAppearance.BorderSize = 0;
            this.btnAutobuffStuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutobuffStuff.Font = new System.Drawing.Font("Lucida Sans", 14.75F);
            this.btnAutobuffStuff.ForeColor = menu1.ButtonsForegroundColor;
            this.btnAutobuffStuff.Image = ((System.Drawing.Image)(resources.GetObject("btnAutobuffStuff.Image")));
            this.btnAutobuffStuff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutobuffStuff.Location = new System.Drawing.Point(0, 230);
            this.btnAutobuffStuff.Name = "btnAutobuffStuff";
            this.btnAutobuffStuff.Size = new System.Drawing.Size(206, 42);
            this.btnAutobuffStuff.TabIndex = 3;
            this.btnAutobuffStuff.Tag = "AutobuffStuff";
            this.btnAutobuffStuff.Text = "Autobuff Stuffs";
            this.btnAutobuffStuff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutobuffStuff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutobuffStuff.UseVisualStyleBackColor = false;
            this.btnAutobuffStuff.Click += new System.EventHandler(this.onClickButton);
            // 
            // btnAtkDef
            // 
            this.btnAtkDef.BackColor = menu1.ButtonsBackgroundColor;
            this.btnAtkDef.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAtkDef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtkDef.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(97)))));
            this.btnAtkDef.FlatAppearance.BorderSize = 0;
            this.btnAtkDef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtkDef.Font = new System.Drawing.Font("Lucida Sans", 14.75F);
            this.btnAtkDef.ForeColor = menu1.ButtonsForegroundColor;
            this.btnAtkDef.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtkDef.Location = new System.Drawing.Point(1, 359);
            this.btnAtkDef.Name = "btnAtkDef";
            this.btnAtkDef.Size = new System.Drawing.Size(205, 42);
            this.btnAtkDef.TabIndex = 6;
            this.btnAtkDef.Tag = "ATKDEF";
            this.btnAtkDef.Text = "ATK x DEF";
            this.btnAtkDef.UseVisualStyleBackColor = false;
            this.btnAtkDef.Click += new System.EventHandler(this.onClickButton);
            // 
            // btnSpammer
            // 
            this.btnSpammer.BackColor = menu1.ButtonsBackgroundColor;
            this.btnSpammer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpammer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpammer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(97)))));
            this.btnSpammer.FlatAppearance.BorderSize = 0;
            this.btnSpammer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpammer.Font = new System.Drawing.Font("Lucida Sans", 14.75F);
            this.btnSpammer.ForeColor = menu1.ButtonsForegroundColor;
            this.btnSpammer.Image = ((System.Drawing.Image)(resources.GetObject("btnSpammer.Image")));
            this.btnSpammer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpammer.Location = new System.Drawing.Point(0, 144);
            this.btnSpammer.Name = "btnSpammer";
            this.btnSpammer.Size = new System.Drawing.Size(206, 42);
            this.btnSpammer.TabIndex = 1;
            this.btnSpammer.Tag = "Spammer";
            this.btnSpammer.Text = "Spammer";
            this.btnSpammer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpammer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSpammer.UseVisualStyleBackColor = false;
            this.btnSpammer.Click += new System.EventHandler(this.onClickButton);
            // 
            // btnAutobuff
            // 
            this.btnAutobuff.BackColor = menu1.ButtonsBackgroundColor;
            this.btnAutobuff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutobuff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutobuff.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(97)))));
            this.btnAutobuff.FlatAppearance.BorderSize = 0;
            this.btnAutobuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutobuff.Font = new System.Drawing.Font("Lucida Sans", 14.75F);
            this.btnAutobuff.ForeColor = menu1.ButtonsForegroundColor;
            this.btnAutobuff.Image = ((System.Drawing.Image)(resources.GetObject("btnAutobuff.Image")));
            this.btnAutobuff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutobuff.Location = new System.Drawing.Point(-1, 187);
            this.btnAutobuff.Name = "btnAutobuff";
            this.btnAutobuff.Size = new System.Drawing.Size(208, 42);
            this.btnAutobuff.TabIndex = 2;
            this.btnAutobuff.Tag = "AutobuffSkill";
            this.btnAutobuff.Text = "Autobuff Skill";
            this.btnAutobuff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAutobuff.UseVisualStyleBackColor = false;
            this.btnAutobuff.Click += new System.EventHandler(this.onClickButton);
            // 
            // btnMacroSwitch
            // 
            this.btnMacroSwitch.BackColor = menu1.ButtonsBackgroundColor;
            this.btnMacroSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMacroSwitch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMacroSwitch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(97)))));
            this.btnMacroSwitch.FlatAppearance.BorderSize = 0;
            this.btnMacroSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMacroSwitch.Font = new System.Drawing.Font("Lucida Sans", 14.75F);
            this.btnMacroSwitch.ForeColor = menu1.ButtonsForegroundColor;
            this.btnMacroSwitch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMacroSwitch.Location = new System.Drawing.Point(-1, 316);
            this.btnMacroSwitch.Name = "btnMacroSwitch";
            this.btnMacroSwitch.Size = new System.Drawing.Size(207, 42);
            this.btnMacroSwitch.TabIndex = 5;
            this.btnMacroSwitch.Tag = "MacroSwitch";
            this.btnMacroSwitch.Text = "Macro Switch";
            this.btnMacroSwitch.UseVisualStyleBackColor = false;
            this.btnMacroSwitch.Click += new System.EventHandler(this.onClickButton);
            // 
            // btnAutopot
            // 
            this.btnAutopot.BackColor = menu1.ButtonsBackgroundColor;
            this.btnAutopot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAutopot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAutopot.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(181)))), ((int)(((byte)(97)))));
            this.btnAutopot.FlatAppearance.BorderSize = 0;
            this.btnAutopot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutopot.Font = new System.Drawing.Font("Lucida Sans", 14.75F);
            this.btnAutopot.ForeColor = menu1.ButtonsForegroundColor;
            this.btnAutopot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAutopot.Location = new System.Drawing.Point(0, 101);
            this.btnAutopot.Name = "btnAutopot";
            this.btnAutopot.Size = new System.Drawing.Size(206, 42);
            this.btnAutopot.TabIndex = 0;
            this.btnAutopot.Tag = "Autopot";
            this.btnAutopot.Text = "Autopot";
            this.btnAutopot.UseVisualStyleBackColor = false;
            this.btnAutopot.Click += new System.EventHandler(this.onClickButton);
            // 
            // NewContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.btnRefreshProcess);
            this.Controls.Add(this.appStatePanel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.profileCB);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.processCB);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(panel2);
            this.Controls.Add(panelDividerBottom);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewContainer";
            this.Load += new System.EventHandler(this.NewContainer_Load);
            this.Resize += new System.EventHandler(this.containerResize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnAutopot;
        private System.Windows.Forms.Button btnSpammer;
        private System.Windows.Forms.Button btnAutobuff;
        private System.Windows.Forms.Button btnAutobuffStuff;
        private System.Windows.Forms.Button btnMacroSongs;
        private System.Windows.Forms.Button btnMacroSwitch;
        private System.Windows.Forms.Button btnAtkDef;
        private System.Windows.Forms.Button btnProfiles;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMimimize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Components._4RComboBox processCB;
        private Components._4RComboBox profileCB;
        private System.Windows.Forms.Panel appStatePanel;
        private System.Windows.Forms.Label lblCharacter;
        private System.Windows.Forms.PictureBox pbIcon;
        private System.Windows.Forms.Label lblCharacterName;
        private System.Windows.Forms.Button btnRefreshProcess;
        private System.Windows.Forms.Label lblVersion;
    }
}