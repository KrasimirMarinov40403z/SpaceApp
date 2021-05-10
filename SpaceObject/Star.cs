using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObject
{
    class Star : SpaceObject
    {
        protected enum StarType
        {
            O, B, A, F, G, K, M
        }

        private StarType type;

        private double mass;

        private double size;

        private int temperature;

        private double brightness;

        private ISet<Planet> planets = new HashSet<Planet>();

        private String galaxyName;

        public Star(String name, Double mass, Double size, Int32 temperature, Double brightness, String galaxyName)
        {
            setName(name);
            this.mass = mass;
            this.size = size;
            this.temperature = temperature;
            this.brightness = brightness;
            setGalaxyName(galaxyName);
            setType();
        }

        private void setType()
        {
            if (belongsToO()) this.type = StarType.O;
            else if (belongsToB()) this.type = StarType.B;
            else if (belongsToA()) this.type = StarType.A;
            else if (belongsToF()) this.type = StarType.F;
            else if (belongsToG()) this.type = StarType.G;
            else if (belongsToK()) this.type = StarType.K;
            else if (belongsToM()) this.type = StarType.M;
        }

        public double getMass()
        {
            return mass;
        }

        public void setMass(double mass)
        {
            this.mass = mass;
        }

        public double getSize()
        {
            return size;
        }

        public void setSize(double size)
        {
            this.size = size;
        }

        public int getTemperature()
        {
            return temperature;
        }

        public void setTemperature(int temperature)
        {
            this.temperature = temperature;
        }

        public double getBrightness()
        {
            return brightness;
        }

        public void setBrightness(double brightness)
        {
            this.brightness = brightness;
        }

        public void addPlanet(Planet planet)
        {
            planets.Add(planet);
        }

        public String getGalaxyName()
        {
            return galaxyName;
        }

        public void setGalaxyName(String galaxyName)
        {
            this.galaxyName = galaxyName;
        }

        private Boolean belongsToO()
        {
            return this.temperature >= 30000 &&
                   this.brightness >= 30000 &&
                   this.mass >= 0.8 && this.mass <= 1.04 &&
                   this.size >= 0.96 && this.size <= 1.15;
        }

        private Boolean belongsToB()
        {
            return this.temperature >= 10000 && this.temperature <= 30000 &&
                   this.brightness >= 25 && this.brightness <= 30000 &&
                   this.mass >= 2.1 && this.mass <= 16 &&
                   this.size >= 1.8 && this.size <= 6.6;
        }

        private Boolean belongsToA()
        {
            return this.temperature >= 7500 && this.temperature <= 10000 &&
                   this.brightness >= 5 && this.brightness <= 25 &&
                   this.mass >= 1.4 && this.mass <= 2.1 &&
                   this.size >= 1.4 && this.size <= 1.8;
        }

        private Boolean belongsToF()
        {
            return this.temperature >= 6000 && this.temperature <= 7500 &&
                   this.brightness >= 1.5 && this.brightness <= 5 &&
                   this.mass >= 1.04 && this.mass <= 1.4 &&
                   this.size >= 1.15 && this.size <= 1.4;
        }

        private Boolean belongsToG()
        {
            return this.temperature >= 5200 && this.temperature <= 6000 &&
                   this.brightness >= 0.6 && this.brightness <= 1.5 &&
                   this.mass >= 0.8 && this.mass <= 1.04 &&
                   this.size >= 0.96 && this.size <= 1.15;
        }

        private Boolean belongsToK()
        {
            return this.temperature >= 3700 && this.temperature <= 5200 &&
                   this.brightness >= 0.08 && this.brightness <= 0.6 &&
                   this.mass >= 0.45 && this.mass <= 0.8 &&
                   this.size >= 0.7 && this.size <= 0.96;
        }

        private Boolean belongsToM()
        {
            return this.temperature >= 2400 && this.temperature <= 3700 &&
                   this.brightness <= 0.08 &&
                   this.mass >= 0.08 && this.mass <= 0.45 &&
                   this.size <= 0.7;
        }

        public StringBuilder appnedStar(StringBuilder sb)
        {
            sb.Append("   Name: ").Append(getName()).Append("\n");
            sb.Append("   Class: ").Append(this.type).Append(" (")
              .Append(this.mass).Append(", ")
              .Append(this.size).Append(", ")
              .Append(this.temperature).Append(", ")
              .Append(this.brightness)
            .Append(")").Append("\n");
            return sb;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            appnedStar(sb);
            sb.Append("   Planets: ").Append("\n");
            foreach (Planet planet in planets)
            {
                sb.Append(planet.ToString());
            }

            return sb.ToString();
        }
    }
}
