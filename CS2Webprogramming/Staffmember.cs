using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2Webprogramming
{
    class Staffmember : Person
    {
        private string position;

        public Staffmember(int id, string name, int phonenumber, string password, string position) : base(id, name, phonenumber, password)
        {
            this.position = position;
        }

        public string Position
        {
            get { return position; }
        }

        public override string ToString()
        {
            return "The staffmember has the position: " + Position;
        }
    }
}
