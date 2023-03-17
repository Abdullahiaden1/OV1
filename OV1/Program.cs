
using System;

namespace Ålder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv din ålder:");
            int Dinålder = int.Parse(Console.ReadLine());

            Kollaålder (Dinålder);
        }

        static void Kollaålder (int ålder)
        {
            if (ålder >= 18)
            {
                Console.WriteLine("Du är myndig.");
            }
            else
            {
                Console.WriteLine("Du är inte myndig.");
            }
        }
    }
}
