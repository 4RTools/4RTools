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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoRefreshForm));
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
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbRefreshKey);
            this.groupBox1.Controls.Add(this.txtAutoRefreshDelay);
            this.groupBox1.Controls.Add(this.lblAutoRefreshKey);
            this.groupBox1.Controls.Add(this.lblAutoRefreshDelay);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cbRefreshKey
            // 
            resources.ApplyResources(this.cbRefreshKey, "cbRefreshKey");
            this.cbRefreshKey.DisplayMember = "Key";
            this.cbRefreshKey.FormattingEnabled = true;
            this.cbRefreshKey.Name = "cbRefreshKey";
            this.cbRefreshKey.ValueMember = "Value";
            this.cbRefreshKey.SelectedIndexChanged += new System.EventHandler(this.autoRefreshKeyIndexChanged);
            // 
            // txtAutoRefreshDelay
            // 
            resources.ApplyResources(this.txtAutoRefreshDelay, "txtAutoRefreshDelay");
            this.txtAutoRefreshDelay.Name = "txtAutoRefreshDelay";
            this.txtAutoRefreshDelay.TextChanged += new System.EventHandler(this.txtAutoRefreshDelayTextChanged);
            // 
            // lblAutoRefreshKey
            // 
            resources.ApplyResources(this.lblAutoRefreshKey, "lblAutoRefreshKey");
            this.lblAutoRefreshKey.Name = "lblAutoRefreshKey";
            // 
            // lblAutoRefreshDelay
            // 
            resources.ApplyResources(this.lblAutoRefreshDelay, "lblAutoRefreshDelay");
            this.lblAutoRefreshDelay.Name = "lblAutoRefreshDelay";
            // 
            // AutoRefreshForm
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutoRefreshForm";
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