using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4Services
{
    public class ClientName
    {
        private string name;
        private string alias;
        private ClientPrizes own;

        public ClientName(ArcherService.NameData nt, ClientPrizes cp)
        {
            Name = nt.Name;
            Alias = nt.Alias;
            Own = cp;
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

        public ClientPrizes Own
        {
            get { return own; }
            set { own = value; }
        }


        public override string ToString()
        {
            return Name + " has the alias " + Alias + Own.ToString();
        }
    }
}
