using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4RTools.Utils
{
    internal class KeyMap
    {
        public static Dictionary<string, Keys> getDict()
        {
            Dictionary<string, Keys> dictionary = new Dictionary<string, Keys>();
            dictionary.Add("F1", Keys.F1);
            dictionary.Add("F2", Keys.F2);
            dictionary.Add("F3", Keys.F3);
            dictionary.Add("F4", Keys.F4);
            dictionary.Add("F5", Keys.F5);
            dictionary.Add("F6", Keys.F6);
            dictionary.Add("F7", Keys.F7);
            dictionary.Add("F8", Keys.F8);
            dictionary.Add("F9", Keys.F9);
            dictionary.Add("1", Keys.D1);
            dictionary.Add("2", Keys.D2);
            dictionary.Add("3", Keys.D3);
            dictionary.Add("4", Keys.D4);
            dictionary.Add("5", Keys.D5);
            dictionary.Add("6", Keys.D6);
            dictionary.Add("7", Keys.D7);
            dictionary.Add("8", Keys.D8);
            dictionary.Add("9", Keys.D9);
            dictionary.Add("0", Keys.D0);
            dictionary.Add("A", Keys.A);
            dictionary.Add("B", Keys.B);
            dictionary.Add("C", Keys.C);
            dictionary.Add("D", Keys.D);
            dictionary.Add("E", Keys.E);
            dictionary.Add("F", Keys.F);
            dictionary.Add("G", Keys.G);
            dictionary.Add("H", Keys.H);
            dictionary.Add("I", Keys.I);
            dictionary.Add("J", Keys.J);
            dictionary.Add("K", Keys.K);
            dictionary.Add("L", Keys.L);
            dictionary.Add("M", Keys.M);
            dictionary.Add("N", Keys.N);
            dictionary.Add("O", Keys.O);
            dictionary.Add("P", Keys.P);
            dictionary.Add("Q", Keys.Q);
            dictionary.Add("R", Keys.R);
            dictionary.Add("S", Keys.S);
            dictionary.Add("T", Keys.T);
            dictionary.Add("U", Keys.U);
            dictionary.Add("V", Keys.V);
            dictionary.Add("W", Keys.W);
            dictionary.Add("X", Keys.X);
            dictionary.Add("Y", Keys.Y);
            dictionary.Add("Z", Keys.Z);
            return dictionary;
        }
    }
}
