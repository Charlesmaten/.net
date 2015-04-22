using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simpleobjectservice
{
    public class Clientrabbit
    {
        
            // Data from the server xml must be set
            public Clientrabbit(localhost1.Rabbit r)
            {
                Id = r.Id;
                Name = r.Name;
            }


            public int Id { get; set; }

            public string Name { get; set; }

        public override string ToString()
        {
            return Name + " has the id " + Id;
        }
    }
}