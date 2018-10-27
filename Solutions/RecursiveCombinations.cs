using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solutions
{
    public class RecursiveCombinations
    {
        HashSet<int> uniqueItems = new HashSet<int>();
        public int Possibles(int N)
        {
            List<int> digits = new List<int>();

            while (N != 0)
            {
                digits.Add(N % 10);
                N = N / 10;
            }

            HashSet<int> uniqueSet = new HashSet<int>();
            digits.ForEach(x => uniqueSet.Add(x));
            int fact = 1;

            if (uniqueSet.Count == digits.Count && digits.Any(x => x != 0))
            {

                int runningIndex = digits.Count;
                while (runningIndex > 0)
                {
                    fact = fact * runningIndex;
                    runningIndex--;
                }
            }


            //for (int insertIndex = 0; insertIndex < digits.Count; insertIndex++)
            //{
            //    int holdingNumber = 0;
            //    for (int combiningIndex = 0; combiningIndex < digits.Count; combiningIndex++)
            //    {
            //        if (insertIndex == combiningIndex) continue;
            //        if (holdingNumber == 0)
            //            holdingNumber = digits[combiningIndex];
            //        else
            //        {
            //            holdingNumber = (holdingNumber * 10) + digits[combiningIndex];
            //        }
            //    }

            //    int insertingNumber = digits[insertIndex];

            //   holdingNumber.

            return 0;


        }
    }
}

