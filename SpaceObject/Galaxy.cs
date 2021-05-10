using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceApp.SpaceObject
{
    class Galaxy : SpaceObject
    {
        //enum GalaxyType
        //{
        //    ELLIPTICAL,
        //    LENTICULAR,
        //    SPIRAL,
        //    IRREGULAR
        //}

        private String age;

        private String type;

        private ISet<Star> stars = new HashSet<Star>();

        public Galaxy()
        {
            this.age = "";
        }

        public Galaxy(String name, String type, String age)
        {
            setName(name);
            setType(type);
            setAge(age);
        }

        public String GetType()
        {
            return type;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public String getAge()
        {
            return age;
        }

        public void setAge(String age)
        {
            this.age = age;
        }

        public void addStars(Star star)
        {
            stars.Add(star);
        }

        public StringBuilder appnedGalaxy(StringBuilder sb)
        {
            sb.Append("Type: ").Append(GetType().ToString().ToLower()).Append("\n");
            sb.Append("Age: ").Append(getAge().ToString()).Append("\n");
            return sb;
        }

        public override String ToString()
        {
            StringBuilder sb = new StringBuilder();
            appnedGalaxy(sb);
            sb.Append("Stars: ").Append("\n");
            foreach (Star star in stars)
            {
                sb.Append(star.ToString());
            }

            return sb.ToString();
        }
    }
}
