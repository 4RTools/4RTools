using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class StatusEffectForm : Form, IObserver
    {
        private AutoBuff autoBuffs = new AutoBuff();

        public StatusEffectForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);
            this.cbStatusEffectKey.DataSource = new BindingSource(KeyMap.getDict(), null);
            this.cbStatusEffectKey.SelectedValue = Key.None;
        }

        public void Update(ISubject subject)
        {

            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    this.autoBuffs = ProfileSingleton.GetCurrent().AutoBuff;
                    this.cbStatusEffectKey.SelectedValue = this.autoBuffs.effectStatusKey;
                    this.autoBuffs.Start();
                    break;
                case MessageCode.TURN_OFF:
                    this.autoBuffs.Stop();
                    break;
                case MessageCode.TURN_ON:
                    this.autoBuffs.Start();
                    break;
            }
        }

        private void statusEffectKeyIndexChanged(object sender, EventArgs e)
        {
            this.autoBuffs.effectStatusKey = (Key)this.cbStatusEffectKey.SelectedValue;
            ProfileSingleton.SetConfiguration(this.autoBuffs);
        }
    }
}
