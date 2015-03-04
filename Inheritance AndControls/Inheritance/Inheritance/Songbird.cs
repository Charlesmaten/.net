using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inheritance
{
    public class Songbird : Bird
    {
        // instance variables
        protected int noofsongs;


        // constructor
        public Songbird(string species, string colour, int noofsongs) : base(species, colour)
        {
            this.noofsongs = noofsongs;
        }

        // noofsongs property
        public int Noofsongs
        {
            get { return noofsongs; }
            set { noofsongs = value; }
        }

        // old ToString (the one from Bird)
        public string OldToString()
        {
            return base.ToString();
        }

        // ToString
        public override string ToString()
        {
            return "The " + species + " is " + colour + "; says " + SayTweet() + " and knows " + Noofsongs + " song" + ((noofsongs == 1) ? "" : "s");
        }
    }
}