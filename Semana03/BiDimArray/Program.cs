using System;

namespace BiDimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            int dh, dv;
            float[,] biDim;

            Console.WriteLine("introduza a dimensão horizontal: ");
            a = Console.ReadLine();
            dh = int.Parse(a);
            Console.WriteLine("introduza a dimensão vertical: ");
            b = Console.ReadLine();
            dv = int.Parse(b);

            biDim = new float[dv, dh];

            for (int i = 0; i < biDim.GetLength(0); i++)
            {
	             for (int c = 0; c < biDim.GetLength(1); c++)
            {
		         Console.Write(biDim[ i, c ]);
	        }
	             Console.WriteLine();
            }

            Console.WriteLine("");
        }
    }
}
