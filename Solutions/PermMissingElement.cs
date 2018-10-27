using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solutions
{
    public class PermMissingElement
    {
        public int solution(int[] A, int N)
        {
            var x = A.Sum();
            var expected = N * (N + 1) / 2;
            return (N + 1) - (x - expected);
        }

        public int solutionXor(int[] A, int N)
        {
            int missingElement = N + 1;
            for (int index = 0; index < A.Length; index++)
            {
                missingElement = missingElement ^ A[index] ^ index + 1;
            }
            return missingElement;
        }
    }
}
