using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _4RTools.Utils
{
    public class FormUtils
    {

        public static void OnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
                Key thisk = (Key)Enum.Parse(typeof(Key), e.KeyCode.ToString());

                switch (thisk)
                {
                    case Key.Escape: case Key.Back:
                        textBox.Text = Key.None.ToString();
                        break;
                    default:
                        textBox.Text = e.KeyCode.ToString();
                        break;
                }
                textBox.Parent.Focus();
                e.Handled = true;
            }
            catch { }
        }

        public static bool IsValidKey(Key key)
        {
            return (key != Key.Back && key != Key.Escape && key != Key.None);
        }

        public static void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }

        private static void resetForm(Control control)
        {

            IEnumerable<Control> texts = GetAll(control, typeof(System.Windows.Forms.TextBox));
            IEnumerable<Control> checks = GetAll(control, typeof(CheckBox));
            IEnumerable<Control> combos = GetAll(control, typeof(System.Windows.Forms.ComboBox));

            foreach(Control c in texts)
            {
                System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)c;
                textBox.Text = Key.None.ToString();
            }

            foreach (Control c in checks)
            {
                CheckBox checkBox = (CheckBox)c;
                checkBox.Checked = false;
            }

            foreach (Control c in combos)
            {
                System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)c;
                if (comboBox.Items.Count > 0)
                    comboBox.SelectedIndex = 0;
            }
        }

        private static void resetCheckboxForm(Control control)
        {

            IEnumerable<Control> checks = GetAll(control, typeof(CheckBox));
            IEnumerable<Control> combos = GetAll(control, typeof(System.Windows.Forms.ComboBox));

            foreach (Control c in checks)
            {
                CheckBox checkBox = (CheckBox)c;
                checkBox.Checked = false;
            }

            foreach (Control c in combos)
            {
                System.Windows.Forms.ComboBox comboBox = (System.Windows.Forms.ComboBox)c;
                if (comboBox.Items.Count > 0)
                    comboBox.SelectedIndex = 0;
            }
        }

        public static void ResetCheckboxForm(Form form)
        {
            resetCheckboxForm(form);
        }

        public static void ResetForm(Form form)
        {
            resetForm(form);
        }

        public static void ResetForm(Control form)
        {
            resetForm(form);
        }

        public static void ResetForm(Panel panel)
        {
            resetForm(panel);
        }

        public static void ResetForm(GroupBox group)
        {
            resetForm(group);
        }

       
    }
    public static class EnumExtensions
    {
        public static string ToDescriptionString(this EffectStatusIDs val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
        public static string GetDescription(this Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }

        public static EffectStatusIDs ToEffectStatusId(this String val)
        {

            EffectStatusIDs t = Enum.GetValues(typeof(EffectStatusIDs))
                .Cast<EffectStatusIDs>()
                .FirstOrDefault(v => v.GetDescription() == val);
            return t;
        }

        
    }
}
