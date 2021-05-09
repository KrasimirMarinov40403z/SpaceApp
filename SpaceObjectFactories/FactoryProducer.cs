using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObjectFactories
{
    class FactoryProducer
    {
        public static AbstractFactory getFactory(String spaceObjectType)
        {
            switch (spaceObjectType)
            {
                case SpaceObject.SpaceObject.GALAXY:
                    return new GalaxyFactory();
                case SpaceObject.SpaceObject.STAR:
                    return new StarFactory();
                case SpaceObject.SpaceObject.PLANET:
                    return new PlanetFactory();
                case SpaceObject.SpaceObject.MOON:
                    return new MoonFactory();
                default:
                    return null;
            }
        }
    }
}
