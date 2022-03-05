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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusEffectForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbStatusEffectKey = new System.Windows.Forms.ComboBox();
            this.lblKeyStatusEffect = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbStatusEffectKey);
            this.groupBox1.Controls.Add(this.lblKeyStatusEffect);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cbStatusEffectKey
            // 
            resources.ApplyResources(this.cbStatusEffectKey, "cbStatusEffectKey");
            this.cbStatusEffectKey.DisplayMember = "Key";
            this.cbStatusEffectKey.FormattingEnabled = true;
            this.cbStatusEffectKey.Name = "cbStatusEffectKey";
            this.cbStatusEffectKey.ValueMember = "Value";
            this.cbStatusEffectKey.SelectedIndexChanged += new System.EventHandler(this.statusEffectKeyIndexChanged);
            // 
            // lblKeyStatusEffect
            // 
            resources.ApplyResources(this.lblKeyStatusEffect, "lblKeyStatusEffect");
            this.lblKeyStatusEffect.Name = "lblKeyStatusEffect";
            // 
            // StatusEffectForm
            // 
            resources.ApplyResources(this, "$this");
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusEffectForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKeyStatusEffect;
        private System.Windows.Forms.ComboBox cbStatusEffectKey;
    }
}