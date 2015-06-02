using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FireEvent
{
    public class FireAlarm
    {
        // instance variables

        // the delegate that subscribers must use
        public delegate void FireEventHandler(object sender, FireEventArgs fireinfo);

        // event instance of the delegate
        public event FireEventHandler fireEvent;

        // constructor

        // raise event
        public void ActivateFireAlarm(string room, int ferocity)
        {
            FireEventArgs fea = new FireEventArgs(room, ferocity);
            fireEvent(this, fea);
        }
    }
}