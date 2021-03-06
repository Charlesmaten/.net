﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4Services
{
    public class ClientPrizes
    {
        private string alias;
        private string prizes;

        public ClientPrizes(ArcherService.PrizesData pt)
        {
            Alias = pt.Alias;
            Prizes = pt.Prizes;
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


        public override string ToString()
        {
            return " With the prizes " + Prizes;
        }
    }
}
