using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class BitWork
    {
        public static int bitWork(string s)
        {
            int sum = s.Sum(c => c);
            foreach(Match m in Regex.Matches(s, @"([^\d]+)(\d*)"))
            {
                int res = int.Parse(m.Groups[2].ToString());
                string op = m.Groups[1].ToString();
                switch(op)
                {
                    case "&":
                        sum &= res;
                        break;
                    case "|":
                        sum |= res;
                        break;
                    case "^":
                        sum ^= res;
                        break;
                    case "<<":
                        sum <<= res;
                        break;
                    case ">>":
                        sum >>= res;
                        break;
                    case "SB":
                        sum |= (1 << res);
                        break;
                    case "CB":
                        sum &= ~(1 << res);
                        break;
                    default: break;
                }
            }
            return sum ^ (1 << s.Length);
        }
    }
}
