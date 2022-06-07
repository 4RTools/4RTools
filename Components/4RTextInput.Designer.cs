namespace _4RTools.Components
{
    partial class _4RTextInput
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this._4RTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _4RTextBox
            // 
            this._4RTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._4RTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._4RTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this._4RTextBox.Location = new System.Drawing.Point(7, 7);
            this._4RTextBox.Name = "_4RTextBox";
            this._4RTextBox.Size = new System.Drawing.Size(236, 11);
            this._4RTextBox.TabIndex = 0;
            this._4RTextBox.Click += new System.EventHandler(this.textBox1_Click);
            this._4RTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this._4RTextBox.Enter += new System.EventHandler(this.textBox1_Enter);
            this._4RTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this._4RTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this._4RTextBox.Leave += new System.EventHandler(this.textBox1_Leave);
            this._4RTextBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            this._4RTextBox.MouseEnter += new System.EventHandler(this.textBox1_MouseEnter);
            // 
            // _4RTextInput
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this._4RTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "_4RTextInput";
            this.Padding = new System.Windows.Forms.Padding(7);
            this.Size = new System.Drawing.Size(250, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _4RTextBox;
    }
}
