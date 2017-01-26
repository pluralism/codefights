using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class HolidayBreak
    {
        public static int holidayBreak(int y)
        {
            DateTime i = new DateTime(y, 12, 22);
            while ((int) i.DayOfWeek == 6 || (int) i.DayOfWeek == 0 || (int) i.DayOfWeek == 1)
                i = i.AddDays(-1);

            if ((int)i.DayOfWeek < 3)
                while ((int)i.DayOfWeek != 5)
                    i = i.AddDays(-1);

            i = i.AddDays(1);
     
            DateTime f = new DateTime(y + 1, 1, 1);
            if ((int)f.DayOfWeek >= 3 && (int)f.DayOfWeek <= 6)
                while ((int)f.DayOfWeek != 0)
                    f = f.AddDays(1);
            else if ((int)f.DayOfWeek == 0)
                f = f.AddDays(1);

            return (int) (f - i).TotalDays + 1;
        }
    }
}
