using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    class StatsCommand : Command
    {
        public void execute(List<String> args)
        {
            Console.WriteLine("--- Stats ---");
            Console.WriteLine("Galaxies: " + App.galaxies.Values.Count);
            Console.WriteLine("Stars: " + App.stars.Values.Count);
            Console.WriteLine("Planets: " + App.planets.Values.Count);
            Console.WriteLine("Moons: " + App.moons.Values.Count);
            Console.WriteLine("--- End of stats ---");
        }
    }
}
