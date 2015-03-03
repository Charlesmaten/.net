using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace FishApplication
{
    public partial class CreateFish : System.Web.UI.Page
    {
        ArrayList myFishArrayList;
        int userlevel;


        protected void Page_Load(object sender, EventArgs e)
        {
            // Works in chrom, but presently not in IE, FireFox
            //Response.Cache.SetCacheability(HttpCacheability.NoCache);

            //Works presently in Chrome, IE, FireFox
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
                Response.Redirect("FishError.aspx");
            }
        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            Fish f = new Fish(TextBoxType.Text, Convert.ToDouble(TextBoxLength.Text));
            myFishArrayList =  (ArrayList)Application["Fishcollection"];
            myFishArrayList.Add(f);
            //Should not be necessary to save fishArrayList to application agian

            Response.Redirect("Index.aspx");

        }
    }
}