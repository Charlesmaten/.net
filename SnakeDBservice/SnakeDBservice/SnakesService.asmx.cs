using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;

namespace SnakeDBservice
{
    /// <summary>
    /// Summary description for SnakesService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class SnakesService : System.Web.Services.WebService
    {

        [WebMethod]
        public Answer FindSnake(int snakeId)
        {
            SqlConnection conn = new SqlConnection(@"data source =.\sqlexpress; integrated security = true; database = Snakes");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select * from Snake where SnakeID = " + snakeId;
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();
            //rdr.read() returns a boolean : true if data was found, else false
            //e.g. use while(rdr.read())
            Snake s = new Snake();
            s.Id = (int) rdr["SnakeID"];
            s.Name = rdr["Name"].ToString();
            s.OwnerId = (int) rdr["Owner"];
            rdr.Close();

            cmd.CommandText = @"select * from Owner where OwnerId = " + s.OwnerId;
            rdr = cmd.ExecuteReader();
            rdr.Read();
            Owner o = new Owner();
            o.Id = (int) rdr["OwnerID"];
            o.Name = rdr["Name"].ToString();
            rdr.Close();

            Answer a = new Answer();
            a.s = s;
            a.o = o;
            return a;
        }




        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
