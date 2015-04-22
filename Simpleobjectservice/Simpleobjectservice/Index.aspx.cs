using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Simpleobjectservice.localhost1;

namespace Simpleobjectservice
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Rabbitservice myrabbitserver = new Rabbitservice();
            Object[] rabbitlist;
            localhost1.Rabbit r;
            Clientrabbit cr;

            rabbitlist = myrabbitserver.GetRabbites();
            //for (int i = 0; i < rabbitlist.Length; i++)
            foreach (object t in rabbitlist)
            {
                r = (localhost1.Rabbit) t;
                ListBox1.Items.Add(r.Id + " " +r.Name);

                ListBox1.Items.Add("");

                cr = new Clientrabbit(r);
                ListBox1.Items.Add(cr.ToString());
            }
        }
    }
}