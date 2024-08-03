namespace _4RTools.Forms
{
    partial class DebuffRecoveryForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebuffRecoveryForm));
            this.StatusRecoveryGP = new System.Windows.Forms.GroupBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.DebuffRecoveryGP = new System.Windows.Forms.GroupBox();
            this.autoStandCB = new System.Windows.Forms.CheckBox();
            this.sitPB = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtNewStatusKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtStatusKey = new System.Windows.Forms.TextBox();
            this.newStatusDelay = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.StatusRecoveryGP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newStatusDelay)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StatusRecoveryGP
            // 
            this.StatusRecoveryGP.AutoSize = true;
            this.StatusRecoveryGP.Controls.Add(this.autoStandCB);
            this.StatusRecoveryGP.Controls.Add(this.sitPB);
            this.StatusRecoveryGP.Controls.Add(this.label1);
            this.StatusRecoveryGP.Controls.Add(this.pictureBox1);
            this.StatusRecoveryGP.Controls.Add(this.txtStatusKey);
            this.StatusRecoveryGP.Location = new System.Drawing.Point(10, 12);
            this.StatusRecoveryGP.Name = "StatusRecoveryGP";
            this.StatusRecoveryGP.Size = new System.Drawing.Size(261, 117);
            this.StatusRecoveryGP.TabIndex = 201;
            this.StatusRecoveryGP.TabStop = false;
            this.StatusRecoveryGP.Text = "Status Recovery";
            // 
            // DebuffRecoveryGP
            // 
            this.DebuffRecoveryGP.AutoSize = true;
            this.DebuffRecoveryGP.Location = new System.Drawing.Point(10, 136);
            this.DebuffRecoveryGP.Name = "DebuffRecoveryGP";
            this.DebuffRecoveryGP.Size = new System.Drawing.Size(538, 30);
            this.DebuffRecoveryGP.TabIndex = 202;
            this.DebuffRecoveryGP.TabStop = false;
            this.DebuffRecoveryGP.Text = "Status Effects";
            // 
            // autoStandCB
            // 
            this.autoStandCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoStandCB.Location = new System.Drawing.Point(70, 51);
            this.autoStandCB.Name = "autoStandCB";
            this.autoStandCB.Size = new System.Drawing.Size(149, 47);
            this.autoStandCB.TabIndex = 28;
            this.autoStandCB.Text = "Enable Auto Stand (when forced to sit)";
            this.autoStandCB.UseVisualStyleBackColor = true;
            // 
            // sitPB
            // 
            this.sitPB.Image = ((System.Drawing.Image)(resources.GetObject("sitPB.Image")));
            this.sitPB.Location = new System.Drawing.Point(41, 62);
            this.sitPB.Name = "sitPB";
            this.sitPB.Size = new System.Drawing.Size(24, 24);
            this.sitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sitPB.TabIndex = 27;
            this.sitPB.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(77, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Status";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(49, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // txtNewStatusKey
            // 
            this.txtNewStatusKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNewStatusKey.Location = new System.Drawing.Point(128, 34);
            this.txtNewStatusKey.Name = "txtNewStatusKey";
            this.txtNewStatusKey.Size = new System.Drawing.Size(52, 23);
            this.txtNewStatusKey.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Status";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // txtStatusKey
            // 
            this.txtStatusKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtStatusKey.Location = new System.Drawing.Point(119, 22);
            this.txtStatusKey.Name = "txtStatusKey";
            this.txtStatusKey.Size = new System.Drawing.Size(52, 23);
            this.txtStatusKey.TabIndex = 21;
            // 
            // newStatusDelay
            // 
            this.newStatusDelay.Location = new System.Drawing.Point(128, 63);
            this.newStatusDelay.Name = "newStatusDelay";
            this.newStatusDelay.Size = new System.Drawing.Size(52, 20);
            this.newStatusDelay.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cooldown";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNewStatusKey);
            this.groupBox1.Controls.Add(this.newStatusDelay);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(285, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(261, 117);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Elvira Candy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "ms";
            // 
            // DebuffRecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(560, 186);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DebuffRecoveryGP);
            this.Controls.Add(this.StatusRecoveryGP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DebuffRecoveryForm";
            this.Text = "A";
            this.StatusRecoveryGP.ResumeLayout(false);
            this.StatusRecoveryGP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newStatusDelay)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox StatusRecoveryGP;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox DebuffRecoveryGP;
        private System.Windows.Forms.CheckBox autoStandCB;
        private System.Windows.Forms.PictureBox sitPB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox txtNewStatusKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtStatusKey;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown newStatusDelay;
        private System.Windows.Forms.Label label4;
    }
}