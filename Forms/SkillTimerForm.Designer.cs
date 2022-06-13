namespace _4RTools.Forms
{
    partial class SkillTimerForm
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
            this.txtAutoRefreshDelay = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAutoRefreshKey = new System.Windows.Forms.Label();
            this.lblAutoRefreshDelay = new System.Windows.Forms.Label();
            this.txtSkillTimerKey = new _4RTools.Components._4RTextInput();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutoRefreshDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAutoRefreshDelay
            // 
            this.txtAutoRefreshDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAutoRefreshDelay.Location = new System.Drawing.Point(50, 12);
            this.txtAutoRefreshDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtAutoRefreshDelay.Name = "txtAutoRefreshDelay";
            this.txtAutoRefreshDelay.Size = new System.Drawing.Size(43, 23);
            this.txtAutoRefreshDelay.TabIndex = 39;
            this.txtAutoRefreshDelay.ValueChanged += new System.EventHandler(this.onSkillTimerDelayChange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(99, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "seconds press";
            // 
            // lblAutoRefreshKey
            // 
            this.lblAutoRefreshKey.AutoSize = true;
            this.lblAutoRefreshKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblAutoRefreshKey.Location = new System.Drawing.Point(254, 17);
            this.lblAutoRefreshKey.Name = "lblAutoRefreshKey";
            this.lblAutoRefreshKey.Size = new System.Drawing.Size(25, 15);
            this.lblAutoRefreshKey.TabIndex = 36;
            this.lblAutoRefreshKey.Text = "key";
            // 
            // lblAutoRefreshDelay
            // 
            this.lblAutoRefreshDelay.AutoSize = true;
            this.lblAutoRefreshDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblAutoRefreshDelay.Location = new System.Drawing.Point(9, 16);
            this.lblAutoRefreshDelay.Name = "lblAutoRefreshDelay";
            this.lblAutoRefreshDelay.Size = new System.Drawing.Size(36, 15);
            this.lblAutoRefreshDelay.TabIndex = 35;
            this.lblAutoRefreshDelay.Text = "Every";
            this.lblAutoRefreshDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSkillTimerKey
            // 
            this.txtSkillTimerKey.BackColor = System.Drawing.Color.Transparent;
            this.txtSkillTimerKey.BorderSize = 2;
            this.txtSkillTimerKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSkillTimerKey.ForeColor = System.Drawing.Color.DimGray;
            this.txtSkillTimerKey.InputName = "_4RTextInput";
            this.txtSkillTimerKey.Location = new System.Drawing.Point(189, 11);
            this.txtSkillTimerKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSkillTimerKey.Name = "txtSkillTimerKey";
            this.txtSkillTimerKey.Padding = new System.Windows.Forms.Padding(7);
            this.txtSkillTimerKey.Size = new System.Drawing.Size(61, 30);
            this.txtSkillTimerKey.TabIndex = 40;
            this.txtSkillTimerKey.UnderlinedStyle = false;
            this.txtSkillTimerKey.Value = "";
            this.txtSkillTimerKey._TextChanged += new System.EventHandler(this.onSkillTimerKeyChange);
            // 
            // SkillTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 51);
            this.Controls.Add(this.txtSkillTimerKey);
            this.Controls.Add(this.txtAutoRefreshDelay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAutoRefreshKey);
            this.Controls.Add(this.lblAutoRefreshDelay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SkillTimerForm";
            this.Text = "SkillTimerForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtAutoRefreshDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtAutoRefreshDelay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAutoRefreshKey;
        private System.Windows.Forms.Label lblAutoRefreshDelay;
        private Components._4RTextInput txtSkillTimerKey;
    }
}