using _4RTools.Forms;
using _4RTools.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace _4RTools.Model
{
    internal class BuffRenderer
    {

        private readonly int BUFFS_PER_ROW = 5;
        private readonly int DISTANCE_BETWEEN_CONTAINERS = 10;
        private readonly int DISTANCE_BETWEEN_ROWS = 30;

        private List<BuffContainer> _containers;
        private ToolTip _toolTip;
        private String _typeAutoBuff;
        private Subject _subject;
        string OldText = string.Empty;

        public BuffRenderer(List<BuffContainer> containers, ToolTip toolTip, String autoBuff, Subject subject)
        {
            this._containers = containers;
            this._toolTip = toolTip;
            this._typeAutoBuff = autoBuff;
            this._subject = subject;
        }

        public void doRender()
        {
            for (int i = 0; i < _containers.Count; i++)
            {
                BuffContainer bk = _containers[i];
                Point lastLocation = new Point(bk.container.Location.X, 20);
                int colCount = 0;

                if (i > 0)
                {
                    //If not first container to be rendered, get last container height and append 70
                    bk.container.Location = new Point(_containers[i - 1].container.Location.X, _containers[i - 1].container.Location.Y + _containers[i - 1].container.Height + DISTANCE_BETWEEN_CONTAINERS);
                }

                foreach (Buff skill in bk.skills)
                {
                    PictureBox pb = new PictureBox();
                    TextBox textBox = new TextBox();

                    pb.Image = skill.icon;
                    pb.BackgroundImageLayout = ImageLayout.Center;
                    pb.Location = new Point(lastLocation.X + (colCount * 100), lastLocation.Y);
                    pb.Name = "pbox" + ((int)skill.effectStatusID);
                    pb.Size = new Size(26, 26);
                    _toolTip.SetToolTip(pb, skill.name);

                    textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(FormUtils.OnKeyDown);
                    textBox.KeyPress += new KeyPressEventHandler(FormUtils.OnKeyPress);
                    textBox.GotFocus += new EventHandler(textBox_GotFocus);
                    textBox.TextChanged += new EventHandler(onTextChange);
                    textBox.Size = new Size(55, 20);
                    textBox.Tag = ((int)skill.effectStatusID);
                    textBox.Name = "in" + ((int)skill.effectStatusID);
                    textBox.Location = new Point(pb.Location.X + 35, pb.Location.Y + 3);
                    textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(51)))), ((int)(((byte)(56)))));
                    textBox.ForeColor = System.Drawing.Color.White;
                    textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

                    bk.container.Controls.Add(textBox);
                    bk.container.Controls.Add(pb);

                    colCount++;

                    if (colCount == BUFFS_PER_ROW)
                    {
                        //5 Buffs per row
                        colCount = 0;
                        lastLocation = new Point(bk.container.Location.X, lastLocation.Y + DISTANCE_BETWEEN_ROWS);
                    }
                }
            }
        }

        private void onTextChange(object sender, EventArgs e)
        {
            try
            {
                if (this._typeAutoBuff == ProfileSingleton.GetCurrent().AutobuffSkill.actionName)
                {
                    var _autoBuff = ProfileSingleton.GetCurrent().AutobuffSkill;
                }

                TextBox txtBox = (TextBox)sender;
                bool textChanged = this.OldText != String.Empty && this.OldText != txtBox.Text.ToString();
                if ((txtBox.Text.ToString() != String.Empty) && textChanged)
                {
                    Key key = (Key)Enum.Parse(typeof(Key), txtBox.Text.ToString());
                    EffectStatusIDs statusID = (EffectStatusIDs)Int16.Parse(txtBox.Name.Split(new[] { "in" }, StringSplitOptions.None)[1]);

                    if (this._typeAutoBuff == ProfileSingleton.GetCurrent().AutobuffSkill.actionName)
                    {
                        var _autoBuffSkill = ProfileSingleton.GetCurrent().AutobuffSkill;
                        _autoBuffSkill.AddKeyToBuff(statusID, key);
                        ProfileSingleton.SetConfiguration(_autoBuffSkill);
                        _subject.Notify(new Utils.Message(Utils.MessageCode.ADDED_NEW_AUTOBUFF_SKILL, _autoBuffSkill));
                    }
                    else
                    {
                        var _autoBuffStuff = ProfileSingleton.GetCurrent().AutobuffStuff;
                        if (statusID == EffectStatusIDs.EDEN)
                        {
                            _autoBuffStuff.AddKeyToBuff(EffectStatusIDs.ASSUMPTIO, key);
                            _autoBuffStuff.AddKeyToBuff(EffectStatusIDs.INC_AGI, key);
                            _autoBuffStuff.AddKeyToBuff(EffectStatusIDs.BLESSING, key);
                            _autoBuffStuff.AddKeyToBuff(EffectStatusIDs.EDEN, key);
                        }
                        else
                        {
                            _autoBuffStuff.AddKeyToBuff(statusID, key);
                        }
                        ProfileSingleton.SetConfiguration(_autoBuffStuff);
                    }
                }

            }
            catch { }
        }

        public static void doUpdate(Dictionary<EffectStatusIDs, Key> autobuffDict, Control control)
        {
            FormUtils.ResetForm(control);
            foreach (EffectStatusIDs effect in autobuffDict.Keys)
            {
                Control[] c = control.Controls.Find("in" + (int)effect, true);
                if (c.Length > 0)
                {
                    TextBox textBox = (TextBox)c[0];
                    textBox.Text = autobuffDict[effect].ToString();
                }
            }
        }


        private void textBox_GotFocus(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            this.OldText = txtBox.Text.ToString();
        }
    }
}
