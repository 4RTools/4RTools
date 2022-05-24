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
            this.btnStatusToggle = new System.Windows.Forms.Button();
            this.notifyIconTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtStatusToggleKey = new _4RTools.Components._4RTextInput();
            this.SuspendLayout();
            // 
            // btnStatusToggle
            // 
            this.btnStatusToggle.BackColor = System.Drawing.Color.Transparent;
            this.btnStatusToggle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStatusToggle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStatusToggle.FlatAppearance.BorderSize = 0;
            this.btnStatusToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatusToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnStatusToggle.ForeColor = System.Drawing.Color.Transparent;
            this.btnStatusToggle.Image = ((System.Drawing.Image)(resources.GetObject("btnStatusToggle.Image")));
            this.btnStatusToggle.Location = new System.Drawing.Point(72, -1);
            this.btnStatusToggle.Margin = new System.Windows.Forms.Padding(0);
            this.btnStatusToggle.Name = "btnStatusToggle";
            this.btnStatusToggle.Size = new System.Drawing.Size(33, 30);
            this.btnStatusToggle.TabIndex = 21;
            this.btnStatusToggle.UseVisualStyleBackColor = false;
            this.btnStatusToggle.Click += new System.EventHandler(this.btnToggleStatusHandler);
            // 
            // notifyIconTray
            // 
            this.notifyIconTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconTray.Icon")));
            this.notifyIconTray.Text = "4ROTools";
            this.notifyIconTray.Visible = true;
            this.notifyIconTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconDoubleClick);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Lucida Sans", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(111, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(81, 19);
            this.lblStatus.TabIndex = 24;
            this.lblStatus.Text = "Stopped";
            // 
            // txtStatusToggleKey
            // 
            this.txtStatusToggleKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.txtStatusToggleKey.BorderSize = 2;
            this.txtStatusToggleKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusToggleKey.ForeColor = System.Drawing.Color.DimGray;
            this.txtStatusToggleKey.Location = new System.Drawing.Point(2, 1);
            this.txtStatusToggleKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtStatusToggleKey.Name = "txtStatusToggleKey";
            this.txtStatusToggleKey.Padding = new System.Windows.Forms.Padding(7);
            this.txtStatusToggleKey.Size = new System.Drawing.Size(61, 30);
            this.txtStatusToggleKey.TabIndex = 25;
            this.txtStatusToggleKey.UnderlinedStyle = false;
            this.txtStatusToggleKey.Value = "";
            // 
            // ToggleApplicationStateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(191, 33);
            this.Controls.Add(this.txtStatusToggleKey);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStatusToggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ToggleApplicationStateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ToggleApplicationStateForm";
            this.Load += new System.EventHandler(this.ToggleApplicationStateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStatusToggle;
        private System.Windows.Forms.NotifyIcon notifyIconTray;
        private System.Windows.Forms.Label lblStatus;
        private Components._4RTextInput txtStatusToggleKey;
    }
}