namespace _4RTools.Forms
{
    partial class AutopotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutopotForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSPpct = new System.Windows.Forms.TextBox();
            this.txtHPpct = new System.Windows.Forms.TextBox();
            this.txtAutopotDelay = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSPKey = new System.Windows.Forms.ComboBox();
            this.cbHPKey = new System.Windows.Forms.ComboBox();
            this.progressBarSP = new System.Windows.Forms.ProgressBar();
            this.progressBarHP = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtSPpct);
            this.panel1.Controls.Add(this.txtHPpct);
            this.panel1.Controls.Add(this.txtAutopotDelay);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbSPKey);
            this.panel1.Controls.Add(this.cbHPKey);
            this.panel1.Controls.Add(this.progressBarSP);
            this.panel1.Controls.Add(this.progressBarHP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 147);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "%";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "%";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtSPpct
            // 
            this.txtSPpct.Location = new System.Drawing.Point(111, 69);
            this.txtSPpct.Name = "txtSPpct";
            this.txtSPpct.Size = new System.Drawing.Size(36, 20);
            this.txtSPpct.TabIndex = 24;
            this.txtSPpct.TextChanged += new System.EventHandler(this.txtSPpct_TextChanged);
            // 
            // txtHPpct
            // 
            this.txtHPpct.Location = new System.Drawing.Point(110, 40);
            this.txtHPpct.Name = "txtHPpct";
            this.txtHPpct.Size = new System.Drawing.Size(37, 20);
            this.txtHPpct.TabIndex = 23;
            this.txtHPpct.TextChanged += new System.EventHandler(this.txtHPpct_TextChanged);
            // 
            // txtAutopotDelay
            // 
            this.txtAutopotDelay.Location = new System.Drawing.Point(13, 105);
            this.txtAutopotDelay.Name = "txtAutopotDelay";
            this.txtAutopotDelay.Size = new System.Drawing.Size(40, 20);
            this.txtAutopotDelay.TabIndex = 22;
            this.txtAutopotDelay.TextChanged += new System.EventHandler(this.txtAutopotDelay_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 71);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 28);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cbSPKey
            // 
            this.cbSPKey.DisplayMember = "Key";
            this.cbSPKey.FormattingEnabled = true;
            this.cbSPKey.Location = new System.Drawing.Point(43, 71);
            this.cbSPKey.Name = "cbSPKey";
            this.cbSPKey.Size = new System.Drawing.Size(61, 21);
            this.cbSPKey.TabIndex = 19;
            this.cbSPKey.ValueMember = "Value";
            this.cbSPKey.SelectedIndexChanged += new System.EventHandler(this.cbSPKey_SelectedIndexChanged);
            // 
            // cbHPKey
            // 
            this.cbHPKey.DisplayMember = "Key";
            this.cbHPKey.FormattingEnabled = true;
            this.cbHPKey.Location = new System.Drawing.Point(43, 40);
            this.cbHPKey.Name = "cbHPKey";
            this.cbHPKey.Size = new System.Drawing.Size(61, 21);
            this.cbHPKey.TabIndex = 18;
            this.cbHPKey.ValueMember = "Value";
            this.cbHPKey.SelectedIndexChanged += new System.EventHandler(this.cbHPKey_SelectedIndexChanged);
            // 
            // progressBarSP
            // 
            this.progressBarSP.ForeColor = System.Drawing.Color.Blue;
            this.progressBarSP.Location = new System.Drawing.Point(173, 69);
            this.progressBarSP.Name = "progressBarSP";
            this.progressBarSP.Size = new System.Drawing.Size(110, 23);
            this.progressBarSP.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarSP.TabIndex = 17;
            this.progressBarSP.Click += new System.EventHandler(this.progressBarSP_Click);
            // 
            // progressBarHP
            // 
            this.progressBarHP.ForeColor = System.Drawing.Color.HotPink;
            this.progressBarHP.Location = new System.Drawing.Point(173, 38);
            this.progressBarHP.Name = "progressBarHP";
            this.progressBarHP.Size = new System.Drawing.Size(110, 23);
            this.progressBarHP.TabIndex = 16;
            this.progressBarHP.Click += new System.EventHandler(this.progressBarHP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(59, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Delay (ms)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AutopotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 170);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutopotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AutopotForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbSPKey;
        private System.Windows.Forms.ComboBox cbHPKey;
        private System.Windows.Forms.ProgressBar progressBarSP;
        private System.Windows.Forms.ProgressBar progressBarHP;
        private System.Windows.Forms.TextBox txtAutopotDelay;
        private System.Windows.Forms.TextBox txtSPpct;
        private System.Windows.Forms.TextBox txtHPpct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}