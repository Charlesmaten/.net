using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkingPeople
{
    // Note : not automatically set to public
    class TalkingPerson
    {
        private Chair c;
        private string name;
        private string ownmessage;

        public TalkingPerson(string name, string ownmessage, Chair c)
        {
            this.name = name;
            this.ownmessage = ownmessage;
            this.c = c;
        }

        public void MyRun()
        {
            // Taler 10 gange
            for(int i = 0; i < 10; i++)
            {
                c.Speak(name, ownmessage);
            }
        }
    }
}
