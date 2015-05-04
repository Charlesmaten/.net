using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Nameservice
{
    /// <summary>
    /// Summary description for Nameservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Nameservice : System.Web.Services.WebService
    {
        [WebMethod]
        public Myclasslibrary.Myuser Getnewuser(Myclasslibrary.Myuser u)
        {
            u.Username = "New " + u.Username;
            u.Userpassword = "New " + u.Userpassword;
            return u;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
