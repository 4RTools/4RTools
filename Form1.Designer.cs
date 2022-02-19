namespace _4RTools
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.processCB = new System.Windows.Forms.ComboBox();
            this.HPValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processCB
            // 
            this.processCB.FormattingEnabled = true;
            this.processCB.Location = new System.Drawing.Point(233, 107);
            this.processCB.Name = "processCB";
            this.processCB.Size = new System.Drawing.Size(187, 21);
            this.processCB.TabIndex = 0;
            // 
            // HPValue
            // 
            this.HPValue.AutoSize = true;
            this.HPValue.Location = new System.Drawing.Point(289, 157);
            this.HPValue.Name = "HPValue";
            this.HPValue.Size = new System.Drawing.Size(35, 13);
            this.HPValue.TabIndex = 1;
            this.HPValue.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 538);
            this.Controls.Add(this.HPValue);
            this.Controls.Add(this.processCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox processCB;
        private System.Windows.Forms.Label HPValue;
    }
}

