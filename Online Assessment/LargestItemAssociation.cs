using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Online_Assessment
{
    public class LargestItemAssociation
    {
        //Main
        /*
        List<PairString> input = new List<PairString> {
                //new PairString("item1", "item2"),
                //new PairString("item3", "item4"),
                //new PairString("item4", "item5")

                new PairString("item3", "item4"),
                new PairString("item1", "item2"),
                new PairString("item5", "item6"),
                new PairString("item4", "item5"),
                new PairString("item2", "item7"),
                new PairString("item7", "item8"),
                new PairString("item2", "item3"),
                new PairString("item6", "item7"),
                new PairString("item0", "item2")
            };

        List<string> result = LargestItemAssociation(input);
        */

        public List<string> LargestItemAss(List<PairString> itemAssociation)
        {
            if (itemAssociation == null) return null;
            if (itemAssociation.Count == 0) return null;

            //itemAssociation.Reverse();
            List<SortedSet<string>> ss = new List<SortedSet<string>>();
            foreach (var item in itemAssociation)
            {
                if (!ss.Any(x => x.Contains(item.First) || ss.Any(x => x.Contains(item.Second))))
                {
                    SortedSet<string> itemToAdd = new SortedSet<string>() { item.First, item.Second };
                    ss.Add(itemToAdd);
                }
                else
                {
                    SortedSet<string> f = ss.FirstOrDefault(x => x.Contains(item.First));
                    SortedSet<string> s = ss.FirstOrDefault(x => x.Contains(item.Second));
                    if (f == null)
                    {
                        s.Add(item.First);
                    }
                    else if (s == null)
                    {
                        f.Add(item.Second);
                    }
                    else if (f != s)
                    {
                        foreach (var itemS in s)
                        {
                            f.Add(itemS);
                        }
                        ss.Remove(s);
                    }
                }
            }

            return ss.OrderByDescending(x => x.Count).First().ToList();
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
}
