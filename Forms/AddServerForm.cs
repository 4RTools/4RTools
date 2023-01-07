using _4RTools.Model;
using _4RTools.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class AddServerForm : Form
    {
        Dictionary<string, int> inputMap = new Dictionary<string, int>();
        private ClientDTO dto;
        private Subject subject;

        public AddServerForm(ClientDTO dto, Subject subject)
        {
            InitializeComponent();
            SetupInputs();

            inputMap.Add("D0", 0);
            inputMap.Add("D1", 1);
            inputMap.Add("D2", 2);
            inputMap.Add("D3", 3);
            inputMap.Add("D4", 4);
            inputMap.Add("D5", 5);
            inputMap.Add("D6", 6);
            inputMap.Add("D7", 7);
            inputMap.Add("D8", 8);
            inputMap.Add("D9", 9);


            inputMap.Add("NumPad0", 0);
            inputMap.Add("NumPad1", 1);
            inputMap.Add("NumPad2", 2);
            inputMap.Add("NumPad3", 3);
            inputMap.Add("NumPad4", 4);
            inputMap.Add("NumPad5", 5);
            inputMap.Add("NumPad6", 6);
            inputMap.Add("NumPad7", 7);
            inputMap.Add("NumPad8", 8);
            inputMap.Add("NumPad9", 9);

            if (dto != null)
            {
                this.dto = dto;
                initiateWithClientDTO(dto);
                this.Text = "Edit Server " + dto.name;
            }

            this.subject = subject;
        }

        private void initiateWithClientDTO(ClientDTO dto)
        {
            //Addresses start in position 2 (0x...)
            List<char> charsHP = dto.hpAddress.Replace("0x", "").ToCharArray().ToList();
            List<char> charsName = dto.nameAddress.Replace("0x", "").ToCharArray().ToList();

            txtHP1.Text = charsHP.ElementAtOrDefault(0).ToString();
            txtHP2.Text = charsHP.ElementAtOrDefault(1).ToString();
            txtHP3.Text = charsHP.ElementAtOrDefault(2).ToString();
            txtHP4.Text = charsHP.ElementAtOrDefault(3).ToString();
            txtHP5.Text = charsHP.ElementAtOrDefault(4).ToString();
            txtHP6.Text = charsHP.ElementAtOrDefault(5).ToString();
            txtHP7.Text = charsHP.ElementAtOrDefault(6).ToString();
            txtHP8.Text = charsHP.ElementAtOrDefault(7).ToString();


            txtName1.Text = charsName.ElementAtOrDefault(0).ToString();
            txtName2.Text = charsName.ElementAtOrDefault(1).ToString();
            txtName3.Text = charsName.ElementAtOrDefault(2).ToString();
            txtName4.Text = charsName.ElementAtOrDefault(3).ToString();
            txtName5.Text = charsName.ElementAtOrDefault(4).ToString();
            txtName6.Text = charsName.ElementAtOrDefault(5).ToString();
            txtName7.Text = charsName.ElementAtOrDefault(6).ToString();
            txtName8.Text = charsName.ElementAtOrDefault(7).ToString();

            processCB.Text = dto.name;
        }

        private void onTextChange(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;

            if (inputMap.ContainsKey(textBox.Text))
            {
                textBox.Text = inputMap[textBox.Text].ToString();
            }

            if (!LocalServerManager.IsHex(textBox.Text)) textBox.Clear();
        }

        private void refreshProcessList()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.processCB.Items.Clear();
            });
            foreach (Process p in Process.GetProcesses())
            {
                if (p.MainWindowTitle != "")
                {
                    this.processCB.Items.Add(string.Format("{0}", p.ProcessName, p.Id));
                }
            }
        }

        public void SetupInputs()
        {
            try
            {
                foreach (Control c in FormUtils.GetAll(this, typeof(TextBox)))
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = (TextBox)c;
                        textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
                        textBox.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
                        textBox.TextChanged += new EventHandler(this.onTextChange);
                    }
                }
            }
            catch { }

        }

        private void AddServerForm_Load(object sender, EventArgs e)
        {
            refreshProcessList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string hpAddress = string.Concat(txtHP1.Text, txtHP2.Text, txtHP3.Text, txtHP4.Text, txtHP5.Text, txtHP6.Text, txtHP7.Text, txtHP8.Text);
            string nameAddress = string.Concat(txtName1.Text, txtName2.Text, txtName3.Text, txtName4.Text, txtName5.Text, txtName6.Text, txtName7.Text, txtName8.Text);
            try
            {
                //If don't have client DTO, save a new server. If have DTO, should update given DTO.
                if(this.dto == null)
                {
                    //Should create one
                    LocalServerManager.AddServer(hpAddress, nameAddress, processCB.Text);
                    MessageBox.Show("Server " + processCB.Text + " successfully added !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    //Update Server
                    LocalServerManager.RemoveClient(dto);
                    LocalServerManager.AddServer(hpAddress, nameAddress, processCB.Text);
                    MessageBox.Show("Server " + processCB.Text + " successfully saved !!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.subject.Notify(new Utils.Message(MessageCode.SERVER_LIST_CHANGED, "Server Added"));
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
