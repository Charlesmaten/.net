using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int count;

            Application.Lock();   // only one at a time can update
            try
            { 
                count = (int)Application.Get("myhitcount");
            }
            catch
            { 
                count = 0;
            }
            count = count + 1;
            Application.Set("myhitcount", count);
            Application.UnLock();   // remember !

            Label2.Text = count.ToString();
        }
    }
}