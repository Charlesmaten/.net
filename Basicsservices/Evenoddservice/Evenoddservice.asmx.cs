﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Evenoddservice
{
    /// <summary>
    /// Summary description for Evenoddservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Evenoddservice : System.Web.Services.WebService
    {


        [WebMethod]
        public int Evenodd()
        {
            
        }



        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
