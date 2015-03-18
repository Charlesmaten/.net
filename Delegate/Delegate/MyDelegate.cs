using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Delegate
{

    private delegate string Simpledelegate();

    public class MyDelegate
    {

        public string simplemethod()
        {
            return "Message from delegate method";
        }

    }
}