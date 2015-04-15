using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireEventForm
{

    //must be public : In windows Form Application classes are created without public
    //=Internal = only accesible from other classes in same assembly
    public class FireEventArgs : EventArgs
    {
        //Inherits EventArgs to be able to use future extentions to Eventargs

        //event information
        public int location;
        public string room;
        public int ferocity;

        //Constructor
        public FireEventArgs(int location, string room, int ferocity)
        {
            this.location = location;
            this.room = room;
            this.ferocity = ferocity;
        }

    }
}
