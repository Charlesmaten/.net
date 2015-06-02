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
    public partial class ReadUpdate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                ButtonUpdate.Enabled = false;
            }

            UpdateGridview();
        }

        public void UpdateGridview()
        {
            SqlConnection conn = new SqlConnection(@"data source = .\SQLEXPRESS; integrated security = true; database = SnakeDB");
            SqlCommand cmd = null;
            SqlDataReader rdr = null;
            string sqlsel = "select * from Owner";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlsel, conn);
                rdr = cmd.ExecuteReader();

                GridView1.DataSource = rdr;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBox1.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[2].Text;
            Label1.Text = "You can update the selected owner";
            ButtonUpdate.Enabled = true;
        }

        protected void ButtonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\SQLEXPRESS; integrated security = true; database = SnakeDB");
            SqlCommand cmd = null;
            string sqlupd = "update Owner set Name = @Name where OwnerID = @OwnerID";

            try
            {
                conn.Open();

                cmd = new SqlCommand(sqlupd, conn);
                cmd.Parameters.Add("@Name", SqlDbType.Text);
                cmd.Parameters.Add("@OwnerID", SqlDbType.Int);

                cmd.Parameters["@Name"].Value = TextBox2.Text;
                cmd.Parameters["@OwnerID"].Value = Convert.ToInt32(TextBox1.Text);

                cmd.ExecuteNonQuery();

                Label1.Text = "The owner has been updated. Select a new owner";
                ButtonUpdate.Enabled = false;
            }
            catch (Exception ex)
            {
                Label1.Text = ex.Message;
            }
            finally
            {
                conn.Close();
            }

            UpdateGridview();
        }
    }
}