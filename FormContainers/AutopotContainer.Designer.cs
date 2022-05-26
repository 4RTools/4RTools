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
            this.label1 = new System.Windows.Forms.Label();
            this._4RCheckBox1 = new _4RTools.Components._4RCheckBox();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "F1";
            // 
            // _4RCheckBox1
            // 
            this._4RCheckBox1.BoxLocation_X = 3;
            this._4RCheckBox1.BoxLocation_Y = 2;
            this._4RCheckBox1.BoxSize = 20;
            this._4RCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._4RCheckBox1.Checked = true;
            this._4RCheckBox1.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this._4RCheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this._4RCheckBox1.DisplayText = "_4RCheckBox1";
            this._4RCheckBox1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._4RCheckBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this._4RCheckBox1.Location = new System.Drawing.Point(509, 304);
            this._4RCheckBox1.Name = "_4RCheckBox1";
            this._4RCheckBox1.Size = new System.Drawing.Size(27, 25);
            this._4RCheckBox1.TabIndex = 5;
            this._4RCheckBox1.Text = "_4RCheckBox1";
            this._4RCheckBox1.TextLocation_X = 14;
            this._4RCheckBox1.TextLocation_Y = 4;
            this._4RCheckBox1.ThreeState = true;
            this._4RCheckBox1.UseVisualStyleBackColor = true;
            // 
            // AutopotContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(220)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(728, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._4RCheckBox1);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAutopotYgg);
            this.Controls.Add(this.panelAutopot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AutopotContainer";
            this.Text = "AutopotContainer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAutopot;
        private System.Windows.Forms.Panel panelAutopotYgg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label label1;
        private Components._4RCheckBox _4RCheckBox1;
    }
}