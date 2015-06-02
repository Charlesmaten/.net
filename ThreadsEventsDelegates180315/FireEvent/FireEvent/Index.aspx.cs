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
            Label1.Text = Server.HtmlEncode(Request.QueryString["message"]);
        }

        // ExtinguishFire must match the delegate FireEventHandler
        public void ExtinguishFire(object sender, FireEventArgs fea)
        {
            messagestring = "My message";
            Response.Redirect("Index.aspx?message=" + messagestring);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            myFireAlarm.ActivateFireAlarm(DropDownList1.SelectedItem.ToString(), Convert.ToInt32(DropDownList2.SelectedItem.ToString()));
        }
    }
}