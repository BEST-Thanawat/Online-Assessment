using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Online_Assessment
{
    public class SubstringOfSize
    {
        //Main
        /*
            List<string> test1 = getSubString("abcabc", 3);
            List<string> test2 = getSubString("abacab", 3);
            List<string> test2 = getSubString("awaglknagawunagwkwagl", 4);
            List<string> test2 = getSubString("abacab", 1);
         */
        public List<string> getSubString(string s, int k)
        {
            HashSet<string> hss = new HashSet<string>();
            for (int i = 0; i < s.Length - k; i++)
            {
                HashSet<char> hsc = new HashSet<char>();
                string currentStr = "";
                for (int j = 0; j < k; j++)
                {
                    char currentChar = s.ToCharArray()[i + j];
                    if (hsc.Contains(currentChar))
                    {
                        break;
                    }
                    else
                    {
                        hsc.Add(currentChar);
                        currentStr += currentChar;
                        if (currentStr.Length == k)
                        {
                            hss.Add(currentStr);
                        }
                    }
                }
            }
            return hss.ToList();
        }
    }
}
