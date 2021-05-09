using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    class AddCommand : Command
    {
        public void execute(String[] args,
                            Dictionary<String, Galaxy> galaxies,
                            Dictionary<String, Star> stars,
                            Dictionary<String, Planet> planets,
                            Dictionary<String, Moon> moons)
        {
            SpaceObject.SpaceObject spaceObject = SpaceObject.SpaceObject.Create(args);
            addSpaceObject(spaceObject, galaxies, stars, planets, moons);
        }

        private void addSpaceObject(SpaceObject.SpaceObject spaceObject,
                                    Dictionary<String, Galaxy> galaxies,
                                    Dictionary<String, SpaceObject.Star> stars,
                                    Dictionary<String, SpaceObject.Planet> planets,
                                    Dictionary<String, SpaceObject.Moon> moons)
        {
            if (spaceObject is Galaxy) {
                Galaxy galaxy = (Galaxy)spaceObject;
                galaxies.Add(galaxy.getName(), galaxy);
            } else if (spaceObject is Star) {
                Star star = (Star)spaceObject;
                Galaxy galaxy;
                stars.Add(star.getName(), star);
                if (galaxies.ContainsKey(star.getGalaxyName()))
                {
                    galaxy = galaxies[star.getGalaxyName()];
                    galaxy.addStars(star);
                }
            } else if (spaceObject is Planet) {
                Planet planet = (Planet)spaceObject;
                Star star;
                planets.Add(planet.getName(), planet);
                if (stars.ContainsKey(planet.getStarName()))
                {
                    star = stars[planet.getStarName()];
                    star.addPlanet(planet);
                }
            } else if (spaceObject is Moon) {
                Moon moon = (Moon)spaceObject;
                Planet planet;
                moons.Add(moon.getName(), moon);
                if (planets.ContainsKey(moon.getPlanetName()))
                {
                    planet = planets[moon.getPlanetName()];
                    planet.addMoon(moon);
                }
            }
        }
    }
}
