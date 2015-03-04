using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inheritance
{
    public class Bird
    {
        // instance variables
        protected string species;
        protected string colour;

        // constructor
        public Bird(string species, string colour)
        {
            this.species = species;
            this.colour = colour;
        }

        // species property
        public string Species
        {
            get { return species; }
            //set { species = value; }    not allowed to change
        }

        // colour property
        public string Colour
        {
            get { return colour + "-coloured"; }
            set { colour = value; }
        }

        // say tweet
        public virtual string SayTweet()
        {
            return "chirp chirp";
        }

        // ToString
        public override string ToString()
        {
            return "The " + Species + " is " + Colour + " and says " + SayTweet();
        }
    }
}