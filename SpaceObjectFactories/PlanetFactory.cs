using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObjectFactories
{
    class PlanetFactory : AbstractFactory
    {
        public override SpaceObject.SpaceObject Create(List<String> args)
        {
            Boolean isHabitable = "yes".Equals(args[5]) ? true : false;
            return new Planet(args[3], args[4], isHabitable, args[2]);
        }
    }
}
