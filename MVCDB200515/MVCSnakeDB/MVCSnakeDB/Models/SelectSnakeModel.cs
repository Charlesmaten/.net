using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace MVCSnakeDB.Models
{
    public class SelectSnakeModel
    {
        // Only one method in class
        public DataSet GetAllSnakes()
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = SnakeDB");
            SqlCommand cmd = new SqlCommand("select SnakeID, Type, Name, Length, Owner from Snake", conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
    }
}