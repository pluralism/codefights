using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    class RangeConsecutiveXor
    {
        public static int rangeConsecutiveXor(int l, int r)
        {
            /**
             * Xn = 1 ^ 2 ^ ... ^ n
             * 
             * The sequence appears to be always as follows:
             *  1, n + 1, 0, n
             */
            int[] seq = new int[] { 1, r + 1, 0, r };

            return seq[(r - 1) % 4];
        }
    }
}
