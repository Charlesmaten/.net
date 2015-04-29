using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SnakeDBservice
{
    public class Snake
    {
        public int Id { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }

        public Snake()
        {
            
        }
    }
}