using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;

namespace SnakeApplication
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(Page.IsValid)
            {
                SqlConnection conn = new SqlConnection(@"data source = .\SQLEXPRESS; integrated security = true; database = SnakeDB");
                SqlCommand cmd = null;
                string sqlins = "insert into Owner values(@Name)";  // and id if not aotumatic

                try
                {
                    conn.Open();

                    cmd = new SqlCommand(sqlins, conn);
                    cmd.Parameters.Add("@Name", SqlDbType.Text);
                    // and id as int if not automatic

                    cmd.Parameters["@Name"].Value = TextBox1.Text;
                    // and id as Covert.Toint32 of Textbox2

                    cmd.ExecuteNonQuery();

                    Label2.Text = "The owner " + TextBox1.Text + " has been added";
                    TextBox1.Text = "";
                }
                catch (Exception ex)
                {
                    Label3.Text = ex.Message;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}