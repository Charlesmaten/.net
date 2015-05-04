using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Basicservices
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            localhost1.Mathservice myservice1 = new localhost1.Mathservice();
            localhost2.Evenoddservice myservice2 = new localhost2.Evenoddservice();

            ListBox1.Items.Add("2 + 2 = " + myservice1.Add(2, 2));
            ListBox1.Items.Add("6 - 8 = " + myservice1.Sub(6, 8));
            ListBox1.Items.Add("3 * 5 = " + myservice1.Mul(3, 5));
            ListBox1.Items.Add("8 / 3 = " + myservice1.Div(8, 3));
            ListBox1.Items.Add("4 / 0 = " + myservice1.Div(4, 0));
            ListBox1.Items.Add("");
            ListBox1.Items.Add("7 is " + myservice2.Evenodd(7));
            ListBox1.Items.Add("10 is " + myservice2.Evenodd(10));
        }
    }
}