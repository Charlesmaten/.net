using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalkingPeople
{
    //Not automatically set to public
    class TalkingPerson
    {
        private Chair c;
        private string name;
        private string ownMessage;
        public TalkingPerson(string name, string ownMessage, Chair c)
        {
        this.name = name;
        this.ownMessage = ownMessage;
        this.c = c;
        }

        public void MyRun()
        {
            for (int i = 0; i < 10; i++)
            {
                c.Speak(name, ownMessage);
            }
        }
    }
}
