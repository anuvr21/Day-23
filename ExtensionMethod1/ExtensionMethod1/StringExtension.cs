using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod1
{
    public static class StringExtension
    {
        public static string Concatenate(this string s, string snew)
        { 
            return s+snew;
        }
    }
}
