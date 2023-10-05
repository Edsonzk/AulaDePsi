using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            string sAltura, sRaio;

            double a;
            double r, V, Sa; 
            double pi = 3.1415926;
            V = (r * r) * a;
            Sa = 2 * 3,14 * r * (r * a);

            Console.WriteLine("introduza a altura: ");
            Console.WriteLine("introduza o raio do cilindro: ")
            sAltura = Console.ReadLine();
            sRaio = Console.ReadLine();

            altura = double.Parse(sAltura);
            raio = double.Parse(sRaio);

            Console.WriteLine(V);
            Console.WriteLine(Sa);
        }
    }
}
