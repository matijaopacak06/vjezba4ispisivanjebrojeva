using System;

namespace IspisivanjeBrojeva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite pozitivan broj:");
            int broj = int.Parse(Console.ReadLine());

            for (int i = 1; i < broj; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
