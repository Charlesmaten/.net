using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcherService
{
    public class PrizesData
    {
        private int id;
        private string alias;
        private string prizes;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Alias
        {
            get { return alias; }
            set { alias = value; }
        }

        public string Prizes
        {
            get { return prizes; }
            set { prizes = value; }
        }

        public PrizesData()
        {

        }

    }
}
