using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4Services
{
    class ClientPrizes
    {
        public string Alias { get; set; }
        public string Prizes { get; set; }

        public ClientPrizes(ArcherService.PrizesTable pt)
        {
            Alias = pt.Alias;
            Prizes = pt.Prizes;
        }

        public override string ToString()
        {
            return "Alias is " + Alias + " With prizes " + Prizes;
        }
    }
}
