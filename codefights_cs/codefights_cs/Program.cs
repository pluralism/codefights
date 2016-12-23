using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codefights_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FriendGroups.friendGroups(10, new int[][] {
                new int[] { 0, 9 },
                new int[] { 3, 7 },
                new int[] { 7, 9 },
                new int[] { 5, 6 },
                new int[] { 1, 5 },
                new int[] { 4, 2 }
            }));
            Console.ReadLine();
        }
    }
}
