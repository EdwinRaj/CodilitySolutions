using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solutions
{
    public class TapeEquilibrium
    {
        public int Solution(int[] A, int N)
        {
            int[] cummulativeSum = new int[A.Length];

            cummulativeSum[0] = A[0];

            for (int index = 1; index < A.Length; index++)
            {
                cummulativeSum[index] = cummulativeSum[index-1] + A[index];
            }

            int minValue = int.MaxValue;

            for (int index = 0; index < cummulativeSum.Length -1; index++)
            {
                minValue = Math.Min(minValue, Math.Abs(cummulativeSum[index] - (cummulativeSum[cummulativeSum.Length - 1] - cummulativeSum[index])));
            }

            return minValue;
        }

        
    }
}
