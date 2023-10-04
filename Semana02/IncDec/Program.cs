using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 18, c;
            c = a++ + b++;

            int d = 20, e = 10, f;
            f = --d + --e;

            Console.WriteLine(c);
            Console.WriteLine(f);
        }
    }
}
