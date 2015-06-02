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
            // normal klasse
            MyDelegate md = new MyDelegate();
            // retuner message
            Simpledelegate sd = new Simpledelegate(md.Simplemethod);
            TextBox1.Text = sd();

            // normal klasse
            Mynewdelegate mnd = new Mynewdelegate();

            Mynewdelegate.Simplenewdelegate snd = new Mynewdelegate.Simplenewdelegate(mnd.Simplenewmethod);
            TextBox2.Text = snd();
        }
    }
}


