using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class WholeSquare
    {
        public int Solution(int A, int B)
        {
            if (A <= 0 && B <= 0)
                return 0;

            if (A <= 0 && B > 0)
                A = 1;

            if (A == B)
            {
                return Math.Sqrt(A) % 1 == 0 ? 1 : 0;
            }

            int perfectSquareCount = 0;

            var squareroot = Math.Sqrt(A);
            if (squareroot % 1 == 0)
            {
                perfectSquareCount++;
            }
            int nextroot = (int)squareroot + 1;
            int nextSquare = nextroot * nextroot;

           
            while(nextSquare <= B)
            {
                perfectSquareCount++;
                nextroot++;
                nextSquare = nextroot * nextroot;

            }

            return perfectSquareCount;

        }
    }
}
