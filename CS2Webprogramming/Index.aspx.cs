using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CS2Webprogramming
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Rider r1 = new Rider(1, "Hans ole", 45458888, "Abcd1234", 13, "Spitfire", "England");
           Rider r2 = new Rider(1, "Jens Lyn", 4545, "Dcb1234", 17, "FireOnEarth", "Holland");
           Rider r3 = new Rider(1, "Peter Hjul", 488, "ja1234", 1, "Lighting", "Danmark");

           ListBoxResults.Items.Add(r1.ToString());
           ListBoxResults.Items.Add(r2.ToString());
           ListBoxResults.Items.Add(r3.ToString());

        }
    }
}