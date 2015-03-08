using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace CS2Webprogramming
{
    public partial class Index : System.Web.UI.Page
    {
        ArrayList riderarraylist;

        protected void Page_Load(object sender, EventArgs e)
        {
           Rider r1 = new Rider(1, "Hans ole", 45458888, "Abcd1234", 13, "Spitfire", "England");
           Rider r2 = new Rider(1, "Jens Lyn", 4545, "Dcb1234", 17, "FireOnEarth", "Holland");
           Rider r3 = new Rider(1, "Peter Hjul", 488, "ja1234", 1, "Lighting", "Danmark");

           //ListBoxResults.Items.Add(r1.ToString());
           //ListBoxResults.Items.Add(r2.ToString());
           //ListBoxResults.Items.Add(r3.ToString());

           riderarraylist.Add(r1);
           riderarraylist.Add(r2);
           riderarraylist.Add(r3);


        }
 

        protected void ButtonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                riderarraylist = FileUtility.ReadFile(Server.MapPath("~/App_Data/Riderfile.ser"));
                if (riderarraylist.Count == 0)
                {
                    ListBoxResults.Text = "No riders loaded";
                }
                else
                {
                    ListBoxResults.Text = "Riders loaded:\n";
                    for (int i = 0; i < riderarraylist.Count; i++)
                    {
                        ListBoxResults.Text += riderarraylist[i].ToString() + "\n";
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            riderarraylist = (ArrayList)Application["CS2Webprogramming"];
            FileUtility.WriteFile(riderarraylist, Server.MapPath("~/App_data/Riderfile.ser"));
            ListBoxResults.Text = "Riderfile was written in App_Data";
        }


    }
}