namespace _4RTools
{
    partial class Application
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.processCB = new System.Windows.Forms.ComboBox();
            this.lblProcessName = new System.Windows.Forms.Label();
            this.progressBarHP = new System.Windows.Forms.ProgressBar();
            this.progressBarSP = new System.Windows.Forms.ProgressBar();
            this.txtHPDelay = new System.Windows.Forms.RichTextBox();
            this.cbHPKey = new System.Windows.Forms.ComboBox();
            this.cbSPKey = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // processCB
            // 
            this.processCB.FormattingEnabled = true;
            this.processCB.Location = new System.Drawing.Point(839, 30);
            this.processCB.Name = "processCB";
            this.processCB.Size = new System.Drawing.Size(173, 21);
            this.processCB.TabIndex = 0;
            this.processCB.SelectedIndexChanged += new System.EventHandler(this.processCB_SelectedIndexChanged);
            // 
            // lblProcessName
            // 
            this.lblProcessName.AutoSize = true;
            this.lblProcessName.Location = new System.Drawing.Point(836, 14);
            this.lblProcessName.Name = "lblProcessName";
            this.lblProcessName.Size = new System.Drawing.Size(126, 13);
            this.lblProcessName.TabIndex = 1;
            this.lblProcessName.Text = "Ragnarok Process Name";
            // 
            // progressBarHP
            // 
            this.progressBarHP.ForeColor = System.Drawing.Color.HotPink;
            this.progressBarHP.Location = new System.Drawing.Point(40, 30);
            this.progressBarHP.Name = "progressBarHP";
            this.progressBarHP.Size = new System.Drawing.Size(140, 23);
            this.progressBarHP.TabIndex = 2;
            // 
            // progressBarSP
            // 
            this.progressBarSP.ForeColor = System.Drawing.Color.Blue;
            this.progressBarSP.Location = new System.Drawing.Point(40, 59);
            this.progressBarSP.Name = "progressBarSP";
            this.progressBarSP.Size = new System.Drawing.Size(140, 23);
            this.progressBarSP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSP.TabIndex = 3;
            // 
            // txtHPDelay
            // 
            this.txtHPDelay.Location = new System.Drawing.Point(253, 30);
            this.txtHPDelay.Name = "txtHPDelay";
            this.txtHPDelay.Size = new System.Drawing.Size(50, 23);
            this.txtHPDelay.TabIndex = 8;
            this.txtHPDelay.Text = "";
            // 
            // cbHPKey
            // 
            this.cbHPKey.FormattingEnabled = true;
            this.cbHPKey.Location = new System.Drawing.Point(186, 32);
            this.cbHPKey.Name = "cbHPKey";
            this.cbHPKey.Size = new System.Drawing.Size(61, 21);
            this.cbHPKey.TabIndex = 9;
            this.cbHPKey.ValueMember = "Value";
            this.cbHPKey.DisplayMember = "Key";
            // 
            // cbSPKey
            // 
            this.cbSPKey.FormattingEnabled = true;
            this.cbSPKey.Location = new System.Drawing.Point(186, 61);
            this.cbSPKey.Name = "cbSPKey";
            this.cbSPKey.Size = new System.Drawing.Size(61, 21);
            this.cbSPKey.TabIndex = 10;
            this.cbSPKey.ValueMember = "Value";
            this.cbSPKey.DisplayMember = "Key";
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.cbSPKey);
            this.Controls.Add(this.cbHPKey);
            this.Controls.Add(this.txtHPDelay);
            this.Controls.Add(this.progressBarSP);
            this.Controls.Add(this.progressBarHP);
            this.Controls.Add(this.lblProcessName);
            this.Controls.Add(this.processCB);
            this.Name = "Application";
            this.Text = "4RTools";
            this.Load += new System.EventHandler(this.OnLoadApplication);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox processCB;
        private System.Windows.Forms.Label lblProcessName;
        private System.Windows.Forms.ProgressBar progressBarHP;
        private System.Windows.Forms.ProgressBar progressBarSP;
        private System.Windows.Forms.RichTextBox txtHPDelay;
        private System.Windows.Forms.ComboBox cbHPKey;
        private System.Windows.Forms.ComboBox cbSPKey;
    }
}

