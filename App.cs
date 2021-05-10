using SpaceApp.Commands;
using SpaceApp.SpaceObject;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp
{
    class App
    {
        public static Dictionary<String, Galaxy> galaxies = new Dictionary<String, Galaxy>();

        public static Dictionary<String, Star> stars = new Dictionary<String, Star>();

        public static Dictionary<String, Planet> planets = new Dictionary<String, Planet>();

        public static Dictionary<String, Moon> moons = new Dictionary<String, Moon>();

        public static void run()
        {
            Console.Write(Messages.ENTER_COMMAND);

            String input;

            while (true)
            {
                input = Console.ReadLine();
                if (Commands.Command.EXIT.Equals(input))
                {
                    return;
                }
                List<String> args = splitInput(input);
                Command command = CommandFactory.Create(args[0]);
                command.execute(args);
            }
        }

        private static List<String> splitInput(String input)
        {
            int lsb, rsb;
            var result = new List<String>();
            String[] args = input.Split(Command.ARG_DELIM);

            for (int i = 0; i < args.Length; i++)
            {
                String expr = "";
                lsb = args[i].IndexOf("[");
                if (lsb >= 0 && (rsb = args[i].IndexOf("]")) > lsb)
                { // [Sun]
                    expr = args[i].Substring(lsb + 1, rsb -1);
                }
                else if (lsb >= 0)
                { // [Milky Way 1]
                    expr += args[i].Substring(lsb + 1) + " ";
                    for (int j = i + 1; j < args.Length; j++)
                    {
                        if ((rsb = args[j].IndexOf("]")) >= 0)
                        {
                            expr += args[j].Substring(0, rsb - 1) + " ";
                            i = j;
                            break;
                        }
                        expr += args[j] + " ";
                    }
                }
                else
                { // add star
                    expr = args[i];
                }
                result.Add(expr.Trim());
            }

            return result;
        }
    }
}
