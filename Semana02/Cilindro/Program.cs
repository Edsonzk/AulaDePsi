using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {

            double a;
            double r; 
            double pi = 3,14;
            double V = (r * r) * a;
            double Sa = 2 * 3,14 * r * (r * a);

            Console.WriteLine("introduza a altura: ");
            Console.WriteLine("introduza o raio: ");
            Console.WriteLine(V);
            Console.WriteLine(Sa);
        }
    }
}
