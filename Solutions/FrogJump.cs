using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public class FrogJump
    {
        public int Solution(int X, int Y, int D)
        {
            if (X == Y) return 0;

            var diff = Math.Abs(X - Y);

            var minJumps = diff / D;
            var remaining = diff % D;
            var totalJumps = minJumps;

            if (minJumps == 0) totalJumps = 1;
            else if (minJumps > 0 && remaining > 0)
                totalJumps = totalJumps + 1;

            return totalJumps;
        }
    }
}
