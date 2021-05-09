using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    class PrintCommand : Command
    {
        void Command.execute(string[] args,
                             Dictionary<string, Galaxy> galaxies,
                             Dictionary<string, Star> stars,
                             Dictionary<string, Planet> planets,
                             Dictionary<string, Moon> moons)
        {
            String name = args[1];
            Galaxy galaxy = new Galaxy();
            if (galaxies.ContainsKey(name))
            {
                galaxy = galaxies[name];
                Console.WriteLine("--- Data for " + name + " galaxy ---");
                Console.WriteLine(galaxy.ToString());
                Console.WriteLine("--- End data for " + name + " galaxy ---");
            }
        }

    }
}
