    using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class CyclicRotation
    {
        public int[] Rotate(int[] A, int K)
        {
            var totalItems = A.Length;
            K = K % totalItems;
            int[] result = new int[A.Length];

            for (int index = 0; index < totalItems; index++)
            {
                var newIndex = index + K;
                if (newIndex == totalItems)
                    newIndex = 0;
                else if (newIndex > totalItems)
                    newIndex = newIndex % totalItems;

                result[newIndex] = A[index];
            }

            return result;
        }
    }
}
