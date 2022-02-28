using System;
using System.Windows.Forms;
using System.Windows.Input;
using System.Collections.Generic;
using _4RTools.Utils;
using _4RTools.Model;

namespace _4RTools.Forms
{
    public partial class StuffAutoBuff : Form, IObserver
    {
        private AutoBuff autobuff = new AutoBuff("ItemsAutoBuff");
        public StuffAutoBuff(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);
            this.InitializeComboBoxes();
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    this.autobuff = ProfileSingleton.GetCurrent().ItemsAutoBuff;
                    Dictionary<EffectStatusIDs, Key> buffMappingClone = new Dictionary<EffectStatusIDs, Key>(this.autobuff.buffMapping);
                    this.updateComboValues(buffMappingClone);
                    break;
                case MessageCode.TURN_OFF:
                    this.autobuff.Stop();
                    break;
                case MessageCode.TURN_ON:
                    this.autobuff.Start();
                    break;
            }
        }

        private void onIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ComboBox cb = (ComboBox)sender;
                Key key = (Key) cb.SelectedValue;
                EffectStatusIDs statusID = (EffectStatusIDs)Int16.Parse(cb.Name.Split(new[] { "cb" }, StringSplitOptions.None)[1]);
                if (key == Key.None)
                {
                    this.autobuff.RemoveKey(statusID);
                }
                else
                {
                    this.autobuff.AddKeyToBuff(statusID, key);
                }

                ProfileSingleton.SetConfiguration(this.autobuff);
            }catch { }
        }

        private void updateComboValues(Dictionary<EffectStatusIDs, Key> autobuffDict)
        {
                FormUtils.ResetForm(this);
                foreach (EffectStatusIDs effect in autobuffDict.Keys)
                {
                    Control[] c = this.Controls.Find("cb" + (int)effect, true);
                    if (c.Length > 0)
                    {
                        ComboBox combo = (ComboBox)c[0];
                        combo.SelectedValue = autobuffDict[effect];
                    }   
                }
        }

        private void InitializeComboBoxes()
        {
            foreach (Control c in this.Controls)
                if (c is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)c;
                    comboBox.DataSource = new BindingSource(KeyMap.getDict(), null);
                    comboBox.SelectedIndexChanged += new EventHandler(this.onIndexChanged);
                }
        }

    }
}
