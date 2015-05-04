using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Xml.Serialization;
using System.Collections;

namespace Rabbitservice
{
    /// <summary>
    /// Summary description for Rabbitservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Rabbitservice : System.Web.Services.WebService
    {
        [WebMethod]
        [XmlInclude(typeof(Rabbit))]
        public ArrayList Getrabbits()
        {
            ArrayList rabbitlist = new ArrayList();
            Rabbit r1, r2, r3;
            r1 = new Rabbit();
            r1.Id = 1;
            r1.Name = "R2D2";
            rabbitlist.Add(r1);
            r2 = new Rabbit();
            r2.Id = 2;
            r2.Name = "C3PO";
            rabbitlist.Add(r2);
            r3 = new Rabbit();
            r3.Id = 3;
            r3.Name = "Lord Vader";
            rabbitlist.Add(r3);
            return rabbitlist;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
