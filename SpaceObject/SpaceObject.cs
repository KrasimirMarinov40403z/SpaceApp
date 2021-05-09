using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObject
{
    class SpaceObject
    {

        public const String GALAXY = "galaxy";

        public const String STAR = "star";

        public const String PLANET = "planet";

        public const String MOON = "moon";

        private String name;

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public static SpaceObject Create(String[] args)
        {
            SpaceObjectFactories.AbstractFactory spaceObjectFactory = SpaceObjectFactories.FactoryProducer.getFactory(args[1].ToLower());
            return spaceObjectFactory.Create(args);
        }
    }
}
