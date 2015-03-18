using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Delegate
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MyDelegate md = new MyDelegate();
            Simpledelegate sd = new Simpledelegate(md.simplemethod);
            TextBox1.Text = sd();

            MyNewDelegate mnd = new MyNewDelegate();
            MyNewDelegate.Simplenewdelegate snd = new MyNewDelegate.Simplenewdelegate(md.simplemethod);
            TextBox2.Text = snd();
        }
    }
}