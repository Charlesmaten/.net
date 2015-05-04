using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

using System.Data.SqlClient;

namespace SnakeDBservice
{
    /// <summary>
    /// Summary description for Snakeservice
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Snakeservice : System.Web.Services.WebService
    {
        [WebMethod]
        public Answer Findsnake(int snakeid)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = SnakeDB");
            // no error handling today
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select * from Snake where SnakeID = " + snakeid;
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            // rdr.Read() returns a boolean : true if data was found, else false
            // e.g. use while(rdr.Read())
            Snake s = new Snake();
            s.Id = (int)rdr["SnakeID"];
            s.Name = rdr["Name"].ToString();
            s.Ownerid = (int)rdr["Owner"];
            rdr.Close();

            cmd.CommandText = @"select * from Owner where OwnerId = " + s.Ownerid;
            rdr = cmd.ExecuteReader();
            rdr.Read();
            Owner o = new Owner();
            o.Id = (int)rdr["OwnerID"];
            o.Name = rdr["Name"].ToString();
            rdr.Close();

            conn.Close();

            Answer a = new Answer();
            a.S = s;
            a.O = o;
            return a;
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
