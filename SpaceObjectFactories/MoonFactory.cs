using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObjectFactories
{
    class MoonFactory : AbstractFactory
    {
        public override SpaceObject.SpaceObject Create(string[] args)
        {
            return new Moon(args[3], args[2]);
        }
    }
}
