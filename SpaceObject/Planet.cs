using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObject
{
    class Planet : SpaceObject
    {
        private String type;

        private Boolean isHabitable;

        private String starName;

        private ISet<Moon> moons = new HashSet<Moon>();

        public Planet(String name, String type, Boolean isHabitable, String starName)
        {
            setName(name);
            setType(type);
            setHabitable(isHabitable);
            setStarName(starName);
        }

        public String getType()
        {
            return type;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public Boolean IsHabitable()
        {
            return isHabitable;
        }

        public void setHabitable(Boolean isHabitable)
        {
            this.isHabitable = isHabitable;
        }

        public String getStarName()
        {
            return starName;
        }

        public void setStarName(String starName)
        {
            this.starName = starName;
        }

        public void addMoon(Moon moon)
        {
            moons.Add(moon);
        }

        public StringBuilder appnedPlanet(StringBuilder sb)
        {
            String supportLife = isHabitable ? "yes" : "no";
            sb.Append("      - Name: ").Append(getName()).Append("\n");
            sb.Append("        Type: ").Append(getType()).Append("\n");
            sb.Append("        Support life: ").Append(supportLife).Append("\n");
            return sb;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            appnedPlanet(sb);
            sb.Append("        Moons: ").Append("\n");
            foreach (Moon moon in moons)
            {
                sb.Append(moon.ToString());
            }

            return sb.ToString();
        }
    }
}
