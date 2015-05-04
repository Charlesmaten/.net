using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakeDBservice
{
    public class Snake
    {
        private int id;
        private int ownerid;
        private string name;

        // "empty" constructor
        public Snake()
        {
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Ownerid
        {
            get { return ownerid; }
            set { ownerid = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}