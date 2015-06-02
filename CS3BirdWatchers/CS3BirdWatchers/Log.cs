using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS3BirdWatchers
{
    public partial class Log : Form
    {

        public delegate void BirdEventHandler(object sender, Birds birdsinfo);

        public event BirdEventHandler birdEvent;


        public Log()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(50, 50);
            textBox1.BackColor = Color.Yellow;
            textBox1.Text = "";
            button1.Enabled = false;
            BirdWatcher bw1 = new BirdWatcher(this);
            bw1.Show();
            BirdWatcher bw2 = new BirdWatcher(this);
            bw2.Show();
            BirdWatcher bw3 = new BirdWatcher(this);
            bw3.Show();
            listBox1.Items.Add("Spotters ready!");
        }
        //Event
        public void BirdSpotted(int location, string description, int rarity)
        {
            listBox1.Items.Add("Bird spotted from " + location + " : " + description + " with a rarity of " + rarity);
            if (rarity == 3)
            {
                textBox1.BackColor = Color.Red;
                textBox1.Text = "Alarm";
                button1.Enabled = true;
            }
            Birds birds = new Birds(description, rarity, location);
            // instancere eventet
            birdEvent(this, birds);
        }

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            textBox1.Text = "";
            button1.Enabled = false;
        }
    }
}
