using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObjectFactories
{
    class GalaxyFactory : AbstractFactory
    {
        public override SpaceObject.SpaceObject Create(List<String> args)
        {
            return new Galaxy(args[2], args[3], args[4]);
        }
    }
}
