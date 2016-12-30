using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class CodeFight
    {
        public static string[] codeFight(int n)
        {
            string[] a = new string[n];
            Enumerable.Range(1, n).ToList().ForEach(_ =>
            {
                a[_ - 1] = (_ % 5 == 0 ? "Code" : "") + (_ % 7 == 0 ? "Fight" : "");
                a[_ - 1] += a[_ - 1].Length == 0 ? _.ToString() : "";
            });
            return a;
        }
    }
}
