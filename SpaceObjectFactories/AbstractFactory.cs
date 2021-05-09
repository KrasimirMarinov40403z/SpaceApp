using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObjectFactories
{
    abstract class AbstractFactory
    {
        public abstract SpaceObject.SpaceObject Create(String[] args);
    }

}
