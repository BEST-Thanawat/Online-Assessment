using System;
using System.Collections.Generic;
using System.Linq;

namespace Online_Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PairString> input = new List<PairString> {
                new PairString("item1", "item2"),
                new PairString("item3", "item4"),
                new PairString("item4", "item5")
            };

            List<string> result = LargestItemAssociation(input);
        }

        public static List<string> LargestItemAssociation(List<PairString> itemAssociation)
        {

        }
    }

    public class PairString
    {
        public string First;
        public string Second;

        public PairString(string first, string second)
        {
            First = first;
            Second = second;
        }
    }
}
