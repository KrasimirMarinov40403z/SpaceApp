using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.Commands
{
    class AddCommand : Command
    {
        public void execute(List<String> args)
        {
            SpaceObject.SpaceObject spaceObject = SpaceObject.SpaceObject.Create(args);
            addSpaceObject(spaceObject);
        }

        private void addSpaceObject(SpaceObject.SpaceObject spaceObject)
        {
            if (spaceObject is Galaxy) {
                Galaxy galaxy = (Galaxy)spaceObject;
                App.galaxies.Add(galaxy.getName(), galaxy);
            } else if (spaceObject is Star) {
                Star star = (Star)spaceObject;
                Galaxy galaxy;
                App.stars.Add(star.getName(), star);
                if (App.galaxies.ContainsKey(star.getGalaxyName()))
                {
                    galaxy = App.galaxies[star.getGalaxyName()];
                    galaxy.addStars(star);
                }
            } else if (spaceObject is Planet) {
                Planet planet = (Planet)spaceObject;
                Star star;
                App.planets.Add(planet.getName(), planet);
                if (App.stars.ContainsKey(planet.getStarName()))
                {
                    star = App.stars[planet.getStarName()];
                    star.addPlanet(planet);
                }
            } else if (spaceObject is Moon) {
                Moon moon = (Moon)spaceObject;
                Planet planet;
                App.moons.Add(moon.getName(), moon);
                if (App.planets.ContainsKey(moon.getPlanetName()))
                {
                    planet = App.planets[moon.getPlanetName()];
                    planet.addMoon(moon);
                }
            }
        }
    }
}
