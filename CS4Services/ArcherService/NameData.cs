using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArcherService
{
    public class NameData
    {
        private int archerId;
        private string name;
        private string alias;

        public int ArcherId
        {
            get { return archerId; }
            set { archerId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }


        public NameData()
        {

        }
    }
}