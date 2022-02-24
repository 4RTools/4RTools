namespace _4RTools.Forms
{
    partial class StatusEffectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusEffectForm));
            this.radioPanacea = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioGreenPotion = new System.Windows.Forms.RadioButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.radioRoyalJelly = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblKeyStatusEffect = new System.Windows.Forms.Label();
            this.cbStatusEffectKey = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioPanacea
            // 
            this.radioPanacea.AutoSize = true;
            this.radioPanacea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioPanacea.Location = new System.Drawing.Point(62, 29);
            this.radioPanacea.Name = "radioPanacea";
            this.radioPanacea.Size = new System.Drawing.Size(82, 21);
            this.radioPanacea.TabIndex = 3;
            this.radioPanacea.Text = "Panacea";
            this.radioPanacea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioPanacea.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // radioGreenPotion
            // 
            this.radioGreenPotion.AutoSize = true;
            this.radioGreenPotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioGreenPotion.Location = new System.Drawing.Point(62, 60);
            this.radioGreenPotion.Name = "radioGreenPotion";
            this.radioGreenPotion.Size = new System.Drawing.Size(110, 21);
            this.radioGreenPotion.TabIndex = 1;
            this.radioGreenPotion.Text = "Green Potion";
            this.radioGreenPotion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioGreenPotion.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 88);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 26);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // radioRoyalJelly
            // 
            this.radioRoyalJelly.AutoSize = true;
            this.radioRoyalJelly.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioRoyalJelly.Location = new System.Drawing.Point(62, 91);
            this.radioRoyalJelly.Name = "radioRoyalJelly";
            this.radioRoyalJelly.Size = new System.Drawing.Size(94, 21);
            this.radioRoyalJelly.TabIndex = 4;
            this.radioRoyalJelly.Text = "Royal Jelly";
            this.radioRoyalJelly.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.radioRoyalJelly.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(10, 26);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox1.Controls.Add(this.cbStatusEffectKey);
            this.groupBox1.Controls.Add(this.lblKeyStatusEffect);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.radioRoyalJelly);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.radioGreenPotion);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.radioPanacea);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(2, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 153);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // lblKeyStatusEffect
            // 
            this.lblKeyStatusEffect.AutoSize = true;
            this.lblKeyStatusEffect.Location = new System.Drawing.Point(24, 125);
            this.lblKeyStatusEffect.Name = "lblKeyStatusEffect";
            this.lblKeyStatusEffect.Size = new System.Drawing.Size(32, 17);
            this.lblKeyStatusEffect.TabIndex = 9;
            this.lblKeyStatusEffect.Text = "Key";
            this.lblKeyStatusEffect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbStatusEffectKey
            //
            this.cbStatusEffectKey.DisplayMember = "Key";
            this.cbStatusEffectKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbStatusEffectKey.FormattingEnabled = true;
            this.cbStatusEffectKey.Location = new System.Drawing.Point(62, 122);
            this.cbStatusEffectKey.Name = "cbStatusEffectKey";
            this.cbStatusEffectKey.Size = new System.Drawing.Size(61, 24);
            this.cbStatusEffectKey.TabIndex = 10;
            this.cbStatusEffectKey.ValueMember = "Value";
            // 
            // StatusEffectForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(240, 154);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusEffectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StatusEffect";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton radioPanacea;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioGreenPotion;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton radioRoyalJelly;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKeyStatusEffect;
        private System.Windows.Forms.ComboBox cbStatusEffectKey;
    }
}