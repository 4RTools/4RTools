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
            this.mapbuff = new System.Windows.Forms.Button();
            this.mappot = new System.Windows.Forms.Button();
            this.txtStatusToggleKey = new System.Windows.Forms.TextBox();
            this.btnStatusToggle = new System.Windows.Forms.Button();
            this.lblStatusToggle = new System.Windows.Forms.Label();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mapbuff);
            this.groupBox1.Controls.Add(this.mappot);
            this.groupBox1.Controls.Add(this.txtStatusToggleKey);
            this.groupBox1.Controls.Add(this.btnStatusToggle);
            this.groupBox1.Controls.Add(this.lblStatusToggle);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 114);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Status";
            // 
            // mapbuff
            // 
            this.mapbuff.BackColor = System.Drawing.Color.Green;
            this.mapbuff.FlatAppearance.BorderSize = 0;
            this.mapbuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapbuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapbuff.ForeColor = System.Drawing.SystemColors.Window;
            this.mapbuff.Location = new System.Drawing.Point(82, 52);
            this.mapbuff.Margin = new System.Windows.Forms.Padding(0);
            this.mapbuff.Name = "mapbuff";
            this.mapbuff.Size = new System.Drawing.Size(93, 28);
            this.mapbuff.TabIndex = 25;
            this.mapbuff.Text = "Buff On Map";
            this.mapbuff.UseVisualStyleBackColor = false;
            this.mapbuff.Click += new System.EventHandler(this.mapbufftoggle);
            // 
            // mappot
            // 
            this.mappot.BackColor = System.Drawing.Color.Green;
            this.mappot.FlatAppearance.BorderSize = 0;
            this.mappot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mappot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mappot.ForeColor = System.Drawing.SystemColors.Window;
            this.mappot.Location = new System.Drawing.Point(82, 16);
            this.mappot.Margin = new System.Windows.Forms.Padding(0);
            this.mappot.Name = "mappot";
            this.mappot.Size = new System.Drawing.Size(93, 28);
            this.mappot.TabIndex = 24;
            this.mappot.Text = "Pot On Map";
            this.mappot.UseVisualStyleBackColor = false;
            this.mappot.Click += new System.EventHandler(this.mappottoggle);
            // 
            // txtStatusToggleKey
            // 
            this.txtStatusToggleKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStatusToggleKey.Location = new System.Drawing.Point(6, 54);
            this.txtStatusToggleKey.Name = "txtStatusToggleKey";
            this.txtStatusToggleKey.Size = new System.Drawing.Size(61, 23);
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
            this.btnStatusToggle.Location = new System.Drawing.Point(6, 16);
            this.btnStatusToggle.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatusToggle.Name = "btnStatusToggle";
            this.btnStatusToggle.Size = new System.Drawing.Size(61, 28);
            this.btnStatusToggle.TabIndex = 21;
            this.btnStatusToggle.Text = "OFF";
            this.btnStatusToggle.UseVisualStyleBackColor = false;
            this.btnStatusToggle.Click += new System.EventHandler(this.btnToggleStatusHandler);
            // 
            // lblStatusToggle
            // 
            this.lblStatusToggle.AllowDrop = true;
            this.lblStatusToggle.AutoSize = true;
            this.lblStatusToggle.Location = new System.Drawing.Point(6, 80);
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
            // ToggleApplicationStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(204, 129);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToggleApplicationStateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToggleApplicationStateForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStatusToggle;
        private System.Windows.Forms.Label lblStatusToggle;
        private System.Windows.Forms.TextBox txtStatusToggleKey;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.Button mapbuff;
        private System.Windows.Forms.Button mappot;
    }
}