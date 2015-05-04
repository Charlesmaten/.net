using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Myclasslibrary;

namespace Classlibraryservice
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Myuser mu = new Myuser("Jack", "1234");
            ListBox1.Items.Add(mu.Username + " has the password " + mu.Userpassword);

            mu = new localhost.Nameservice().Getnewuser(mu);
            ListBox1.Items.Add(mu.Username + " has the password " + mu.Userpassword);
        }
    }
}