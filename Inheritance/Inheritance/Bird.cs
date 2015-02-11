using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inheritance
{
    public class Bird
    {
        protected string species;
        protected string colour;

        public Bird(string species, string colour)
        {
            this.species = species;
            this.colour = colour;
        }
        //species property getter/setter
        public string Species
        {
            get { return species; }
            //set { species = value; } not allowed to change
        }
        //colour property getter/setter
        public string Colour
        {
            get { return colour + "-coloured"; }
            set { colour = value; }
        }

        //say tweet - virtual subclasses can override it
        public virtual string SayTweet()
        {
            return "chirp chirp";
        }

        //ToString
        public override string ToString()
        {
            return "The " + species + " is " + Colour + " and says " + SayTweet();
        }

    }
}