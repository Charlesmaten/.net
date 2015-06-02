using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FishApplication
{
    [Serializable]
    public class Fish
    {
        private string type;
        private double length;

        public Fish(string type, double length)
        {
            this.type = type;
            this.length = length;
        }

        public override string ToString()
        {
            return "The " + type + " is " + length + " cm long";
        }
    }
}