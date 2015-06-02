using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delegate
{
    // delegate
    public delegate string Simpledelegate();

    public class MyDelegate
    {
        // method to delegate
        public string Simplemethod()
        {
            return "Message from a delegate method";
        }
    }
}