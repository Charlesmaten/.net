using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEventForm
{
    // must be public : In Windows Form Application classes are created without public
    // = internal = only accessible from other classes in same assembly
    public class FireEventArgs : EventArgs
    {
        // inherits EventArgs to be able to use future extensions to EventArgs
        
        // event information
        public int location;
        public string room;
        public int ferocity;

        // constructor
        public FireEventArgs(int location, string room, int ferocity)
        {
            this.location = location;
            this.room = room;
            this.ferocity = ferocity;
        }
    }
}
