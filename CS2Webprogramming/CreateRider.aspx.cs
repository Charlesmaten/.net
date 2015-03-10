using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace CS2Webprogramming
{
    public partial class CreateRider : System.Web.UI.Page
    {
        ArrayList myriderarraylist;
        int userlevel;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Cache.SetNoStore();

            try
            {
                userlevel = (int)Session["Level"];
            }
            catch(NullReferenceException)
            {
                userlevel = 0;
                Session["Level"] = 0;
            }
            finally
            {
                SetButtonsAndText();
            }


        }
        private void SetButtonsAndText()
        {
            if (userlevel == 1)
            {
                LabelMessage.Text = "You are at level " + Session["Level"];
            }
            else
            {
                Response.Redirect("RiderError.aspx");
            }
        }

        protected void ButtonCreateRider_Click(object sender, EventArgs e)
        {
            //myriderarraylist = new ArrayList();
            Rider r = new Rider(Convert.ToInt32(TextBoxId.Text), TextBoxName.Text, Convert.ToInt32(TextBoxPhone.Text), TextBoxPassword.Text, TextBoxAddress.Text, Convert.ToInt32(TextBoxStartingnumber.Text), TextBoxHorse.Text, TextBoxCountry.Text);
            myriderarraylist = (ArrayList)Application["Ridercollection"];
            myriderarraylist.Add(r);

            Response.Redirect("Index.aspx");
        }
    }
}