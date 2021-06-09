using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_WPF
{
    class AddInfo
    {
        string course, fn, mn, ln;
        int year, sem;

        public AddInfo(string fnm, string mmn, string lmn, string cr, int yer, int s)
        {
            fn = fnm;
            mn = mmn;
            ln = lmn;
            year = yer;
            sem = s;
        }
        
        public string processAdd()
        {
            return "\n" + course + "Year: " + year + "\nSem  " + sem;
        }
    }
}
