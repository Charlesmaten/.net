using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Snakeclient
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox1.Focus();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            localhost.Answer a = new localhost.Answer();
            localhost.Snake s = new localhost.Snake();
            localhost.Owner o = new localhost.Owner();
            localhost.Snakeservice myservice = new localhost.Snakeservice();
            Clientsnake cs;
            Clientowner co;

            a = myservice.Findsnake(Convert.ToInt32(TextBox1.Text));
            // usual xml and database problem : If two snakes have same owner two owner objects are created for this same owner

            co = new Clientowner(a.O);
            cs = new Clientsnake(a.S, co);

            TextBox2.Text = "Snake : " + a.S.Name + ". Owner : " + a.O.Name;
            TextBox3.Text = cs.ToString();
            TextBox1.Text = "";
        }
    }
}