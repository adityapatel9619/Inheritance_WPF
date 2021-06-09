using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_WPF
{
    class Inherit
    {
        public string fn, mn, ln;

        public Inherit()
        {

        }

        public Inherit(string f, string m, string l)
        {
            fn = f;
            mn = m;
            ln = l;
        }

        public string processbasic()
        {
            return "Welcome " + fn + " " + mn + " " + ln;
        }
    }
}
