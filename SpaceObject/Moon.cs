using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObject
{
    class Moon : SpaceObject
    {

        private String planetName;

        public Moon(String name, String planetName)
        {
            setName(name);
            setPlanetName(planetName);
        }

        public String getPlanetName()
        {
            return planetName;
        }

        public void setPlanetName(String planetName)
        {
            this.planetName = planetName;
        }

        public StringBuilder appnedMoon(StringBuilder sb)
        {
            sb.Append("           - ").Append(getName()).Append("\n");
            return sb;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            appnedMoon(sb);
            return sb.ToString();
        }
    }
}
