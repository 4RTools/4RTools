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
            this.txtSPpct = new System.Windows.Forms.RichTextBox();
            this.txtHPpct = new System.Windows.Forms.RichTextBox();
            this.labelSP = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.txtAutopotDelay = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbSPKey = new System.Windows.Forms.ComboBox();
            this.cbHPKey = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSPpct);
            this.panel1.Controls.Add(this.txtHPpct);
            this.panel1.Controls.Add(this.labelSP);
            this.panel1.Controls.Add(this.labelHP);
            this.panel1.Controls.Add(this.txtAutopotDelay);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.cbSPKey);
            this.panel1.Controls.Add(this.cbHPKey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 119);
            this.panel1.TabIndex = 1;
            // 
            // txtSPpct
            // 
            this.txtSPpct.Location = new System.Drawing.Point(110, 54);
            this.txtSPpct.Name = "txtSPpct";
            this.txtSPpct.Size = new System.Drawing.Size(43, 21);
            this.txtSPpct.TabIndex = 28;
            this.txtSPpct.Text = "";
            // 
            // txtHPpct
            // 
            this.txtHPpct.Location = new System.Drawing.Point(110, 20);
            this.txtHPpct.Name = "txtHPpct";
            this.txtHPpct.Size = new System.Drawing.Size(43, 21);
            this.txtHPpct.TabIndex = 27;
            this.txtHPpct.Text = "";
            this.txtHPpct.TextChanged += new System.EventHandler(this.txtSPpct_TextChanged);
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSP.Location = new System.Drawing.Point(152, 55);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(20, 17);
            this.labelSP.TabIndex = 26;
            this.labelSP.Text = "%";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHP.Location = new System.Drawing.Point(151, 22);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(20, 17);
            this.labelHP.TabIndex = 25;
            this.labelHP.Text = "%";
            // 
            // txtAutopotDelay
            // 
            this.txtAutopotDelay.Location = new System.Drawing.Point(12, 83);
            this.txtAutopotDelay.Name = "txtAutopotDelay";
            this.txtAutopotDelay.Size = new System.Drawing.Size(40, 20);
            this.txtAutopotDelay.TabIndex = 22;
            this.txtAutopotDelay.TextChanged += new System.EventHandler(this.txtAutopotDelay_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // cbSPKey
            // 
            this.cbSPKey.DisplayMember = "Key";
            this.cbSPKey.FormattingEnabled = true;
            this.cbSPKey.Location = new System.Drawing.Point(43, 54);
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
            this.cbHPKey.Location = new System.Drawing.Point(43, 20);
            this.cbHPKey.Name = "cbHPKey";
            this.cbHPKey.Size = new System.Drawing.Size(61, 21);
            this.cbHPKey.TabIndex = 18;
            this.cbHPKey.ValueMember = "Value";
            this.cbHPKey.SelectedIndexChanged += new System.EventHandler(this.cbHPKey_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(58, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Delay (ms)";
            // 
            // AutopotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(210, 143);
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
        private System.Windows.Forms.TextBox txtAutopotDelay;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.RichTextBox txtSPpct;
        private System.Windows.Forms.RichTextBox txtHPpct;
    }
}