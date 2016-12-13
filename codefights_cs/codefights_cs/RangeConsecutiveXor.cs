using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class RangeConsecutiveXor
    {
        /**
         * Let's consider a sequence X1 = 1, X2 = 1 ^ 2, ..., Xn = 1 ^ ... ^ n, where ^ is a bitwise xor.
         * Given l and r, find the value of Xl ^ Xl + 1 ^ ... ^ Xr
         * 
         * If l = 2 then Xl = X2 = 1 ^ 2 and X(l + 2) = X4 = 1 ^ 2 ^ 3 ^ 4
         * (1 ^ 2) ^ (1 ^ 2 ^ 3) ^ (1 ^ 2 ^ 3 ^ 4)
        */
        public static int rangeConsecutiveXor(int l, int r)
        {
            /**
             * Xn = 1 ^ 2 ^ ... ^ n
             * 
             * The sequence appears to be always as follows:
             *  n, 2, 2, n + 2, n + 2, 0, 0, n
             */
            Func<int, int> calculate = i => {
                int[] seq = new int[] { i, 2, 2, i + 2, i + 2, 0, 0, i };
                return seq[i > 1 ? (i - 1) % 8 : 0];
            };

            return calculate(l - 1) ^ calculate(r);
        }
    }
}
