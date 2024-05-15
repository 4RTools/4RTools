namespace _4RTools.Forms
{
    partial class ToggleApplicationStateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToggleApplicationStateForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatusToggleKey = new System.Windows.Forms.TextBox();
            this.btnStatusToggle = new System.Windows.Forms.Button();
            this.lblStatusToggle = new System.Windows.Forms.Label();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtCityToggleKey = new System.Windows.Forms.TextBox();
            this.activateOnCityButton = new System.Windows.Forms.Button();
            this.activateOnCityLabel = new System.Windows.Forms.Label();
            this.lblStatusHealToggle = new System.Windows.Forms.Label();
            this.btnStatusHealToggle = new System.Windows.Forms.Button();
            this.txtStatusHealToggleKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.activateOnReinLabel = new System.Windows.Forms.Label();
            this.txtReinToggleKey = new System.Windows.Forms.TextBox();
            this.activateOnReinButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.groupBox1.Controls.Add(this.txtStatusToggleKey);
            this.groupBox1.Controls.Add(this.btnStatusToggle);
            this.groupBox1.Controls.Add(this.lblStatusToggle);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 64);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Status";
            // 
            // txtStatusToggleKey
            // 
            this.txtStatusToggleKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtStatusToggleKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatusToggleKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStatusToggleKey.ForeColor = System.Drawing.Color.White;
            this.txtStatusToggleKey.Location = new System.Drawing.Point(84, 18);
            this.txtStatusToggleKey.Name = "txtStatusToggleKey";
            this.txtStatusToggleKey.Size = new System.Drawing.Size(48, 23);
            this.txtStatusToggleKey.TabIndex = 23;
            this.txtStatusToggleKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStatusToggle
            // 
            this.btnStatusToggle.BackColor = System.Drawing.Color.Red;
            this.btnStatusToggle.FlatAppearance.BorderSize = 0;
            this.btnStatusToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusToggle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStatusToggle.Location = new System.Drawing.Point(8, 16);
            this.btnStatusToggle.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatusToggle.Name = "btnStatusToggle";
            this.btnStatusToggle.Size = new System.Drawing.Size(68, 28);
            this.btnStatusToggle.TabIndex = 21;
            this.btnStatusToggle.Text = "OFF";
            this.btnStatusToggle.UseVisualStyleBackColor = false;
            this.btnStatusToggle.Click += new System.EventHandler(this.btnToggleStatusHandler);
            // 
            // lblStatusToggle
            // 
            this.lblStatusToggle.AllowDrop = true;
            this.lblStatusToggle.AutoSize = true;
            this.lblStatusToggle.Location = new System.Drawing.Point(4, 45);
            this.lblStatusToggle.MaximumSize = new System.Drawing.Size(109, 30);
            this.lblStatusToggle.Name = "lblStatusToggle";
            this.lblStatusToggle.Size = new System.Drawing.Size(109, 13);
            this.lblStatusToggle.TabIndex = 22;
            this.lblStatusToggle.Text = "Press the key to start!";
            this.lblStatusToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "4ROTools";
            this.notifyIconTray.Visible = true;
            this.notifyIconTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.groupBox4.Controls.Add(this.txtCityToggleKey);
            this.groupBox4.Controls.Add(this.activateOnCityButton);
            this.groupBox4.Controls.Add(this.activateOnCityLabel);
            this.groupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.groupBox4.Location = new System.Drawing.Point(1, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(141, 70);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Activate on City";
            // 
            // txtCityToggleKey
            // 
            this.txtCityToggleKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtCityToggleKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCityToggleKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCityToggleKey.ForeColor = System.Drawing.Color.White;
            this.txtCityToggleKey.Location = new System.Drawing.Point(84, 19);
            this.txtCityToggleKey.Name = "txtCityToggleKey";
            this.txtCityToggleKey.Size = new System.Drawing.Size(48, 23);
            this.txtCityToggleKey.TabIndex = 23;
            this.txtCityToggleKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activateOnCityButton
            // 
            this.activateOnCityButton.BackColor = System.Drawing.Color.Red;
            this.activateOnCityButton.FlatAppearance.BorderSize = 0;
            this.activateOnCityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateOnCityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateOnCityButton.ForeColor = System.Drawing.SystemColors.Window;
            this.activateOnCityButton.Location = new System.Drawing.Point(8, 16);
            this.activateOnCityButton.Margin = new System.Windows.Forms.Padding(0);
            this.activateOnCityButton.Name = "activateOnCityButton";
            this.activateOnCityButton.Size = new System.Drawing.Size(68, 28);
            this.activateOnCityButton.TabIndex = 21;
            this.activateOnCityButton.Text = "OFF";
            this.activateOnCityButton.UseVisualStyleBackColor = false;
            this.activateOnCityButton.Click += new System.EventHandler(this.activateOnCityButton_Click);
            // 
            // activateOnCityLabel
            // 
            this.activateOnCityLabel.AllowDrop = true;
            this.activateOnCityLabel.AutoSize = true;
            this.activateOnCityLabel.Location = new System.Drawing.Point(8, 49);
            this.activateOnCityLabel.MaximumSize = new System.Drawing.Size(200, 30);
            this.activateOnCityLabel.Name = "activateOnCityLabel";
            this.activateOnCityLabel.Size = new System.Drawing.Size(89, 13);
            this.activateOnCityLabel.TabIndex = 22;
            this.activateOnCityLabel.Text = "To enable on city";
            this.activateOnCityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblStatusHealToggle
            // 
            this.lblStatusHealToggle.AllowDrop = true;
            this.lblStatusHealToggle.AutoSize = true;
            this.lblStatusHealToggle.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusHealToggle.Location = new System.Drawing.Point(2, 46);
            this.lblStatusHealToggle.MaximumSize = new System.Drawing.Size(200, 30);
            this.lblStatusHealToggle.Name = "lblStatusHealToggle";
            this.lblStatusHealToggle.Size = new System.Drawing.Size(143, 13);
            this.lblStatusHealToggle.TabIndex = 22;
            this.lblStatusHealToggle.Text = "Press the key to start healing";
            this.lblStatusHealToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStatusHealToggle
            // 
            this.btnStatusHealToggle.BackColor = System.Drawing.Color.Red;
            this.btnStatusHealToggle.FlatAppearance.BorderSize = 0;
            this.btnStatusHealToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusHealToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatusHealToggle.ForeColor = System.Drawing.SystemColors.Window;
            this.btnStatusHealToggle.Location = new System.Drawing.Point(8, 16);
            this.btnStatusHealToggle.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatusHealToggle.Name = "btnStatusHealToggle";
            this.btnStatusHealToggle.Size = new System.Drawing.Size(68, 28);
            this.btnStatusHealToggle.TabIndex = 21;
            this.btnStatusHealToggle.Text = "OFF";
            this.btnStatusHealToggle.UseVisualStyleBackColor = false;
            this.btnStatusHealToggle.Click += new System.EventHandler(this.btnToggleStatusHealHandler);
            // 
            // txtStatusHealToggleKey
            // 
            this.txtStatusHealToggleKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtStatusHealToggleKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatusHealToggleKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStatusHealToggleKey.ForeColor = System.Drawing.Color.White;
            this.txtStatusHealToggleKey.Location = new System.Drawing.Point(84, 18);
            this.txtStatusHealToggleKey.Name = "txtStatusHealToggleKey";
            this.txtStatusHealToggleKey.Size = new System.Drawing.Size(48, 23);
            this.txtStatusHealToggleKey.TabIndex = 23;
            this.txtStatusHealToggleKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.groupBox2.Controls.Add(this.txtStatusHealToggleKey);
            this.groupBox2.Controls.Add(this.btnStatusHealToggle);
            this.groupBox2.Controls.Add(this.lblStatusHealToggle);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.groupBox2.Location = new System.Drawing.Point(150, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 64);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Heal Status";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.groupBox3.Controls.Add(this.activateOnReinLabel);
            this.groupBox3.Controls.Add(this.txtReinToggleKey);
            this.groupBox3.Controls.Add(this.activateOnReinButton);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.groupBox3.Location = new System.Drawing.Point(150, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(144, 71);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activate on Rein";
            // 
            // activateOnReinLabel
            // 
            this.activateOnReinLabel.AllowDrop = true;
            this.activateOnReinLabel.BackColor = System.Drawing.Color.Transparent;
            this.activateOnReinLabel.Location = new System.Drawing.Point(2, 48);
            this.activateOnReinLabel.MaximumSize = new System.Drawing.Size(200, 30);
            this.activateOnReinLabel.Name = "activateOnReinLabel";
            this.activateOnReinLabel.Size = new System.Drawing.Size(133, 13);
            this.activateOnReinLabel.TabIndex = 22;
            this.activateOnReinLabel.Text = "To enable skills on ridding";
            this.activateOnReinLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReinToggleKey
            // 
            this.txtReinToggleKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtReinToggleKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReinToggleKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtReinToggleKey.ForeColor = System.Drawing.Color.White;
            this.txtReinToggleKey.Location = new System.Drawing.Point(82, 17);
            this.txtReinToggleKey.Name = "txtReinToggleKey";
            this.txtReinToggleKey.Size = new System.Drawing.Size(48, 23);
            this.txtReinToggleKey.TabIndex = 23;
            this.txtReinToggleKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // activateOnReinButton
            // 
            this.activateOnReinButton.BackColor = System.Drawing.Color.Red;
            this.activateOnReinButton.FlatAppearance.BorderSize = 0;
            this.activateOnReinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateOnReinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activateOnReinButton.ForeColor = System.Drawing.SystemColors.Window;
            this.activateOnReinButton.Location = new System.Drawing.Point(5, 14);
            this.activateOnReinButton.Margin = new System.Windows.Forms.Padding(0);
            this.activateOnReinButton.Name = "activateOnReinButton";
            this.activateOnReinButton.Size = new System.Drawing.Size(68, 28);
            this.activateOnReinButton.TabIndex = 21;
            this.activateOnReinButton.Text = "OFF";
            this.activateOnReinButton.UseVisualStyleBackColor = false;
            this.activateOnReinButton.Click += new System.EventHandler(this.activateOnRein_Click);
            // 
            // ToggleApplicationStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(298, 136);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToggleApplicationStateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToggleApplicationStateForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStatusToggle;
        private System.Windows.Forms.Label lblStatusToggle;
        private System.Windows.Forms.TextBox txtStatusToggleKey;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCityToggleKey;
        private System.Windows.Forms.Button activateOnCityButton;
        private System.Windows.Forms.Label activateOnCityLabel;
        private System.Windows.Forms.Label lblStatusHealToggle;
        private System.Windows.Forms.Button btnStatusHealToggle;
        private System.Windows.Forms.TextBox txtStatusHealToggleKey;        
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtReinToggleKey;
        private System.Windows.Forms.Button activateOnReinButton;
        private System.Windows.Forms.Label activateOnReinLabel;
    }
}