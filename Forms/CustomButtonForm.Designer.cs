namespace _4RTools.Forms
{
    partial class CustomButtonForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomButtonForm));
            this.txtTransferKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAutoClickKey = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTransferKey
            // 
            this.txtTransferKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtTransferKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransferKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTransferKey.ForeColor = System.Drawing.Color.White;
            this.txtTransferKey.Location = new System.Drawing.Point(79, 8);
            this.txtTransferKey.Name = "txtTransferKey";
            this.txtTransferKey.Size = new System.Drawing.Size(45, 23);
            this.txtTransferKey.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Transfer Item";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(173, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Auto Click";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAutoClickKey
            // 
            this.txtAutoClickKey.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
            this.txtAutoClickKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAutoClickKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtAutoClickKey.ForeColor = System.Drawing.Color.White;
            this.txtAutoClickKey.Location = new System.Drawing.Point(216, 8);
            this.txtAutoClickKey.Name = "txtAutoClickKey";
            this.txtAutoClickKey.Size = new System.Drawing.Size(45, 23);
            this.txtAutoClickKey.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Silver;
            this.panel5.Location = new System.Drawing.Point(133, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1, 30);
            this.panel5.TabIndex = 19;
            this.panel5.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(140, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // CustomButtonForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(31)))), ((int)(((byte)(34)))));
            this.ClientSize = new System.Drawing.Size(130, 39);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAutoClickKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransferKey);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(155)))), ((int)(((byte)(164)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomButtonForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StatusEffect";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTransferKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAutoClickKey;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}