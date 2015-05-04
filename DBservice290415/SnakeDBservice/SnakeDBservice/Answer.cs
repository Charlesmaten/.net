using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakeDBservice
{
    public class Answer
    {
        private Snake s;
        private Owner o;

        public Answer()
        {
        }

        public Snake S
        {
            get { return s; }
            set { s = value; }
        }

        public Owner O
        {
            get { return o; }
            set { o = value; }
        }
    }
}