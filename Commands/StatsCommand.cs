using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    class StatsCommand : Command
    {
        public void execute(string[] args, Dictionary<string, Galaxy> galaxies, Dictionary<string, Star> stars, Dictionary<string, Planet> planets, Dictionary<string, Moon> moons)
        {
            Console.WriteLine("--- Stats ---");
            Console.WriteLine("Galaxies: " + galaxies.Values.Count);
            Console.WriteLine("Stars: " + stars.Values.Count);
            Console.WriteLine("Planets: " + planets.Values.Count);
            Console.WriteLine("Moons: " + moons.Values.Count);
            Console.WriteLine("--- End of stats ---");
        }
    }
}
