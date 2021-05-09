using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    class UnknownCommand : Command
    {
        public void execute(string[] args, Dictionary<string, Galaxy> galaxies, Dictionary<string, Star> stars, Dictionary<string, Planet> planets, Dictionary<string, Moon> moons)
        {
            Console.WriteLine(Messages.UNKNOWN_COMMAND);
        }
    }
}
