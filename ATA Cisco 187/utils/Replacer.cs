using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATA_Cisco_187.utils
{
    internal class Replacer
    {
        public static string Replace(string text, string[] oldValues, string[] newValues)
        {
            if (oldValues.Length != newValues.Length)
            {
                throw new ArgumentException("oldValues and newValues must have the same length");
            }
            for (int i = 0; i < oldValues.Length; i++)
            {
                text = text.Replace(oldValues[i], newValues[i]);
            }
            return text;
        }
    }
}
