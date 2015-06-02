using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2Webprogramming
{
    // Aver fra person klassen
    class Staffmember : Person
    {
        private string position;
        // Base fortæller hvilken dele denne klasse aver fra person klassen
        public Staffmember(int id, string name, int phonenumber, string password, string address, string position) : base(id, name, phonenumber, password, address)
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
