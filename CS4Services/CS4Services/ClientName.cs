using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4Services
{
    class ClientName
    {
        public string Name { get; set; }
        public string Alias { get; set; }
        public ClientPrizes Own { get; set; }


        public ClientName(ArcherService.NameTable nt, ClientPrizes cp)
        {
            Name = nt.Name;
            Alias = nt.Alias;
            Own = cp;
        }


        public override string ToString()
        {
            return Name + " has the alias " + Alias + Own.ToString();
        }
    }
}
