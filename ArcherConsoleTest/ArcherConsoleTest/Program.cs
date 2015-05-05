using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ArcherConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Henrik";
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = ArcherDb");
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM NameTable WHERE Name = '" + name + "'"; //ArcherID ændret til Name        
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Read();

            NameTable nt = new NameTable();
            nt.ArcherId = (int)rdr["ArcherID"];
            nt.Name = rdr["Name"].ToString();
            nt.Alias = rdr["Alias"].ToString();
            Console.WriteLine(nt.Name);
            Console.ReadKey();
            rdr.Close();
        }
    }
}
