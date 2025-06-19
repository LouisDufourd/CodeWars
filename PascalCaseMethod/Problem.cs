using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata
{
    public static class Problem
    {
        public static string CamelCase(this string str)
        {
            if (str == "" || str == null) return "";

            string pascalCase = "";
            string[] words = str.Split(' ');
            
            foreach(string word in words) {
                if (word == "") continue;
                pascalCase += word.Substring(0, 1).ToUpper() + word.Substring(1);
            }

            return pascalCase;
        }
    }
}
