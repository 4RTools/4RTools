using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Input;
using static System.Windows.Forms.Control;

namespace _4RTools.Utils
{
    public class FormUtils
    {

        public static void OnKeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            try
            {
                TextBox textBox = (TextBox)sender;
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

                e.Handled = true;
            }
            catch { }
        }

        public static void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private static void resetForm(ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = Key.None.ToString();
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }
            }
        }

        public static void ResetForm(Form form)
        {
            resetForm(form.Controls);
        }

        public static void ResetForm(Panel panel)
        {
            resetForm(panel.Controls);
        }

        public static void ResetForm(GroupBox group)
        {
            resetForm(group.Controls);
        }
    }
}
