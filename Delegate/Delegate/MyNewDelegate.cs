using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delegate
{
    public class MyNewDelegate
    {
        // Delegate
        public delegate string Simplenewdelegate();

        // Method to delegate
        public string Simplenewmethod()
        {
            return " New message from a delegate method";
        }
    }
}