using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class StatusEffectForm : Form, IObserver
    {
        private AutoEffectStatus autoEffectStatus = new AutoEffectStatus();

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
                    this.autoEffectStatus = ProfileSingleton.GetCurrent().AutoEffectStatus;
                    this.cbStatusEffectKey.SelectedValue = this.autoEffectStatus.effectStatusKey;
                    this.autoEffectStatus.Start();
                    break;
                case MessageCode.TURN_OFF:
                    this.autoEffectStatus.Stop();
                    break;
                case MessageCode.TURN_ON:
                    this.autoEffectStatus.Start();
                    break;
            }
        }

        private void statusEffectKeyIndexChanged(object sender, EventArgs e)
        {
            this.autoEffectStatus.effectStatusKey = (Key)this.cbStatusEffectKey.SelectedValue;
            ProfileSingleton.SetConfiguration(this.autoEffectStatus);
        }
    }
}
