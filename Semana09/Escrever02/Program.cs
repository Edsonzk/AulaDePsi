using System;

namespace Escrever02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*Programa deve ler input do utilizador, uma string de cada vez
            Guardar strings num array, à medida que são lidas
            Quando o utilizador inserir uma string vazia:
            O programa guarda as strings lidas para um ficheiro e termina*/

            string[] strings = new string[100];
            int i = 0;
            while (true)
            {
                Console.WriteLine("Insira uma string:");
                string s = Console.ReadLine();
                if (s == "")
                {
                    string[] stringsToWrite = new string[i];
                    Array.Copy(strings, stringsToWrite, i);
                    System.IO.File.WriteAllLines("strings.txt", stringsToWrite);
                    break;
                }



        }
    }
}
}