using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Inheritance
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Bird b1 = new Bird("sparrow", "gray");
            Owl b2 = new Owl("snowy owl", "white");
            Owl b3 = new Owl("horned owl", "brown", 1);
            SongBird b4 = new SongBird("nightingale", "brown", 1);
            SongBird b5 = new SongBird("gale", "pink", 3);



            ListBoxResults.Items.Add(b1.ToString());
            ListBoxResults.Items.Add(b2.ToString());
            ListBoxResults.Items.Add(b3.ToString());
            ListBoxResults.Items.Add(b4.ToString());
            ListBoxResults.Items.Add("");

            b2.Noofmicecaught = 20;
            ListBoxResults.Items.Add(b2.ToString());
            ListBoxResults.Items.Add("");

            b4.Noofsongs = 2;
            ListBoxResults.Items.Add(b4.ToString());
            ListBoxResults.Items.Add(b4.OldToString());
            ListBoxResults.Items.Add("the " + b4.Species + " is " + b4.Colour);

        }
    }
}