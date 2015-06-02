using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data;
using System.Data.SqlClient;

namespace MVCSnakeDB.Models
{
    public class SelectSnakeAndOwnerModel
    {
        // Only one method in class
        public DataSet GetSnakeWithOwner(int snakeid)
        {
            SqlConnection conn = new SqlConnection(@"data source = .\sqlexpress; integrated security = true; database = SnakeDB");
            SqlCommand cmd = new SqlCommand("select Snake.SnakeID, Snake.Name, Owner.Name from Snake, Owner where Snake.Owner = Owner.OwnerID and Snake.SnakeID =" + snakeid, conn);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            return ds;
        }
    }
}