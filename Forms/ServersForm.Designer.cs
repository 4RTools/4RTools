namespace _4RTools.Forms
{
    partial class ServersForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddServer = new System.Windows.Forms.Button();
            this.datagridServers = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hpAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridServers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.btnAddServer);
            this.panel1.Controls.Add(this.datagridServers);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(541, 250);
            this.panel1.TabIndex = 1;
            // 
            // btnAddServer
            // 
            this.btnAddServer.Location = new System.Drawing.Point(3, 12);
            this.btnAddServer.Name = "btnAddServer";
            this.btnAddServer.Size = new System.Drawing.Size(104, 23);
            this.btnAddServer.TabIndex = 27;
            this.btnAddServer.Text = "Add Server";
            this.btnAddServer.UseVisualStyleBackColor = true;
            this.btnAddServer.Click += new System.EventHandler(this.btnAddServer_Click);
            // 
            // datagridServers
            // 
            this.datagridServers.AutoGenerateColumns = false;
            this.datagridServers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datagridServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.hpAddressDataGridViewTextBoxColumn,
            this.nameAddressDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.datagridServers.DataSource = this.clientDTOBindingSource;
            this.datagridServers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.datagridServers.Location = new System.Drawing.Point(0, 50);
            this.datagridServers.Name = "datagridServers";
            this.datagridServers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.datagridServers.Size = new System.Drawing.Size(541, 200);
            this.datagridServers.TabIndex = 0;
            this.datagridServers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridServers_CellContentClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 80;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 80;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hpAddressDataGridViewTextBoxColumn
            // 
            this.hpAddressDataGridViewTextBoxColumn.DataPropertyName = "hpAddress";
            this.hpAddressDataGridViewTextBoxColumn.HeaderText = "HP Address";
            this.hpAddressDataGridViewTextBoxColumn.Name = "hpAddressDataGridViewTextBoxColumn";
            this.hpAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameAddressDataGridViewTextBoxColumn
            // 
            this.nameAddressDataGridViewTextBoxColumn.DataPropertyName = "nameAddress";
            this.nameAddressDataGridViewTextBoxColumn.HeaderText = "Name Address";
            this.nameAddressDataGridViewTextBoxColumn.Name = "nameAddressDataGridViewTextBoxColumn";
            this.nameAddressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientDTOBindingSource
            // 
            this.clientDTOBindingSource.DataSource = typeof(_4RTools.Model.ClientDTO);
            // 
            // ServersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(565, 268);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ServersForm";
            this.Text = "ServersForm";
            this.Load += new System.EventHandler(this.ServersForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridServers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagridServers;
        private System.Windows.Forms.BindingSource clientDTOBindingSource;
        private System.Windows.Forms.Button btnAddServer;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hpAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}