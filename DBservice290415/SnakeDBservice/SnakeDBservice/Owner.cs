using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakeDBservice
{
    public class Owner
    {
        private int id;
        private string name;

        // "empty" constructor
        public Owner()
        {
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
    }
}