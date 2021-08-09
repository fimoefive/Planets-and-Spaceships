using System;
using System.Collections.Generic;
using System.Linq;

namespace Planets_and_Spaceships
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Planets & Spaceships\n\n");

            List<string> planetList = new List<string>() { "Mercury", "Mars" };
            Console.WriteLine($"Planets in the Solar System: {string.Join(", ", planetList)}.");
        }
    }
}
