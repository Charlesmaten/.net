using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise4_3
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //hvis det er første gange
            if (!Page.IsPostBack)
            {
                ListItem a = new ListItem("Abby", "135");
                ListItem b = new ListItem("Bob", "175");
                ListItem c = new ListItem("Charlie", "55");
                ListItem d = new ListItem("Dawn", "45");

            }
        }
    }
}