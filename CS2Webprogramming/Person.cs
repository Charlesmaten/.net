using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2Webprogramming
{
    public class Person
    {
        private int id;
        private string name;
        private int phonenumber;
        private string password;

        //Constructor
        public Person(int id, string name, int phonenumber, string password)
        {
            this.id = id;
            this.name = name;
            this.phonenumber = phonenumber;
            this.password = password;
        }

        public int Id
        {
            get { return id; }
        }

        public string Name
        {
            get { return name; }
        }

        public int Phonenumber
        {
            get { return phonenumber; }
        }

        public string Password
        {
            get { return password; }
        }

        public override string ToString()
        {
            return "Person: " + Name + "has id: " + Id + " and phonenumber: " + Phonenumber + "and password: ";
        }
        

    }
}
