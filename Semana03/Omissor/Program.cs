using System;

namespace Omissor
{
    class Program
    {
        static void Main(string[] args)
        {
            string f;
            string sc;
            char c;

            //solicita ao utilizador uma string para o programa
            Console.WriteLine("Introduza uma frase: ");
            f = Console.ReadLine();

            Console.WriteLine("Introduza um caracter: ");
            sc = Console.ReadLine();
            c = char.Parse(sc);
            foreach (char aC in f)
            {
                if(aC != c)
                Console.Write(aC);
            }

        }
    }
}
