using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    class PrintCommand : Command
    {
        void Command.execute(List<String> args)
        {
            String name = args[1];
            Galaxy galaxy = new Galaxy();
            if (App.galaxies.ContainsKey(name))
            {
                galaxy = App.galaxies[name];
                Console.WriteLine("--- Data for " + name + " galaxy ---");
                Console.WriteLine(galaxy.ToString());
                Console.WriteLine("--- End data for " + name + " galaxy ---");
            }
        }

    }
}
