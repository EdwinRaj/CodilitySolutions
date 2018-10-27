using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Solutions
{
    public class Deriv
    {
        public int MinNextSmallPositive(int[] A)
        {
            int nextNo = 1;
            var orderedA = A.OrderBy(x => x).ToList();


            for (int index = 0; index < orderedA.Count - 1; index++)
            {
                if (orderedA[index] < 0)
                    continue;

                if (orderedA[index] == orderedA[index + 1])
                    continue;

                if (orderedA[index] + 1 == orderedA[index + 1])
                {
                    if (index + 1 == orderedA.Count)
                    {
                        nextNo = orderedA[index] + 1;
                        break;
                    }
                    continue;
                }

                if (orderedA[index + 1] - orderedA[index] > 1)
                {
                    nextNo = orderedA[index] + 1;
                    break;
                }

                if (index + 1 == orderedA.Count)
                {
                    nextNo = orderedA[index] + 1;
                }
            }

            return nextNo;
        }
    }
}
