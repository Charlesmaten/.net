using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2Webprogramming
{
    [Serializable]
    public class Person
    {
        private int id;
        private string name;
        private int phonenumber;
        private string password;
        private string address;

        //Constructor
        public Person(int id, string name, int phonenumber, string password, string address)
        {
            this.id = id;
            this.name = name;
            this.phonenumber = phonenumber;
            this.password = password;
            this.address = address;
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
            set { password = value; }
        }

        public string Address
        {
            get { return address; }
        }

        public override string ToString()
        {
            //return "Person: " + Name + "has id: " + Id + " and phonenumber: " + Phonenumber + "and password: ";
            return "Password changed to: " + password;
        }

        public string ChangePassword()
        {
            if (password.Length >= 4)
            {
                return password;
            }
            else
            {
                return "Password must be 4 characters long";
            }
            //metode der skifer password, skal minimum have 4 characters
        }

    }
}
