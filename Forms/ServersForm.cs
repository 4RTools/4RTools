using _4RTools.Model;
using _4RTools.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4RTools.Forms
{
    public partial class ServersForm : Form, IObserver
    {
        private Subject subject;
        public ServersForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);
            this.subject = subject;
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.SERVER_ADDED:
                    this.doRender();
                    break;
            }
        }


        private void ServersForm_Load(object sender, EventArgs e)
        {
            this.datagridServers.AllowUserToAddRows = false;
            this.doRender();
        }

        private void doRender()
        {
            clientDTOBindingSource.Clear();
            LocalServerManager.GetLocalClients().ForEach(c => clientDTOBindingSource.Add(c));
        }

        private void datagridServers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.datagridServers.Columns[e.ColumnIndex].Name == "Delete")
            {
                //Delete
                if(MessageBox.Show("Are you sure want to delete this Server?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clientDTOBindingSource.RemoveCurrent();
                }
            }
            else
            {
                //Update
                ClientDTO current = (ClientDTO)clientDTOBindingSource.Current;
                current.index = e.RowIndex;
                new AddServerForm(current, this.subject).Show();
            }
        }

        private void btnAddServer_Click(object sender, EventArgs e)
        {
            new AddServerForm(null, this.subject).Show();
        }

    }
}
