using System.Collections.Generic;
using System.Windows.Input;

namespace _4RTools.Utils
{
    internal class KeyMap
    {
        public static Dictionary<string, Key> getDict()
        {
            Dictionary<string, Key> dictionary = new Dictionary<string, Key>();
            dictionary.Add("None", Key.None);
            dictionary.Add("F1", Key.F1);
            dictionary.Add("F2", Key.F2);
            dictionary.Add("F3", Key.F3);
            dictionary.Add("F4", Key.F4);
            dictionary.Add("F5", Key.F5);
            dictionary.Add("F6", Key.F6);
            dictionary.Add("F7", Key.F7);
            dictionary.Add("F8", Key.F8);
            dictionary.Add("F9", Key.F9);
            dictionary.Add("1", Key.D1);
            dictionary.Add("2", Key.D2);
            dictionary.Add("3", Key.D3);
            dictionary.Add("4", Key.D4);
            dictionary.Add("5", Key.D5);
            dictionary.Add("6", Key.D6);
            dictionary.Add("7", Key.D7);
            dictionary.Add("8", Key.D8);
            dictionary.Add("9", Key.D9);
            dictionary.Add("0", Key.D0);
            dictionary.Add("A", Key.A);
            dictionary.Add("B", Key.B);
            dictionary.Add("C", Key.C);
            dictionary.Add("D", Key.D);
            dictionary.Add("E", Key.E);
            dictionary.Add("F", Key.F);
            dictionary.Add("G", Key.G);
            dictionary.Add("H", Key.H);
            dictionary.Add("I", Key.I);
            dictionary.Add("J", Key.J);
            dictionary.Add("K", Key.K);
            dictionary.Add("L", Key.L);
            dictionary.Add("M", Key.M);
            dictionary.Add("N", Key.N);
            dictionary.Add("O", Key.O);
            dictionary.Add("P", Key.P);
            dictionary.Add("Q", Key.Q);
            dictionary.Add("R", Key.R);
            dictionary.Add("S", Key.S);
            dictionary.Add("T", Key.T);
            dictionary.Add("U", Key.U);
            dictionary.Add("V", Key.V);
            dictionary.Add("W", Key.W);
            dictionary.Add("X", Key.X);
            dictionary.Add("Y", Key.Y);
            dictionary.Add("Z", Key.Z);
            dictionary.Add("Space", Key.Space);
            dictionary.Add("PageDown", Key.PageDown);
            dictionary.Add("PageUp", Key.PageUp);
            dictionary.Add("Insert", Key.Insert);
            dictionary.Add("Delete", Key.Delete);
            return dictionary;
        }

        public static Key fromInteger(int keycode)
        {
            return (Key) keycode;
        }
    }
}
