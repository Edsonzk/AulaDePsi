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

            string a = "a" + 2;
            string c = "c" + x;

            string si = $"{s} interpolado"
            string ri = $@"{s} + {c} = {t} verbatim {x}";

            string sf = String.Format("{0} e {1}", s, t);

            Console.WriteLine("Valor de {0} mais {1} é {2}", x, y, x+y);

            Console.WriteLine(astro);
            Console.WriteLine(n);
            Console.WriteLine(i);
            Console.WriteLine(b);
            Console.WriteLine(g);
            Console.WriteLine(a);
            Console.WriteLine(c);
            Console.WriteLine(si);
            Console.WriteLine(ri);
            Console.WriteLine(sf);



        }
    }
}
