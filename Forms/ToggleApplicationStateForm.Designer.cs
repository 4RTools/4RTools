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
            this.lblStatusHealToggle = new System.Windows.Forms.Label();
            this.btnStatusHealToggle = new System.Windows.Forms.Button();
            this.txtStatusHealToggleKey = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // ToggleApplicationStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(298, 136);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToggleApplicationStateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToggleApplicationStateForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStatusToggle;
        private System.Windows.Forms.Label lblStatusToggle;
        private System.Windows.Forms.TextBox txtStatusToggleKey;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.Label lblStatusHealToggle;
        private System.Windows.Forms.Button btnStatusHealToggle;
        private System.Windows.Forms.TextBox txtStatusHealToggleKey;        
        private System.Windows.Forms.GroupBox groupBox2;
    }
}