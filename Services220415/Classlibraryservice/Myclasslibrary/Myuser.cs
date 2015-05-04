using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myclasslibrary
{
    public class Myuser
    {
        private string username;
        private string userpassword;

        // constructor without parameter necessary to allow use of dll
        public Myuser()
        {
        }

        public Myuser(string username, string userpassword)
        {
            this.username = username;
            this.userpassword = userpassword;
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Userpassword
        {
            get { return userpassword; }
            set { userpassword = value; }
        }
    }
}
