using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FireEvent
{
    public partial class Index : System.Web.UI.Page
    {
        private FireAlarm myFireAlarm;
        private string[] room = { "location", "office", "reception", "store room" };
        private string[] ferocity = { "ferocity", "1", "2", "3" };
        private string messagestring = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                DropDownList1.DataSource = room;
                DropDownList1.DataBind();
                DropDownList2.DataSource = ferocity;
                DropDownList2.DataBind();
            }
            myFireAlarm = new FireAlarm();
            myFireAlarm.fireEvent += new FireAlarm.FireEventHandler(ExtinguishFire);
            if(Request.QueryString["message"] != null)
            { 
                Label1.Text = Server.HtmlEncode(Request.QueryString["message"]);
            }
            else
            {
                Label1.Text = "No alarm";
            }
        }

        // ExtinguishFire must match the delegate FireEventHandler
        public void ExtinguishFire(object sender, FireEventArgs fea)
        {
            if(fea.ferocity == 1)
            {
                messagestring = "Use water on the fire in the " + fea.room + " of ferocity " + fea.ferocity.ToString();
            }
            else
            {
                if(fea.ferocity == 2)
                {
                    messagestring = "Use the fire extinguisher on the fire in the " + fea.room + " of ferocity " + fea.ferocity.ToString();
                }
                else
                {
                    messagestring = "The fire brigade will handle the fire in the " + fea.room + " of ferocity " + fea.ferocity.ToString();
                }
            }
            Response.Redirect("Index.aspx?message=" + messagestring);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedIndex == 0 || DropDownList2.SelectedIndex == 0)
            {
                Label1.Text = "Select both location and ferocity";
            }
            else
            {
                myFireAlarm.ActivateFireAlarm(DropDownList1.SelectedItem.ToString(), Convert.ToInt32(DropDownList2.SelectedItem.ToString()));
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Label1.Text = "No alarm";
            DropDownList1.SelectedIndex = 0;
            DropDownList2.SelectedIndex = 0;
        }
    }
}