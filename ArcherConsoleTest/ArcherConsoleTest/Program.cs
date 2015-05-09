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
           
            /*
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
            rdr.Close();

            Console.WriteLine(nt.Name);
            Console.WriteLine(nt.Alias);
            Console.ReadKey();
             */
            TesterSort();



        }

        public static string TesterSort()
        {
            string a = "3;2;1";           
            string[] nums = a.Split(';');
            int total = 0;
            foreach (string s in nums)
            {
                int tmp = int.Parse(s);
                total += tmp;
            }









            Console.WriteLine(total);
            Console.ReadKey();
            return Convert.ToString(total);
        }
    }
}
