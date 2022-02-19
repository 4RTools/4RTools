using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace _4RTools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            processCB.SelectedIndexChanged += this.processCB_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                processCB.Items.Clear();
            });
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowTitle != "")
                {
                    processCB.Items.Add(string.Format("{0}.exe - {1}", p.ProcessName, p.Id));
                }
            }

        }

       private void processCB_SelectedIndexChanged(object sender, EventArgs e)
       {
            Model.Client client = new Model.Client(processCB.SelectedItem.ToString());
            Model.ClientSingleton.Instance(client);

            new Model.Autopot(Keys.F1, 80, 50, Keys.F2, 90, 50);

       }

        private void HPValue_Click(object sender, EventArgs e)
        {

        }
    }
}
