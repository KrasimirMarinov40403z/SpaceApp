using SpaceApp.Commands;
using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp
{
    class App
    {
        public static void run()
        {
            Dictionary<String, Galaxy> galaxies = new Dictionary<String, Galaxy>();

            Dictionary<String, Star> stars = new Dictionary<String, Star>();

            Dictionary<String, Planet> planets = new Dictionary<String, Planet>();

            Dictionary<String, Moon> moons = new Dictionary<String, Moon>();

            Console.Write(Messages.ENTER_COMMAND);

            String input;

            while (true)
            {
                input = Console.ReadLine();
                if (Commands.Command.EXIT.Equals(input))
                {
                    return;
                }
                string[] args = input.Split(Commands.Command.ARG_DELIM);
                Command command = CommandFactory.Create(args[0]);
                command.execute(args, galaxies, stars, planets, moons);
            }
        }
    }
}
