using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace _4RTools
{
    public partial class Application : Form
    {
        private Model.Autopot autopot;

        public Application()
        {
            InitializeComponent();
            this.cbHPKey.DataSource = new BindingSource(Utils.KeyMap.getDict(), null);
            this.cbSPKey.DataSource = new BindingSource(Utils.KeyMap.getDict(), null);
            this.autopot = new Model.Autopot();
            // this.ahk = new Model.AHK();
            // loadProfile
            this.autopot.hpKey = Keys.F2;
            this.autopot.hpPercent = 99;
            this.autopot.delay = 10;

            this.autopot.spKey = Keys.F3;
            this.autopot.spPercent = 70;

            this.InitializeApplicationForm();
        }

        private void OnLoadApplication(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.processCB.Items.Clear();
            });
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowTitle != "")
                {
                    this.processCB.Items.Add(string.Format("{0}.exe - {1}", p.ProcessName, p.Id));
                }
            }

        }

       private void processCB_SelectedIndexChanged(object sender, EventArgs e)
       {
            Model.Client client = new Model.Client(this.processCB.SelectedItem.ToString());
            Console.WriteLine(client.ReadCurrentHp());

            if (client != null)
            {
                Model.ClientSingleton.Instance(client);
                Console.WriteLine(Model.ClientSingleton.GetClient().ReadCurrentHp());
                this.progressBarHP.Maximum = (int)Model.ClientSingleton.GetClient().ReadMaxHp();
                this.progressBarHP.Value = (int)Model.ClientSingleton.GetClient().ReadCurrentHp();

                this.progressBarSP.Maximum = (int)Model.ClientSingleton.GetClient().ReadMaxSp();
                this.progressBarSP.Value = (int)Model.ClientSingleton.GetClient().ReadCurrentSp();
                
                this.autopot.Start();
            }
       }

        private void InitializeApplicationForm()
        {
            this.cbHPKey.SelectedValue = this.autopot.hpKey;
            this.cbSPKey.SelectedValue = this.autopot.spKey;
        }
    }
}
