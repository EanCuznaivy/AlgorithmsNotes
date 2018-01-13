using System;
using System.Collections.Generic;
using System.Text;

namespace BasicUtility
{
    public static class ExtensionMethods
    {
        public static string ToBinaryString(this int Numnber)
        {
            string str = "";
            for (int n = Numnber; n > 0; n /= 2)
                str = (n % 2) + str;
            return str;
        }
    }
}
