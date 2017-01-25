using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class PossibleRing
    {
        public static int possibleRing(string a)
        {
            float c = 0, n = 0, h = 0, h1 = 0, o = 0;
            List<string> f = new List<string>();
            Regex pattern = new Regex(@"(?<molecule>(F|Cl|Br|I|At|\D{1}))(?<numberOfMolecules>\d*)");
            foreach(Match match in pattern.Matches(a))
            {
                string l = match.Groups["molecule"].Value;
                if (f.Contains(l))
                    return -1;
                f.Add(l);
                if (a.Substring(0, match.Index + 1).All(char.IsDigit))
                    return -1;
                int v;
                int.TryParse(match.Groups["numberOfMolecules"].Value, out v);
                if (v == 0)
                    v = 1;

                if (l == "C")
                    c += v;
                else if (l == "N")
                    n += v;
                else if (l == "H")
                    h += v;
                else if (l == "O")
                    o += v;
                else
                    h1 += v;
            }

            float d = c + n / 2 - (h + h1) / 2 + 1;
            if (d % 1 == 0)
            {
                if (d > c + n + o - 2)
                    return (int) (c + n + o - 2);
                return (int) d <= 0 ? -1 : (int) d;
            }
            return -1;
        }
    }
}
