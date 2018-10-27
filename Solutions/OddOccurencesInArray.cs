using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solutions
{
    public class OddOccurencesInArray
    {
        public int Solution(int[] A, int N)
        {
            Dictionary<int, int> counterDictionary = new Dictionary<int, int>();
            foreach (var item in A)
            {
                if (!counterDictionary.ContainsKey(item))
                    counterDictionary[item] = 1;
                else
                    counterDictionary[item] = ++counterDictionary[item];
            }

            foreach (var item in counterDictionary.Keys)
            {
                if (counterDictionary[item] % 2 != 0)
                    return item;
            }
            return 0;
        }

    }
}
