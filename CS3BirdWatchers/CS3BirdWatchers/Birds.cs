using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS3BirdWatchers
{
    public class Birds
    {

        //An observation must have a description and rarity.
        public string description;
        public int rarity;
        public int location;

        public Birds(string description, int rarity, int location)
        {
            this.description = description;
            this.rarity = rarity;
            this.location = location;
        }
    }
}
