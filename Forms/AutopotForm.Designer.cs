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
            this.txtHPpct = new System.Windows.Forms.NumericUpDown();
            this.labelSP = new System.Windows.Forms.Label();
            this.labelHP = new System.Windows.Forms.Label();
            this.txtAutopotDelay = new System.Windows.Forms.TextBox();
            this.picBoxSP = new System.Windows.Forms.PictureBox();
            this.picBoxHP = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHpKey = new System.Windows.Forms.TextBox();
            this.txtSPKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSPpct = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtHPpct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPpct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHPpct
            // 
            this.txtHPpct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtHPpct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHPpct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHPpct.ForeColor = System.Drawing.Color.White;
            this.txtHPpct.Location = new System.Drawing.Point(133, 12);
            this.txtHPpct.Name = "txtHPpct";
            this.txtHPpct.Size = new System.Drawing.Size(44, 23);
            this.txtHPpct.TabIndex = 39;
            this.txtHPpct.ValueChanged += new System.EventHandler(this.txtHPpctTextChanged);
            // 
            // labelSP
            // 
            this.labelSP.AutoSize = true;
            this.labelSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSP.Location = new System.Drawing.Point(179, 40);
            this.labelSP.Name = "labelSP";
            this.labelSP.Size = new System.Drawing.Size(20, 17);
            this.labelSP.TabIndex = 38;
            this.labelSP.Text = "%";
            // 
            // labelHP
            // 
            this.labelHP.AutoSize = true;
            this.labelHP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelHP.Location = new System.Drawing.Point(179, 15);
            this.labelHP.Name = "labelHP";
            this.labelHP.Size = new System.Drawing.Size(20, 17);
            this.labelHP.TabIndex = 37;
            this.labelHP.Text = "%";
            // 
            // txtAutopotDelay
            // 
            this.txtAutopotDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtAutopotDelay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutopotDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAutopotDelay.ForeColor = System.Drawing.Color.White;
            this.txtAutopotDelay.Location = new System.Drawing.Point(133, 64);
            this.txtAutopotDelay.Name = "txtAutopotDelay";
            this.txtAutopotDelay.Size = new System.Drawing.Size(44, 23);
            this.txtAutopotDelay.TabIndex = 36;
            this.txtAutopotDelay.TextChanged += new System.EventHandler(this.txtAutopotDelayTextChanged);
            // 
            // picBoxSP
            // 
            this.picBoxSP.BackColor = System.Drawing.Color.Transparent;
            this.picBoxSP.Image = global::_4RTools.Resources._4RTools.ETCResource.SP;
            this.picBoxSP.Location = new System.Drawing.Point(22, 37);
            this.picBoxSP.Name = "picBoxSP";
            this.picBoxSP.Size = new System.Drawing.Size(25, 25);
            this.picBoxSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxSP.TabIndex = 35;
            this.picBoxSP.TabStop = false;
            // 
            // picBoxHP
            // 
            this.picBoxHP.BackColor = System.Drawing.Color.Transparent;
            this.picBoxHP.Image = global::_4RTools.Resources._4RTools.ETCResource.HP;
            this.picBoxHP.Location = new System.Drawing.Point(22, 11);
            this.picBoxHP.Name = "picBoxHP";
            this.picBoxHP.Size = new System.Drawing.Size(25, 25);
            this.picBoxHP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBoxHP.TabIndex = 34;
            this.picBoxHP.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(89, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Delay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(178, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "ms";
            // 
            // txtHpKey
            // 
            this.txtHpKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtHpKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHpKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtHpKey.ForeColor = System.Drawing.Color.White;
            this.txtHpKey.Location = new System.Drawing.Point(67, 12);
            this.txtHpKey.Name = "txtHpKey";
            this.txtHpKey.Size = new System.Drawing.Size(61, 23);
            this.txtHpKey.TabIndex = 43;
            // 
            // txtSPKey
            // 
            this.txtSPKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtSPKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSPKey.ForeColor = System.Drawing.Color.White;
            this.txtSPKey.Location = new System.Drawing.Point(67, 38);
            this.txtSPKey.Name = "txtSPKey";
            this.txtSPKey.Size = new System.Drawing.Size(61, 23);
            this.txtSPKey.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "HP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "SP";
            // 
            // txtSPpct
            // 
            this.txtSPpct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtSPpct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSPpct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSPpct.ForeColor = System.Drawing.Color.White;
            this.txtSPpct.Location = new System.Drawing.Point(133, 38);
            this.txtSPpct.Name = "txtSPpct";
            this.txtSPpct.Size = new System.Drawing.Size(44, 23);
            this.txtSPpct.TabIndex = 40;
            this.txtSPpct.ValueChanged += new System.EventHandler(this.txtSPpctTextChanged);
            // 
            // AutopotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(224, 100);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSPKey);
            this.Controls.Add(this.txtHpKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSPpct);
            this.Controls.Add(this.txtHPpct);
            this.Controls.Add(this.labelSP);
            this.Controls.Add(this.labelHP);
            this.Controls.Add(this.txtAutopotDelay);
            this.Controls.Add(this.picBoxSP);
            this.Controls.Add(this.picBoxHP);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutopotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AutopotForm";
            ((System.ComponentModel.ISupportInitialize)(this.txtHPpct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSPpct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown txtHPpct;
        private System.Windows.Forms.Label labelSP;
        private System.Windows.Forms.Label labelHP;
        private System.Windows.Forms.TextBox txtAutopotDelay;
        private System.Windows.Forms.PictureBox picBoxSP;
        private System.Windows.Forms.PictureBox picBoxHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHpKey;
        private System.Windows.Forms.TextBox txtSPKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtSPpct;
    }
}