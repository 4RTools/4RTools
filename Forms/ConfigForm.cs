using System;
using _4RTools.Model;
using System.Windows.Forms;
using _4RTools.Utils;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Input;
using System.Runtime.InteropServices;
using System.ComponentModel;
using Oli.Controls;
using System.Linq.Expressions;

namespace _4RTools.Forms
{
    public partial class ConfigForm : Form, IObserver
    {
        public ConfigForm(Subject subject)
        {
            InitializeComponent();
            var newListBuff = ProfileSingleton.GetCurrent().UserPreferences.autoBuffOrder;
            this.listBox1.MouseLeave += new System.EventHandler(this.listBox1_MouseLeave);
            subject.Attach(this);
        }

        public void Update(ISubject subject)
        {
            switch ((subject as Subject).Message.code)
            {
                case MessageCode.PROFILE_CHANGED:
                case MessageCode.ADDED_NEW_AUTOBUFF_SKILL:
                    UpdateUI(subject);
                    break;
            }
        }
        public void UpdateUI(ISubject subject)
        {
            try
            {
                AutoBuffSkill currentBuffs = (AutoBuffSkill)(subject as Subject).Message.data;
                listBox1.Items.Clear();
                if (currentBuffs != null)
                {
                    var buffsList = currentBuffs.buffMapping.Keys.ToList();
                    listBox1.Items.Clear();

                    foreach (var buff in buffsList)
                    {
                        listBox1.Items.Add(buff.ToDescriptionString());
                    }
                }
                this.chkStopBuffsOnCity.Checked = ProfileSingleton.GetCurrent().UserPreferences.stopBuffsCity;
                this.chkStopBuffsOnRein.Checked = ProfileSingleton.GetCurrent().UserPreferences.stopBuffsRein;
            }
            catch { }
        }

        private void listBox1_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                var autoBuffSkill = ProfileSingleton.GetCurrent().AutobuffSkill;
                var newOrderList = new List<EffectStatusIDs>();
                var orderedBuffList = listBox1.Items;
                Dictionary<EffectStatusIDs, Key> currentList = new Dictionary<EffectStatusIDs, Key>(autoBuffSkill.buffMapping);
                Dictionary<EffectStatusIDs, Key> newOrderedBuffList = new Dictionary<EffectStatusIDs, Key>();
                if (currentList.Count > 0)
                {

                    foreach (var buff in orderedBuffList)
                    {
                        var buffId = buff.ToString().ToEffectStatusId();
                        newOrderList.Add(buffId);
                        var findBuff = currentList.FirstOrDefault(t => t.Key == buffId);
                        newOrderedBuffList.Add(findBuff.Key, findBuff.Value);
                    }
                    ProfileSingleton.GetCurrent().UserPreferences.SetAutoBuffOrder(newOrderList);
                    ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);

                    ProfileSingleton.GetCurrent().AutobuffSkill.ClearKeyMapping();
                    ProfileSingleton.GetCurrent().AutobuffSkill.setBuffMapping(newOrderedBuffList);
                    ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().AutobuffSkill);

                    newOrderedBuffList.Clear();
                }
            }
            catch { }
        }

        private void chkStopBuffsOnRein_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            ProfileSingleton.GetCurrent().UserPreferences.stopBuffsRein = chk.Checked;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);
        }

        private void chkStopBuffsOnCity_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            ProfileSingleton.GetCurrent().UserPreferences.stopBuffsCity = chk.Checked;
            ProfileSingleton.SetConfiguration(ProfileSingleton.GetCurrent().UserPreferences);
        }

    }
}
