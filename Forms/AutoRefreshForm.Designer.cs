using _4RTools.Utils;

namespace _4RTools.Forms
{
    partial class AutoRefreshForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRefreshKey = new System.Windows.Forms.ComboBox();
            this.txtAutoRefreshDelay = new System.Windows.Forms.TextBox();
            this.lblAutoRefreshKey = new System.Windows.Forms.Label();
            this.lblAutoRefreshDelay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.cbRefreshKey);
            this.groupBox1.Controls.Add(this.txtAutoRefreshDelay);
            this.groupBox1.Controls.Add(this.lblAutoRefreshKey);
            this.groupBox1.Controls.Add(this.lblAutoRefreshDelay);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(0, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 85);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Auto-Refresh";
            // 
            // cbRefreshKey
            // 
            this.cbRefreshKey.DisplayMember = "Key";
            this.cbRefreshKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbRefreshKey.FormattingEnabled = true;
            this.cbRefreshKey.Location = new System.Drawing.Point(86, 50);
            this.cbRefreshKey.Name = "cbRefreshKey";
            this.cbRefreshKey.Size = new System.Drawing.Size(69, 24);
            this.cbRefreshKey.TabIndex = 3;
            this.cbRefreshKey.ValueMember = "Value";
            this.cbRefreshKey.SelectedIndexChanged += new System.EventHandler(this.autoRefreshKeyIndexChanged);
            // 
            // txtAutoRefreshDelay
            // 
            this.txtAutoRefreshDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAutoRefreshDelay.Location = new System.Drawing.Point(84, 21);
            this.txtAutoRefreshDelay.Name = "txtAutoRefreshDelay";
            this.txtAutoRefreshDelay.Size = new System.Drawing.Size(69, 23);
            this.txtAutoRefreshDelay.TabIndex = 2;
            this.txtAutoRefreshDelay.TextChanged += new System.EventHandler(this.txtAutoRefreshDelayTextChanged);
            // 
            // lblAutoRefreshKey
            // 
            this.lblAutoRefreshKey.AutoSize = true;
            this.lblAutoRefreshKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblAutoRefreshKey.Location = new System.Drawing.Point(7, 55);
            this.lblAutoRefreshKey.Name = "lblAutoRefreshKey";
            this.lblAutoRefreshKey.Size = new System.Drawing.Size(73, 15);
            this.lblAutoRefreshKey.TabIndex = 1;
            this.lblAutoRefreshKey.Text = "Refresh Key";
            // 
            // lblAutoRefreshDelay
            // 
            this.lblAutoRefreshDelay.AutoSize = true;
            this.lblAutoRefreshDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblAutoRefreshDelay.Location = new System.Drawing.Point(17, 25);
            this.lblAutoRefreshDelay.Name = "lblAutoRefreshDelay";
            this.lblAutoRefreshDelay.Size = new System.Drawing.Size(63, 15);
            this.lblAutoRefreshDelay.TabIndex = 0;
            this.lblAutoRefreshDelay.Text = "Delay(ms)";
            this.lblAutoRefreshDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutoRefreshForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(182, 88);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoRefreshForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AutoRefreshForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbRefreshKey;
        private System.Windows.Forms.TextBox txtAutoRefreshDelay;
        private System.Windows.Forms.Label lblAutoRefreshKey;
        private System.Windows.Forms.Label lblAutoRefreshDelay;
    }
}