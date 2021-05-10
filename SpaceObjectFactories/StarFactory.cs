using SpaceApp.SpaceObject;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObjectFactories
{
    class StarFactory : AbstractFactory
    {
        public override SpaceObject.SpaceObject Create(List<String> args)
        {
            return new Star(args[3], // Star name
                    Convert.ToDouble(args[4]), // mass 
                    Convert.ToDouble(args[5]), // size
                    Convert.ToInt32(args[6]), // temp
                    Convert.ToDouble(args[7]), // brightness
                    args[2]);
        }
    }
}
