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
            this.txtSkillTimerKey = new System.Windows.Forms.TextBox();
            this.lblAutoRefreshKey = new System.Windows.Forms.Label();
            this.lblAutoRefreshDelay = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtAutoRefreshDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAutoRefreshDelay
            // 
            this.txtAutoRefreshDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtAutoRefreshDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutoRefreshDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAutoRefreshDelay.ForeColor = System.Drawing.Color.White;
            this.txtAutoRefreshDelay.Location = new System.Drawing.Point(93, 22);
            this.txtAutoRefreshDelay.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtAutoRefreshDelay.Name = "txtAutoRefreshDelay";
            this.txtAutoRefreshDelay.Size = new System.Drawing.Size(61, 23);
            this.txtAutoRefreshDelay.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.label2.Location = new System.Drawing.Point(154, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "sec";
            // 
            // txtSkillTimerKey
            // 
            this.txtSkillTimerKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtSkillTimerKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSkillTimerKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSkillTimerKey.ForeColor = System.Drawing.Color.White;
            this.txtSkillTimerKey.Location = new System.Drawing.Point(93, 50);
            this.txtSkillTimerKey.Name = "txtSkillTimerKey";
            this.txtSkillTimerKey.Size = new System.Drawing.Size(61, 23);
            this.txtSkillTimerKey.TabIndex = 4;
            // 
            // lblAutoRefreshKey
            // 
            this.lblAutoRefreshKey.AutoSize = true;
            this.lblAutoRefreshKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblAutoRefreshKey.Location = new System.Drawing.Point(63, 54);
            this.lblAutoRefreshKey.Name = "lblAutoRefreshKey";
            this.lblAutoRefreshKey.Size = new System.Drawing.Size(27, 15);
            this.lblAutoRefreshKey.TabIndex = 1;
            this.lblAutoRefreshKey.Text = "Key";
            // 
            // lblAutoRefreshDelay
            // 
            this.lblAutoRefreshDelay.AutoSize = true;
            this.lblAutoRefreshDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.lblAutoRefreshDelay.Location = new System.Drawing.Point(49, 26);
            this.lblAutoRefreshDelay.Name = "lblAutoRefreshDelay";
            this.lblAutoRefreshDelay.Size = new System.Drawing.Size(38, 15);
            this.lblAutoRefreshDelay.TabIndex = 0;
            this.lblAutoRefreshDelay.Text = "Delay";
            this.lblAutoRefreshDelay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SkillTimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(225, 101);
            this.Controls.Add(this.txtAutoRefreshDelay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSkillTimerKey);
            this.Controls.Add(this.lblAutoRefreshDelay);
            this.Controls.Add(this.lblAutoRefreshKey);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
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
        private System.Windows.Forms.TextBox txtSkillTimerKey;
        private System.Windows.Forms.Label lblAutoRefreshKey;
        private System.Windows.Forms.Label lblAutoRefreshDelay;
    }
}