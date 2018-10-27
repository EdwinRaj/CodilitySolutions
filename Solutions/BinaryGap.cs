using System;

namespace Solutions
{
    public class BinaryGap
    {
        public int Calculate(int N)
        {
            if (N < 5) return 0;

            int previousRemainder = -100;
            bool isPreviousRemainderInitialised = false;
            bool isInBinaryGap = false;
            int binaryGapCounter = 0, maxBinaryGap = 0;

            while (N > 1)
            {
                var remainder = N % 2;

                if (isPreviousRemainderInitialised == false)
                {
                    previousRemainder = remainder;
                    isPreviousRemainderInitialised = true;
                    N = N / 2;
                    continue;
                }

                if (remainder == 0 && previousRemainder == 1 && isInBinaryGap == false)
                {
                    isInBinaryGap = true;
                    binaryGapCounter++;
                }
                else if(remainder == 1 && isInBinaryGap)
                {
                    isInBinaryGap = false;

                    if(maxBinaryGap < binaryGapCounter)
                    {
                        maxBinaryGap = binaryGapCounter;
                    }
                    binaryGapCounter = 0;
                }
                else if(remainder == 0 && isInBinaryGap)
                {
                    binaryGapCounter++;
                }

                N = N / 2;
                previousRemainder = remainder;
            }

            if(isInBinaryGap && binaryGapCounter > maxBinaryGap)
            {
                maxBinaryGap = binaryGapCounter;
            }

            return maxBinaryGap;

        }
    }
}
