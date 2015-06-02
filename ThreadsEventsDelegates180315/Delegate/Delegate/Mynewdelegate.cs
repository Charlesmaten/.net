using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delegate
{
    public class Mynewdelegate
    {
        // delegate
        public delegate string Simplenewdelegate();

        // method to delegate
        public string Simplenewmethod()
        {
            return "new message from a delegate method";
        }
    }
}