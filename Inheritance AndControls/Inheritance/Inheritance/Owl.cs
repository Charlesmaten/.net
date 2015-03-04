using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inheritance
{
    public class Owl : Bird
    {
        // instance variables
        protected int noofmicecaught;

        // constructor
        public Owl(string species, string colour, int noofmicecaught) : base(species, colour)
        {
            this.noofmicecaught = noofmicecaught;
        }

        // overloaded constructor
        public Owl(string species, string colour) : base(species, colour)
        {
            noofmicecaught = 0;
        }

        // noofmicecaught property
        public int Noofmicecaught
        {
            get { return noofmicecaught; }
            set { noofmicecaught = value; }
        }

        // say tweet
        public override string SayTweet()
        {
            return "tu-whoo";
        }

        // ToString
        public override string ToString()
        {
            return "The " + species + " is " + colour + "; says " + SayTweet() + " and has caught " + Noofmicecaught + ((noofmicecaught == 1) ? " mouse" : " mice");
        }
    }
}