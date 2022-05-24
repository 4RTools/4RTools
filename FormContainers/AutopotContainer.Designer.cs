namespace _4RTools.FormContainers
{
    partial class AutopotContainer
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
            this.panelAutopot = new System.Windows.Forms.Panel();
            this.panelAutopotYgg = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelAutopot
            // 
            this.panelAutopot.Location = new System.Drawing.Point(113, 87);
            this.panelAutopot.Name = "panelAutopot";
            this.panelAutopot.Size = new System.Drawing.Size(223, 115);
            this.panelAutopot.TabIndex = 0;
            // 
            // panelAutopotYgg
            // 
            this.panelAutopotYgg.Location = new System.Drawing.Point(369, 87);
            this.panelAutopotYgg.Name = "panelAutopotYgg";
            this.panelAutopotYgg.Size = new System.Drawing.Size(223, 115);
            this.panelAutopotYgg.TabIndex = 1;
            this.panelAutopotYgg.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAutopotYgg_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(170)))), ((int)(((byte)(147)))));
            this.panel1.Location = new System.Drawing.Point(353, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 160);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(170)))), ((int)(((byte)(147)))));
            this.panel2.Location = new System.Drawing.Point(123, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(460, 1);
            this.panel2.TabIndex = 3;
            // 
            // panelStatus
            // 
            this.panelStatus.Location = new System.Drawing.Point(159, 241);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(141, 39);
            this.panelStatus.TabIndex = 4;
            // 
            // AutopotContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(728, 435);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAutopotYgg);
            this.Controls.Add(this.panelAutopot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutopotContainer";
            this.Text = "AutopotContainer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAutopot;
        private System.Windows.Forms.Panel panelAutopotYgg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelStatus;
    }
}