using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    public class FriendGroups
    {
        public static int DFS(int e, Dictionary<int, List<int>> d, ref Dictionary<int, bool> c)
        {
            var r = new List<int>();
            var r1 = new Stack<int>();
            r1.Push(e);

            while(r1.Count != 0)
            {
                int v = r1.Pop();
                if(!c[v])
                {
                    r.Add(v);
                    c[v] = true;
                    var s = d[v];
                    for (int i = 1; i < s.Count; i++)
                        r1.Push(s[i]);
                }
            }
            return r.Count > 0 ? 1 : 0;
        }


        public static int friendGroups(int n, int[][] f)
        {
            var g = new Dictionary<int, List<int>>();
            var v = new Dictionary<int, bool>();
            for (int i = 0; i < n; i++)
            {
                v.Add(i, false);
                g.Add(i, new List<int>(new int[] { i }));
            }

            foreach(int[] c in f)
            {
                g[c[0]].Add(c[1]);
                g[c[1]].Add(c[0]);
            }

            int a = 0;
            for (int i = 0; i < n; i++)
                a += DFS(i, g, ref v);

            return a;
        }
    }
}
