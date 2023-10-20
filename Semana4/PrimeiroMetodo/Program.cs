using System;

namespace PrimeiroMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
           /* ContarAte10();
            Console.WriteLine("");
            ContarAte10();
            Console.WriteLine("");
        }
        static void ContarAte10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/
            int a;
            Console.WriteLine("Introduza um numero: ");
            a = int.Parse(Console.ReadLine());
            ContarAteN(a);
            Console.WriteLine();
            ContarAteN(a);
            Console.WriteLine();

        }
        static void ContarAteN(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                Console.WriteLine(i);
            }
    }
}
}