using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Simpleobjectservice
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost.Rabbitservice myrabbitservice = new localhost.Rabbitservice();
            Object[] rabbitlist;
            localhost.Rabbit r;
            Clientrabbit cr;

            rabbitlist = myrabbitservice.Getrabbits();
            for(int i = 0; i < rabbitlist.Length; i++)
            {
                r =  (localhost.Rabbit)rabbitlist[i];
                ListBox1.Items.Add(r.Id + " " + r.Name);

                cr = new Clientrabbit(r);
                ListBox1.Items.Add(cr.ToString());

                ListBox1.Items.Add("");
            }
        }
    }
}