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
            this.txtSPpct = new System.Windows.Forms.NumericUpDown();
            this.txtHPpct = new System.Windows.Forms.NumericUpDown();
            this.labelSP = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.txtAutopotDelay = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHpKey = new System.Windows.Forms.TextBox();
            this.txtSPKey = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPpct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHPpct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSPpct
            // 
            this.txtSPpct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSPpct.Location = new System.Drawing.Point(102, 41);
            this.txtSPpct.Name = "txtSPpct";
            this.txtSPpct.Size = new System.Drawing.Size(44, 23);
            this.txtSPpct.TabIndex = 40;
            this.txtSPpct.ValueChanged += new System.EventHandler(this.txtSPpctTextChanged);
            // 
            // txtHPpct
            // 
            this.txtHPpct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHPpct.Location = new System.Drawing.Point(102, 12);
            this.txtHPpct.Name = "txtHPpct";
            this.txtHPpct.Size = new System.Drawing.Size(44, 23);
            this.txtHPpct.TabIndex = 39;
            this.txtHPpct.ValueChanged += new System.EventHandler(this.txtHPpctTextChanged);
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSP.Location = new System.Drawing.Point(148, 44);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(20, 17);
            this.labelSP.TabIndex = 38;
            this.labelSP.Text = "%";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHP.Location = new System.Drawing.Point(148, 15);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(20, 17);
            this.labelHP.TabIndex = 37;
            this.labelHP.Text = "%";
            // 
            // txtAutopotDelay
            // 
            this.txtAutopotDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAutopotDelay.Location = new System.Drawing.Point(102, 70);
            this.txtAutopotDelay.Name = "txtAutopotDelay";
            this.txtAutopotDelay.Size = new System.Drawing.Size(44, 23);
            this.txtAutopotDelay.TabIndex = 36;
            this.txtAutopotDelay.TextChanged += new System.EventHandler(this.txtAutopotDelayTextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(56, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Delay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(148, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "ms";
            // 
            // txtHpKey
            // 
            this.txtHpKey.Location = new System.Drawing.Point(38, 14);
            this.txtHpKey.Name = "txtHpKey";
            this.txtHpKey.Size = new System.Drawing.Size(61, 20);
            this.txtHpKey.TabIndex = 43;
            // 
            // txtSPKey
            // 
            this.txtSPKey.Location = new System.Drawing.Point(38, 43);
            this.txtSPKey.Name = "txtSPKey";
            this.txtSPKey.Size = new System.Drawing.Size(61, 20);
            this.txtSPKey.TabIndex = 44;
            // 
            // AutopotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(177, 100);
            this.Controls.Add(this.txtSPKey);
            this.Controls.Add(this.txtHpKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSPpct);
            this.Controls.Add(this.txtHPpct);
            this.Controls.Add(this.labelSP);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.txtAutopotDelay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutopotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AutopotForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtSPpct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHPpct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtSPpct;
        private System.Windows.Forms.NumericUpDown txtHPpct;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.TextBox txtAutopotDelay;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHpKey;
        private System.Windows.Forms.TextBox txtSPKey;
    }
}