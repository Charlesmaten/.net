using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ArcherService
{
    /// <summary>
    /// Summary description for ArcherService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class ArcherService : System.Web.Services.WebService
    {
        /*
        The service should receive a real name.
	    The service should return the alias and a list of prizes.
        */

        [WebMethod]
        public Answer FindName(string name)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = ArcherDb");
            //SqlConnection conn = new SqlConnection(@"data source = Charles\sqlexpress; integrated security = true; database ArcherDb");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"select * from NameTable where Name = " + name; //ArcherID ændret til Name
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            NameTable nt = new NameTable();
            nt.ArcherId = (int) rdr["ArcherID"];
            nt.Name = rdr["Name"].ToString();
            nt.Alias = rdr["Alias"].ToString();
            rdr.Close();

            cmd.CommandText = @"select * from PrizesTable where Alias = " + nt.Alias;
            rdr = cmd.ExecuteReader();
            rdr.Read();
            PrizesTable pt = new PrizesTable();
            pt.Alias = rdr["Alias"].ToString();
            pt.Prizes = rdr["Prizes"].ToString();
            rdr.Close();

            conn.Close();

            Answer a = new Answer();
            a.NameTable = nt;
            a.PrizesTable = pt;
            return a;




        }




        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
    }
}
