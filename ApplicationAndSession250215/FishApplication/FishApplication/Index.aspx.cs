using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Collections;

namespace FishApplication
{
    public partial class Index : System.Web.UI.Page
    {
        ArrayList fisharraylist;
        int userlevel;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                userlevel = (int)Session["Level"];
            }
            catch (NullReferenceException nre)
            {
                userlevel = 0;
                Session["Level"] = userlevel;
            }
            finally
            {
                SetButtonsAndText();
                TextBoxPassword.TextMode = TextBoxMode.Password;
            }

            if(Application["Fishcollection"] == null)
            {
                fisharraylist = new ArrayList();
                Application["Fishcollection"] = fisharraylist;
            }
            fisharraylist = (ArrayList)Application["Fishcollection"];
            if(fisharraylist.Count == 0)
            {
                TextBoxFish.Text = "No fish";
            }
            else
            {
                TextBoxFish.Text = "";
                for(int i = 0; i < fisharraylist.Count; i++)
                {
                    TextBoxFish.Text += fisharraylist[i].ToString() + "\n";
                }
            }
        }

        private void SetButtonsAndText()
        {
            if(userlevel == 1)
            {
                ButtonCreatePage.Enabled = true;
                LabelLogin.Text = "You are at level " + Session["Level"];
            }
            else
            {
                ButtonCreatePage.Enabled = false;
                LabelLogin.Text = "You are at level " + Session["Level"];
            }
        }

        protected void ButtonSave_Click(object sender, EventArgs e)
        {
            fisharraylist = (ArrayList)Application["Fishcollection"];
            FileUtility.WriteFile(fisharraylist, Server.MapPath("~/App_Data/Fishfile.ser"));
            TextBoxFish.Text = "Fishfile.ser was written in App_Data";
        }

        protected void ButtonRead_Click(object sender, EventArgs e)
        {
            try 
            {
                fisharraylist = FileUtility.ReadFile(Server.MapPath("~/App_Data/Fishfile.ser"));
                Application["Fishcollection"] = fisharraylist;
                if (fisharraylist.Count == 0)
                {
                    TextBoxFish.Text = "No fish";
                }
                else
                {
                    TextBoxFish.Text = "Fish from file\n";
                    for (int i = 0; i < fisharraylist.Count; i++)
                    {
                        TextBoxFish.Text += fisharraylist[i].ToString() + "\n";
                    }
                }
            }
            catch (Exception ex)
            {
                TextBoxFish.Text = "Fishfile.ser could not be read";
            }
        }

        protected void ButtonCreatePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateFish.aspx");
        }

        protected void ButtonLogin_Click(object sender, EventArgs e)
        {
            if(TextBoxPassword.Text == "secret")
            {
                userlevel = 1;
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
    }
}