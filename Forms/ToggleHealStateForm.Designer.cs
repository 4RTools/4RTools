namespace _4RTools.Forms
{
    partial class ToggleHealStateForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToggleHealStateForm));
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtStatusToggleKey = new System.Windows.Forms.TextBox();
      this.btnStatusToggle = new System.Windows.Forms.Button();
      this.lblStatusToggle = new System.Windows.Forms.Label();
      this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
      this.groupBox1.SuspendLayout();
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
      this.groupBox1.Size = new System.Drawing.Size(144, 94);
      this.groupBox1.TabIndex = 25;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Heal Status";
      // 
      // txtStatusToggleKey
      // 
      this.txtStatusToggleKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
      this.txtStatusToggleKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtStatusToggleKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
      this.txtStatusToggleKey.ForeColor = System.Drawing.Color.White;
      this.txtStatusToggleKey.Location = new System.Drawing.Point(84, 25);
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
      this.btnStatusToggle.Location = new System.Drawing.Point(8, 23);
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
      this.lblStatusToggle.BackColor = System.Drawing.Color.Transparent;
      this.lblStatusToggle.Location = new System.Drawing.Point(2, 61);
      this.lblStatusToggle.MaximumSize = new System.Drawing.Size(200, 30);
      this.lblStatusToggle.Name = "lblStatusToggle";
      this.lblStatusToggle.Size = new System.Drawing.Size(143, 13);
      this.lblStatusToggle.TabIndex = 22;
      this.lblStatusToggle.Text = "Press the key to start healing";
      this.lblStatusToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // notifyIconTray
      // 
      this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
      this.notifyIconTray.Text = "4ROTools";
      this.notifyIconTray.Visible = true;
      this.notifyIconTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconDoubleClick);
      // 
      // ToggleHealStateForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
      this.ClientSize = new System.Drawing.Size(149, 99);
      this.Controls.Add(this.groupBox1);
      this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "ToggleHealStateForm";
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
    }
}