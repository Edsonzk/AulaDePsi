﻿using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            string sAltura, sRaio;

            double altura;
            double raio, V, Sa; 
        
          

            Console.WriteLine("introduza a altura e o raio do cilindro: ");

            sAltura = Console.ReadLine();
            sRaio = Console.ReadLine();

            altura = double.Parse(sAltura);
            raio = double.Parse(sRaio);

            V = Math.PI * Math.Pow(raio , 2) * altura;
            Sa = 2 * Math.PI() * raio * (raio * altura);

            Console.WriteLine();
            Console.WriteLine($"cilindro com {altura} altura e {raio} raio tem:\n");
            Console.WriteLine($"volume: {V}\n");
            Console.WriteLine($"Area de superficie {Sa}");
        }
    }
}
