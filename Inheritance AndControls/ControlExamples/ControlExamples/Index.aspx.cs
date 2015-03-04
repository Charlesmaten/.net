using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ControlExamples
{
    public partial class Index : System.Web.UI.Page
    {
        private string[] airplanes = { "Select an airplane", "DC3", "Catalina", "Piper Cherokee" };
        private string[] cars = { "Select a car", "Ferrari", "Maserati", "Fiat" };

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            { 
                DropDownList1.Items.Add("Select transportation");
                DropDownList1.Items.Add("airplane");
                DropDownList1.Items.Add("car");
                DropDownList1.AutoPostBack = true;
                DropDownList2.AutoPostBack = true;
                DropDownList2.Visible = false;
                TextBox1.Visible = false;
            }
            if (DropDownList2.SelectedIndex > 0)
            {
                TextBox1.Visible = true;
                TextBox1.Text = "You chose " + DropDownList1.SelectedItem + " : " + DropDownList2.SelectedItem;
            }
            else
            {
                TextBox1.Visible = false;
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LabelText.Text = "First index = " + DropDownList1.SelectedIndex;
            if(DropDownList1.SelectedIndex == 0)
            {
                DropDownList2.DataSource = null;
                DropDownList2.DataBind();
                DropDownList2.Visible = false;
                TextBox1.Visible = false;
            }
            if(DropDownList1.SelectedIndex == 1)
            {
                DropDownList2.DataSource = airplanes;
                DropDownList2.DataBind();
                DropDownList2.Visible = true;
                TextBox1.Visible = false;
            }
            if (DropDownList1.SelectedIndex == 2)
            {
                DropDownList2.DataSource = cars;
                DropDownList2.DataBind();
                DropDownList2.Visible = true;
                TextBox1.Visible = false;
            }
        }
    }
}