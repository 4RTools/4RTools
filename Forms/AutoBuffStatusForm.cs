using System;
using System.Windows.Forms;
using System.Windows.Input;
using System.Collections.Generic;
using _4RTools.Utils;
using _4RTools.Model;
using System.Linq;
using System.Windows.Media.Effects;

namespace _4RTools.Forms
{
    public partial class AutoBuffStatusForm : Form, IObserver
    {
        private List<BuffContainer> debuffContainers = new List<BuffContainer>();

        public AutoBuffStatusForm(Subject subject)
        {
            InitializeComponent();
            debuffContainers.Add(new BuffContainer(this.DebuffsGP, Buff.GetDebuffs()));

            new DebuffRenderer(debuffContainers, toolTip1).doRender();

            subject.Attach(this);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                    doUpdate(this);
                    break;
                case MessageCode.TURN_OFF:
                    ProfileSingleton.GetCurrent().DebuffsRecovery.Stop();
                    break;
                case MessageCode.TURN_ON:
                    ProfileSingleton.GetCurrent().DebuffsRecovery.Start();
                    break;
            }
        }
        public static void doUpdate(Control control)
        {
            var autobuffDict = ProfileSingleton.GetCurrent().DebuffsRecovery.buffMapping;
            var groupbox = control.Controls.OfType<GroupBox>().FirstOrDefault();
            foreach (TextBox txt in groupbox.Controls.OfType<TextBox>()) {
                var buffid = int.Parse(txt.Name.Split('n')[1]);
                var existe = autobuffDict.FirstOrDefault(x => x.Key.Equals((EffectStatusIDs)buffid));
                if (existe.Key != 0)
                {
                    txt.Text = autobuffDict[(EffectStatusIDs)buffid].ToString();
                }
                else
                {
                    txt.Text = "None";
                }
            }
        }
    }
}
