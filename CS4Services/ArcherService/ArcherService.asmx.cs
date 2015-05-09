using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Web.Services;
using System.Globalization;
using System.Linq;
using System.Web;

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

        [WebMethod]
        public Answer FindName(string name)        
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = ArcherDb");          
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM NameTable WHERE Name = '" + name + "'";      
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            NameData nt = new NameData();
            nt.ArcherId = (int) rdr["ArcherID"];
            nt.Name = rdr["Name"].ToString();
            nt.Alias = rdr["Alias"].ToString();
            rdr.Close();
            
            cmd.CommandText = @"SELECT * from PrizesTable WHERE Alias = '" + nt.Alias + "'";
            rdr = cmd.ExecuteReader();
            rdr.Read();
            PrizesData pt = new PrizesData();
            pt.Id = (int) rdr["ID"];
            pt.Alias = rdr["Alias"].ToString();
            pt.Prizes = rdr["Prizes"].ToString();
            rdr.Close();
            
            conn.Close();

            Answer a = new Answer();
            a.NameData = nt;
            a.PrizesData = pt;

            return a;

        }


        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

    }
}
