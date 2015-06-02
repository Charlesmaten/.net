using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExamples.Models
{
    public class Product
    {
        private string productname;

        public Product()
        {
        }

        public string Productname
        {
            get { return productname; }
            set { productname = value; }
        }
    }
}