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


            //1. `Add()` Jupiter and Saturn at the end of the list.
            planetList.Add("Jupiter");
            planetList.Add("Saturn");

            //2.Create another `List` that contains that last two planet of our solar system.
            List<string> planetList2 = new List<string>() { "Uranus", "Neptune" };
            Console.WriteLine($"\nFurthest planets in our Solar System: {string.Join(", ", planetList2)}.");

            //3.Combine the two lists by using `AddRange()`.
            planetList.AddRange(planetList2);
            Console.WriteLine($"\nAddRange() the planets list are: {string.Join(", ", planetList)}.");
            Console.WriteLine($"\nAddRange() the planets list 2 are: {string.Join(", ", planetList2)}.");

            //4.Use `Insert()` to add Earth, and Venus in the correct order.
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            Console.WriteLine($"\nThe order of planets in the Solar System: {string.Join(", ", planetList)}.");

            //5.Use `Add()` again to add Pluto to the end of the list.
            planetList.Add("Pluto");
            Console.WriteLine($"\nThe order of planets in the Solar System from the Sun: {string.Join(", ", planetList)}.");

            //6.Now that all the planets are in the list, slice the list using `GetRange()` in order to extract the rocky planets into a new list called `rockyPlanets`.
            var rockyPlanets = planetList.GetRange(0, 4);
            Console.WriteLine($"\nThe order of rocky planets in the Solar System; distanced from the Sun: {string.Join(", ", rockyPlanets)}.");

            //7.Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the `Remove()` method to eliminate it from the end of `planetList`.
            planetList.Remove(planetList.Last());

            Console.WriteLine($"\nPluto is now a dwarf planet and has been removed: {string.Join(", ", planetList)}.");

            planetList.Add("Pluto");

            Console.WriteLine($"\nPluto is now added back to the list of planets: {string.Join(", ", planetList)}.");


            // Iterating over planets

            // Ref: [List of Solar System probes](https://en.wikipedia.org/wiki/List_of_Solar_System_probes)

            //1.Create a dictionary that will hold the name of a spacecraft
            //that we have launched, and a list of names of the planets that it has
            //visited.Remember that `List` is a Type just like native types(such as `string`, `int`, & `bool`)
            //and your custom types(such as `Movie`, `Dog`, and `Food`).
            //These types can be passed to anything, like a dictionary.

            var spacecraft = new Dictionary<string, List<string>>();
            spacecraft.Add("Mariner 10", new List<string> { "Earth", "Venus", "Mercury" });
            spacecraft.Add("Messenger", new List<string> { "Mercury" });
            spacecraft.Add("Venera 1", new List<string> { "Venus" });
            spacecraft.Add("Mars Express", new List<string> { "Mars" });
            spacecraft.Add("New Horizons", new List<string> { "Pluto", "Charon" });
            spacecraft.Add("Voyager 1", new List<string> { "Jupiter", "Saturn" });
            spacecraft.Add("Voyager 2", new List<string> { "Jupiter", "Saturn", "Uranus", "Neptune" });
            spacecraft.Add("Cassini–Huygens", new List<string> { "Jupiter", "Venus", "Saturn" });
            spacecraft.Add("Juno", new List<string> { "Jupiter" });

            Console.Write("\n");

            //2.Iterate over your list of planets from above, and inside that loop,
            //iterate over the dictionary.Write to the console, for each planet,
            //which satellites have visited which planet.

            foreach (var planet in planetList)
            {
                var visited = new List<string>();

                //Console.WriteLine($"{planet}");
                foreach (var satellite in spacecraft)
                {
                    if (satellite.Value.Contains(planet))
                    {
                        visited.Add(satellite.Key);
                    }
                }
                if (visited.Count > 0)
                {
                    Console.WriteLine($"{planet}: {String.Join(",", visited)}");
                }
            }




        }
    }
}
