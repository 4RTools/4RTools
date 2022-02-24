using System;
using System.Windows.Forms;
using _4RTools.Utils;
using _4RTools.Model;
using System.Windows.Input;

namespace _4RTools.Forms
{
    public partial class StatusEffectForm : Form, IObserver
    {

        public StatusEffectForm(Subject subject)
        {
            InitializeComponent();
            subject.Attach(this);
            this.cbStatusEffectKey.DataSource = new BindingSource(KeyMap.getDict(), null);

            this.cbStatusEffectKey.SelectedValue = Key.None;
        }

        public void Update(ISubject subject)
        {
        }
    }
}
