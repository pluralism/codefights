using System;

namespace codefights_cs
{
    class Program
    {
        static void Main(string[] args)
        {
            ISBN13 i = new ISBN13();
            Console.WriteLine(i.isbn13("150-114-206")[0]);
            Console.WriteLine(i.isbn13("150-114-206")[1]);
            Console.ReadLine();
        }
    }
}
