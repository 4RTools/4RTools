namespace _4RTools.Forms
{
    partial class StuffAutoBuffForm
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.FoodsGP = new System.Windows.Forms.GroupBox();
            this.PotionsGP = new System.Windows.Forms.GroupBox();
            this.BoxesGP = new System.Windows.Forms.GroupBox();
            this.ElementalsGP = new System.Windows.Forms.GroupBox();
            this.ScrollBuffsGP = new System.Windows.Forms.GroupBox();
            this.EtcGP = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 2;
            // 
            // FoodsGP
            // 
            this.FoodsGP.AutoSize = true;
            this.FoodsGP.Location = new System.Drawing.Point(12, 122);
            this.FoodsGP.Name = "FoodsGP";
            this.FoodsGP.Size = new System.Drawing.Size(522, 33);
            this.FoodsGP.TabIndex = 293;
            this.FoodsGP.TabStop = false;
            this.FoodsGP.Text = "Foods";
            // 
            // PotionsGP
            // 
            this.PotionsGP.AutoSize = true;
            this.PotionsGP.Location = new System.Drawing.Point(12, 12);
            this.PotionsGP.Name = "PotionsGP";
            this.PotionsGP.Size = new System.Drawing.Size(522, 29);
            this.PotionsGP.TabIndex = 294;
            this.PotionsGP.TabStop = false;
            this.PotionsGP.Text = "Potions";
            // 
            // BoxesGP
            // 
            this.BoxesGP.AutoSize = true;
            this.BoxesGP.Location = new System.Drawing.Point(12, 85);
            this.BoxesGP.Name = "BoxesGP";
            this.BoxesGP.Size = new System.Drawing.Size(522, 31);
            this.BoxesGP.TabIndex = 295;
            this.BoxesGP.TabStop = false;
            this.BoxesGP.Text = "Boxes / Speed / Status";
            // 
            // ElementalsGP
            // 
            this.ElementalsGP.AutoSize = true;
            this.ElementalsGP.Location = new System.Drawing.Point(12, 47);
            this.ElementalsGP.Name = "ElementalsGP";
            this.ElementalsGP.Size = new System.Drawing.Size(522, 32);
            this.ElementalsGP.TabIndex = 296;
            this.ElementalsGP.TabStop = false;
            this.ElementalsGP.Text = "Elementals";
            // 
            // ScrollBuffsGP
            // 
            this.ScrollBuffsGP.AutoSize = true;
            this.ScrollBuffsGP.Location = new System.Drawing.Point(12, 161);
            this.ScrollBuffsGP.Name = "ScrollBuffsGP";
            this.ScrollBuffsGP.Size = new System.Drawing.Size(522, 33);
            this.ScrollBuffsGP.TabIndex = 297;
            this.ScrollBuffsGP.TabStop = false;
            this.ScrollBuffsGP.Text = "Scroll Buffs";
            // 
            // EtcGP
            // 
            this.EtcGP.AutoSize = true;
            this.EtcGP.Location = new System.Drawing.Point(12, 200);
            this.EtcGP.Name = "EtcGP";
            this.EtcGP.Size = new System.Drawing.Size(522, 33);
            this.EtcGP.TabIndex = 298;
            this.EtcGP.TabStop = false;
            this.EtcGP.Text = "ETC";
           
            // 
            // StuffAutoBuffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(563, 248);
            this.Controls.Add(this.EtcGP);
            this.Controls.Add(this.ScrollBuffsGP);
            this.Controls.Add(this.ElementalsGP);
            this.Controls.Add(this.BoxesGP);
            this.Controls.Add(this.PotionsGP);
            this.Controls.Add(this.FoodsGP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StuffAutoBuffForm";
            this.Text = "AutobuffSkillForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox FoodsGP;
        private System.Windows.Forms.GroupBox PotionsGP;
        private System.Windows.Forms.GroupBox BoxesGP;
        private System.Windows.Forms.GroupBox ElementalsGP;
        private System.Windows.Forms.GroupBox ScrollBuffsGP;
        private System.Windows.Forms.GroupBox EtcGP;
    }
}