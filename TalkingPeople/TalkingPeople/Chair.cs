using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            textBox1.Text = "";
            tp1 = new TalkingPerson("Hugo", "Fedt man", this);
            t1 = new Thread(new ThreadStart(tp1.MyRun));
            tp2 = new TalkingPerson("Hugoline", "Ja menlig ja", this);
            t2 = new Thread(new ThreadStart(tp2.MyRun));
            tp3 = new TalkingPerson("Afskylia", "Så det siger du?", this);
            t3 = new Thread(new ThreadStart(tp3.MyRun));

        }

        public void Speak(string name, string mymessage)
        {
            if (checkBox1.Checked)
            {
                lock (mylock)
                {

                    textBox1.Text += name + ": ";
                    for (int i = 0; i < 10; i++)
                    {
                        textBox1.Text += mymessage + " ";
                    }
                    textBox1.Text += "\r\n";
                }
            }
            else
            {
                textBox1.Text += name + ": ";
                for (int i = 0; i < 10; i++)
                {
                    textBox1.Text += mymessage + " ";
                }
                textBox1.Text += "\r\n";
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
