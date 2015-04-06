using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FireEvent
{
    public class FireEventArgs : EventArgs
    {
        // inherits EventArgs to be able to use future extensions to EventArgs
 
        // event information
        public string room;
        public int ferocity;

        // constructor
        public FireEventArgs(string room, int ferocity)
        {
            this.room = room;
            this.ferocity = ferocity;
        }
    }
}