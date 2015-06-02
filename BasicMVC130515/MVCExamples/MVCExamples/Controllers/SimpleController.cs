using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCExamples.Models;

namespace MVCExamples.Controllers
{
    public class SimpleController : Controller
    {
        // e.g. localhost:49656/Simple/Hello
        public void Hello()
        {
            Response.Write("<h1>Hello World !</h1>");
        }

        // e.g. localhost:49656/Simple/Hi/Torben    --- because name of the string is default = id ---
        public void Hi(string id)
        {
            Response.Write("Hi " + HttpUtility.HtmlEncode(id));
        }

        // e.g. localhost:49656/Simple/Distance?x2=3&y2=4&x1=0&y1=0
        public void Distance(int x1, int y1, int x2, int y2)
        {
            double xsquare = (x2 - x1) * (x2 - x1);
            double ysquare = (y2 - y1) * (y2 - y1);
            Response.Write(Math.Sqrt(xsquare + ysquare));
        }

        // e.g. localhost:49656/Simple/Luckynumber?name=Hugo&luck=7   --- 1 is default is luck is not given
        public string Luckynumber(string name, int luck = 1)
        {
            return HttpUtility.HtmlEncode("Hi " + name + ". Your lucky number is " + luck);
        }

        // e.g. localhost:49656/Simple/MyOwnView
        public ActionResult MyOwnView()
        {
            ViewBag.Message = "My own products";

            var products = new List<Product>();
            for (int i = 0; i < 10; i++)
            {
                products.Add(new Product { Productname = "Product number " + i });
            }

            return View(products);
        }
	}
}