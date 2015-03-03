using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exercise4_3
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //hvis det er første gange?? undersøges
            if (!Page.IsPostBack)
            {
                ListItem header = new ListItem("Select a name", "1000");
                ListItem a = new ListItem("Abby", "135");
                ListItem b = new ListItem("Bob", "175");
                ListItem c = new ListItem("Charlie", "55");
                ListItem d = new ListItem("Dawn", "45");
                DropDownList1.Items.Add(header);
                DropDownList1.Items.Add(a);
                DropDownList1.Items.Add(b);
                DropDownList1.Items.Add(c);
                DropDownList1.Items.Add(d);

                DropDownList2.Items.Add(header);
                DropDownList2.Items.Add(a);
                DropDownList2.Items.Add(b);
                DropDownList2.Items.Add(c);
                DropDownList2.Items.Add(d);


            }
        }

        protected void ButtonEvaluate_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DropDownList1.SelectedValue) < 0 || Convert.ToInt32(DropDownList2.SelectedValue) < 0)
            {
                LabelEvaluate.Text = "One or two names are missing";
            }
            else
            {
                if(DropDownList1.SelectedItem.Text != DropDownList2.SelectedItem.Text)
                {

                    int sum = Convert.ToInt32(DropDownList1.SelectedValue) + Convert.ToInt32(DropDownList2.SelectedValue);
                    if(sum > 100 && sum <= 300)
                    {
                        LabelEvaluate.Text = "OK";
                    }
                    else
                    {
                        LabelEvaluate.Text = "Not OK";
                    }
                }
                else
                {
                    LabelEvaluate.Text = "Select two different names";
                }
            }
        }
    }
}