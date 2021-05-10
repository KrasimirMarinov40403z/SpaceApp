using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    class ListCommand : Command
    {
        public const String GALAXIES = "galaxies";

        public const String STARS = "stars";

        public const String PLANETS = "planets";

        public const String MOONS = "moons";

        void Command.execute(List<String> args)
        {
            String type = args[1];

            if (GALAXIES.Equals(type))
            {
                printGalaxies(App.galaxies);
            }
            else if (STARS.Equals(type))
            {
                printStars(App.stars);
            }
            else if (PLANETS.Equals(type))
            {
                printPlanets(App.planets);
            }
            else if (MOONS.Equals(type))
            {
                printMoons(App.moons);
            }
        }

        //public override void execute(String[] args,
        //              Dictionary<String, Galaxy> galaxies,
        //              Dictionary<String, Star> stars,
        //              Dictionary<String, Planet> planets,
        //              Dictionary<String, Moon> moons)
        //{
        //    String type = args[1];

        //    if (GALAXIES.Equals(type))
        //    {
        //        printNames(galaxies);
        //    }
        //    else if (STARS.equals(type))
        //    {
        //        printNames(stars);
        //    }
        //    else if (PLANETS.equals(type))
        //    {
        //        printNames(planets);
        //    }
        //    else if (MOONS.equals(type))
        //    {
        //        printNames(moons);
        //    }
        //}

        private void printGalaxies(Dictionary<String, Galaxy> galaxies)
        {
            String result;
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<String, Galaxy> galaxy in galaxies)
            {
                sb.Append(galaxy.Key);
                sb.Append(", ");
            }
            result = sb.ToString();
            Console.WriteLine(result.Substring(0, result.Length - 2));
        }

        private void printStars(Dictionary<String, Star> stars)
        {
            String result;
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<String, Star> star in stars)
            {
                sb.Append(star.Key);
                sb.Append(", ");
            }
            result = sb.ToString();
            Console.WriteLine(result.Substring(0, result.Length - 2));
        }

        private void printPlanets(Dictionary<String, Planet> planets)
        {
            String result;
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<String, Planet> planet in planets)
            {
                sb.Append(planet.Key);
                sb.Append(", ");
            }
            result = sb.ToString();
            Console.WriteLine(result.Substring(0, result.Length - 2));
        }

        private void printMoons(Dictionary<String, Moon> moons)
        {
            String result;
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<String, Moon> moon in moons)
            {
                sb.Append(moon.Key);
                sb.Append(", ");
            }
            result = sb.ToString();
            Console.WriteLine(result.Substring(0, result.Length - 2));
        }
    }
}
