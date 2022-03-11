using _4RTools.Utils;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtStatusKey = new System.Windows.Forms.TextBox();
            this.lblKeyStatusEffect = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtStatusKey);
            this.groupBox1.Controls.Add(this.lblKeyStatusEffect);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // txtStatusKey
            // 
            this.txtStatusKey.Location = new System.Drawing.Point(9, 25);
            this.txtStatusKey.Name = "txtStatusKey";
            this.txtStatusKey.Size = new System.Drawing.Size(62, 23);
            this.txtStatusKey.TabIndex = 11;
            // 
            // lblKeyStatusEffect
            // 
            this.lblKeyStatusEffect.AutoSize = true;
            this.lblKeyStatusEffect.Location = new System.Drawing.Point(77, 25);
            this.lblKeyStatusEffect.Name = "lblKeyStatusEffect";
            this.lblKeyStatusEffect.Size = new System.Drawing.Size(32, 17);
            this.lblKeyStatusEffect.TabIndex = 9;
            this.lblKeyStatusEffect.Text = "Key";
            this.lblKeyStatusEffect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusEffectForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(121, 65);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusEffectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "StatusEffect";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKeyStatusEffect;
        private System.Windows.Forms.TextBox txtStatusKey;
    }
}