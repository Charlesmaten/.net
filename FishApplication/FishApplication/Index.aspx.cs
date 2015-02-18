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
        static ArrayList fisharraylist = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (fisharraylist.Count == 0)
            {
                TextBoxFish.Text = "No fish";
            }
            else
            {
                TextBoxFish.Text = "";
                for (int i = 0; i < fisharraylist.Count; i++)
                {
                    TextBoxFish.Text += fisharraylist[i].ToString() + "\n";
                }
            }

        }

        protected void ButtonCreate_Click(object sender, EventArgs e)
        {
            Fish f = new Fish(TextBoxType.Text, Convert.ToDouble(TextBoxLength.Text));
            fisharraylist.Add(f);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            FileUtility.WriteFile(fisharraylist, Server.MapPath("~/App_Data/Fishfile.ser"));
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            fisharraylist = FileUtility.ReadFile(Server.MapPath("~/App_Data/Fishfile.ser"));
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
    }
}