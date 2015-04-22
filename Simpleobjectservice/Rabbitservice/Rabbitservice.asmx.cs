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
        [XmlInclude(typeof (Rabbit))]
        public ArrayList GetRabbites()
        {
            ArrayList rabbitList = new ArrayList();
            Rabbit r1, r2, r3;
            r1 = new Rabbit {Id = 1, Name = "R2D2"};
            rabbitList.Add(r1);
            r2 = new Rabbit {Id = 2, Name = "C3PO"};
            rabbitList.Add(r2);
            r3 = new Rabbit {Id = 3, Name = "Lord Vader"};
            rabbitList.Add(r3);
            return rabbitList;
        }



        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
