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
        int userlevel;

        protected void Page_Load(object sender, EventArgs e)
        {
          // Rider r1 = new Rider(1, "Hans ole", 45458888, "Abcd1234", "Vej1234", 13, "Spitfire", "England");
           //Rider r2 = new Rider(1, "Jens Lyn", 4545, "Dcb1234", "rævevej12", 17, "FireOnEarth", "Holland");
           //Rider r3 = new Rider(1, "Peter Hjul", 488, "ja1234", "hejvej1234", 1, "Lighting", "Danmark");

            

           //ListBoxResults.Items.Add(r1.ToString());
           //ListBoxResults.Items.Add(r2.ToString());
           //ListBoxResults.Items.Add(r3.ToString());

           //riderarraylist.Add(r1);
           //riderarraylist.Add(r2);
           //riderarraylist.Add(r3);

            try
            {
                userlevel = (int)Session["Level"];
            }
            catch(NullReferenceException nre)
            {
                userlevel = 0;
                Session["Level"] = userlevel;
            }
            finally
            {
                SetButtonsAndText();
                TextBoxPassword.TextMode = TextBoxMode.Password;
            }

           if (Application["Ridercollection"] == null)
           {
               riderarraylist = new ArrayList();
               Application["Ridercollection"] = riderarraylist;
           }
           riderarraylist = (ArrayList)Application["Ridercollection"];
           if (riderarraylist.Count == 0)
           {
               TextBoxRiders.Text = "no riders";
           }
           else
           {
               TextBoxRiders.Text = "";
               for (int i = 0; i < riderarraylist.Count; i++)
               {
                   TextBoxRiders.Text += riderarraylist[i].ToString() + "\n";
               }
           }
       }

        private void SetButtonsAndText()
        {
            if (userlevel == 1)
            {
                ButtonCreateRider.Enabled = true;
                LabelLogin.Text = "You are at level " + Session["Level"];
            }
            else if (userlevel == 2)
            {
                ButtonEditRider.Enabled = true;
                LabelLogin.Text = "You are at level " + Session["Level"];
            }
            else if (userlevel == 3)
            {
                ButtonEditStaff.Enabled = true;
                LabelLogin.Text = "You are at level " + Session["Level"];
            }
            else
            {
                ButtonEditStaff.Enabled = false;
                ButtonCreateRider.Enabled = false;
                ButtonEditRider.Enabled = false;
                LabelLogin.Text = "You are at level " + Session["Level"];
            }
        }


        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            riderarraylist = (ArrayList)Application["Ridercollection"];
            FileUtility.WriteFile(riderarraylist, Server.MapPath("~/App_Data/Riderfile.ser"));
            TextBoxRiders.Text = "Riderfile was written in App_Data";
        }

        protected void ButtonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                riderarraylist = FileUtility.ReadFile(Server.MapPath("~/App_Data/Riderfile.ser"));
                //Application["Ridercollection"] = riderarraylist;
                if (riderarraylist.Count == 0)
                {
                    TextBoxRiders.Text = "No riders loaded";
                }
                else
                {
                    TextBoxRiders.Text = "Riders loaded:\n";
                    for (int i = 0; i < riderarraylist.Count; i++)
                    {
                        TextBoxRiders.Text += riderarraylist[i].ToString() + "\n";
                    }
                }
            }
            catch (Exception)
            {

            }
        }

        protected void ButtonCreateRider_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateRider.aspx");
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (TextBoxPassword.Text == "secret")
            {
                userlevel = 1;
            }
            else if (TextBoxPassword.Text == "rider")
            {
                userlevel = 2;
            }
            else if (TextBoxPassword.Text == "staff") 
            {
                userlevel = 3;
            }        
            else
            {
                userlevel = 0;
            }
            Session["Level"] = userlevel;
            SetButtonsAndText();
        }

        protected void ButtonLogout_Click(object sender, EventArgs e)
        {
            userlevel = 0;
            Session["Level"] = userlevel;
            SetButtonsAndText();
        }

        protected void ButtonEditRider_Click(object sender, EventArgs e)
        {
            Response.Redirect("EditRider.aspx");
        }



    }
}