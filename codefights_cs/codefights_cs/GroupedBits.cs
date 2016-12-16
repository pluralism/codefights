using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class GroupedBits
    {
        public static int groupedBits(int n)
        {
            int count = 0;
            bool grouping = false;

            while (n > 0)
            {
                if ((n & 1) == 1)
                {
                    if (!grouping)
                        count += 1;
                    grouping = true;
                }
                else
                    grouping = false;

                n >>= 1;
            }

            return count;
        }
    }
}
