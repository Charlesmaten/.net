using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace TalkingPeople
{
    public partial class Chair : Form
    {
        private TalkingPerson tp1, tp2, tp3;
        private Thread t1, t2, t3;
        private Object mylock;

        public Chair()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            mylock = new object();
            textBoxChair.Text = "";
            tp1 = new TalkingPerson("Hugo", "bla", this);
            // ThreadStart klargøre tråden til brug
            t1 = new Thread(new ThreadStart(tp1.MyRun));
            tp2 = new TalkingPerson("Hugoline", "talk", this);
            t2 = new Thread(new ThreadStart(tp2.MyRun));
            tp3 = new TalkingPerson("Afskylia", "he", this);
            t3 = new Thread(new ThreadStart(tp3.MyRun));
        }

        public void Speak(string name, string mymessage)
        {
            if(checkBoxChair.Checked)
            { 
                // Lock - Kun en thread kan køre lykken igennem af gangen
                // Critical region
                lock (mylock)
                { 
                    textBoxChair.Text += name + ": " ;
                    for(int i = 0; i < 10; i++)
                    {
                        textBoxChair.Text += mymessage + " ";
                    }
                    textBoxChair.Text += "\r\n";
                }
            }
            else
            {
                textBoxChair.Text += name + ": ";
                for (int i = 0; i < 10; i++)
                {
                    textBoxChair.Text += mymessage + " ";
                }
                textBoxChair.Text += "\r\n";
            }
        }

        private void buttonChair_Click(object sender, EventArgs e)
        {
            buttonChair.Enabled = false;
            t1.Start();
            t2.Start();
            t3.Start();
        }

        private void checkBoxChair_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
