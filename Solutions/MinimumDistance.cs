using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solutions
{
    public class MinimumDistance
    {
        public int Solution(int[] A)
        {
            if (A.Length == 1)
                return 0;

            Array.Sort(A);

            int minimumNumber = int.MaxValue;

            for (int index = 0; index < A.Length-1; index++)
            {
                minimumNumber = Math.Min(Math.Abs(A[index] - A[index + 1]), minimumNumber);
                if (minimumNumber == 0)
                    return minimumNumber;
            }

            return minimumNumber;
        }
    }
}
