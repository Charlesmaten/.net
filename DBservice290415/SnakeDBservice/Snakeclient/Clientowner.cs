using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Snakeclient
{
    public class Clientowner
    {
        private int id;
        private string name;

        public Clientowner(localhost.Owner o)
        {
            id = o.Id;
            name = o.Name;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return " Owner is " + Name + " with id " + Id;
        }
    }
}