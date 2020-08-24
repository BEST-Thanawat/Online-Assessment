using System;
using System.Collections.Generic;
using System.Text;

namespace Online_Assessment
{
    public class AmazonFreshPromotion
    {
        //Main
        /*
        List<List<string>> codeList = new List<List<string>>
            {
                new List<string> { "apple", "apple"},
                new List<string> { "banana", "anything", "banana"}
            };

        List<string> shoppingCart = new List<string>
            {
                "orange", "apple", "apple", "banana", "orange", "banana"
                //"banana", "orange", "banana", "apple", "apple"
            };

        int isWinner = IsWinner(codeList, shoppingCart);
        */

        public int IsWinner(List<List<string>> codeList, List<string> shoppingCart)
        {
            if (codeList.Count == 0) return 1;
            if (shoppingCart.Count == 0) return 0;

            int i = 0, j = 0;
            for (int a = 0; a < shoppingCart.Count; a++)
            {
                if (codeList[i][j] == shoppingCart[a] || codeList[i][j] == "anything")
                {
                    j++;
                    if (j == codeList[i].Count)
                    {
                        i++;
                        j = 0;
                    }

                    if (i == codeList.Count) return 1;
                }
                else
                {
                    j = codeList[i][0] == "anything" ? 1 : 0;
                }
            }
            return 0;
        }
    }
}
