using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakeDBservice
{
    public class Answer
    {
        public Snake s { get; set; }
        public Owner o { get; set; }

        public Answer()
        {
            
        }
    }
}