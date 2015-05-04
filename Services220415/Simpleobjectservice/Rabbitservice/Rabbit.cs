using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rabbitservice
{
    public class Rabbit
    {
        private int id;
        private string name;

        // No parameters in constructor allowed
        public Rabbit()
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