using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            string sAltura, sRaio;

            double altura;
            double raio, V, Sa; 
            double pi = 3.1415926;
          

            Console.WriteLine("introduza a altura e o raio do cilindro: ");

            sAltura = Console.ReadLine();
            sRaio = Console.ReadLine();

            altura = double.Parse(sAltura);
            raio = double.Parse(sRaio);

            V = (raio * raio) * altura;
            Sa = 2 * pi * raio * (raio * altura);

            Console.WriteLine();
            Console.WriteLine($"cilindro com {altura}" e {raio} tem:\n");
            Console.WriteLine($"volume: {V}\n")
            Console.WriteLine($"Area de superficie {Sa}");
        }
    }
}
