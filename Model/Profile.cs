using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4RTools.Model
{
    internal class Profile
    {
        private Autopot autopot { get; set; }
        private AHK ahk { get; set; }


        public Profile LoadProfile(string jsonpath)
        {
            return new Profile();
        }
    }
}
