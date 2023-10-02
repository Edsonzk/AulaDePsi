using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string astro = "Lua";
            string n = @"this is \b";
            string i = """Uma string entre aspas""";
            string b = @"\u00A9 e \u2665";
            string g = "\u00A9 e \u2665 sem UTF";

            console.WriteLine(astro);
            console.WriteLine(n);
            console.WriteLine(i);
            console.WriteLine(b);
            console.WriteLine(g);
        }
    }
}
