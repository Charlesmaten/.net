using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Inheritance
{
    public class SongBird : Bird
    {
        //instance variables
        protected int noofsongs;

        //constructor
        public SongBird(string species, string colour, int noofsongs)
            : base(species, colour)
        {
            this.noofsongs = noofsongs;
        }
        //noofsongs property
        public int Noofsongs
        {
            get { return noofsongs; }
            set { noofsongs = value; }
        }

        //old ToString (the one from bird)
        public string OldToString()
        {
            return base.ToString();
        }

        //tostring
        public override string ToString()
        {
            return "The " + species + " is " + colour + "; says " + SayTweet() + " and knows " + noofsongs + " song" + ((noofsongs == 1) ? "" : " songs");
        }

    }
}