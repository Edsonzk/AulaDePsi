using System;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            int b;
            string n;
            // solicita o numero de linhas ao utilizador
            Console.WriteLine("introduza o n de linhas: ");
            Console.WriteLine();
            n = Console.ReadLine();
            b = Int32.Parse(n);


            if (b >= 2)
            {
                for (int i = 1; i <= b; i++)
                {
                    for (int j = 1; j < b - i; j++)
                    {
                        Console.Write(" ");
                    }


                    for (int k = 1; k <= 2 * i - 1; k++)
                    {
                        Console.Write("*");
                    }


                    Console.WriteLine();
                }
            }

        }
    }
}