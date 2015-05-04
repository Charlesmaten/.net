using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Snakeclient
{
    public class Clientsnake
    {
        private int id;
        private Clientowner own;
        private string name;

        public Clientsnake(localhost.Snake s, Clientowner c)
        {
            id = s.Id;
            name = s.Name;
            own = c;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public Clientowner Own
        {
            get { return own; }
            set { own = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override string ToString()
        {
            return Name + " has id " + Id + "." + Own.ToString();
        }
    }
}