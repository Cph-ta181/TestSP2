using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringUtility
{
    public class StringUtility
    {
        public string reverse(string input)
        {
            string output = "";
            for (int x = input.Length - 1; x>=0; x--)
            {
                output += input.ElementAt(x);
            }
            return output;
        }

        public string capitalize(string input)
        {
            string output = "";
            foreach (char i in input)
            {
                output += char.ToUpper(i);
            }
            return output;
        }

        public string lowercase(string input)
        {
            string output = "";
            foreach (char i in input)
            {
                output += char.ToLower(i);
            }
            return output;
        }
    }
}
