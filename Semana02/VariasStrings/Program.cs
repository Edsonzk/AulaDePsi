using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string astro = "Lua";
            string n = "this is \t a";
            string i = @"""Uma string entre aspas""";
            string b = "\u00A9 e \u2665";
            string g = @"\u00A9 e \u2665 sem UTF";

            Console.WriteLine(astro);
            Console.WriteLine(n);
            Console.WriteLine(i);
            Console.WriteLine(b);
            Console.WriteLine(g);
        }
    }
}
