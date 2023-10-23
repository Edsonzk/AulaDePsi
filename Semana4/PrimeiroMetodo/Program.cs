using System;

namespace PrimeiroMetodo
{
    class Program
    {
        static void Main(string[] args)
        {/*
            ContarAte10();
            Console.WriteLine("");
            ContarAte10();
            Console.WriteLine("");
*/
            int a;
            for (int i = 1; i <= 2; i++){
            Console.WriteLine("Introduza um numero: ");
            a = int.Parse(Console.ReadLine());
           
            ContarAteN(a);
             Console.WriteLine();


            }
            ContarAte10();
           
           
        }
        static void ContarAte10()
        {   
            ContarAteN(10);
            Console.WriteLine();
            ContarAteN(10);
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