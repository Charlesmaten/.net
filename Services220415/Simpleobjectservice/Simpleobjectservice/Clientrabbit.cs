using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simpleobjectservice
{
    public class Clientrabbit
    {
        private int id;
        private string name;

        // Data from the server xml must be set
        public Clientrabbit(localhost.Rabbit r)
        {
            id = r.Id;
            name = r.Name;
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
            return Name + " has the id " + Id;
        }
    }
}