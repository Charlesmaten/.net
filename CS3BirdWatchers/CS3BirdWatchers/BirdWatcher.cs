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
    public partial class BirdWatcher : Form
    {
        //Class Variable
        private static int autonumber = 1;


        private int location;
        private Log log;
        private string[] description = { "Bird" , "Hawk" , "Eagle" , "Red Sparrow"};       
        private string[] rarity = { "Rarity", "1", "2", "3" };
            

        public BirdWatcher(Log log)
        {
            InitializeComponent();
            location = autonumber;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(400, location * 150 - 100);
            comboBox1.DataSource = description;
            comboBox2.DataSource = rarity;
            label1.Text = "";
            label2.Text = "No message";
            Text = "Bird Watcher " + location;
            autonumber++;
            this.log = log;
            log.birdEvent += new Log.BirdEventHandler(BirdSpotted);
        }

        public void BirdSpotted(object sender, Birds birdsinfo)
        {

            if (birdsinfo.location == location)
            {
            }
            else
            {
                label2.Text = birdsinfo.description + " spotted at bird watcher " + birdsinfo.location;
            }

        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0 || comboBox2.SelectedIndex == 0)
            {
                label1.Text = "Select a bird and rarity";
            }
            else
            {
                label1.Text = "";
                log.BirdSpotted(location, comboBox1.SelectedItem.ToString(), Convert.ToInt32(comboBox2.SelectedItem.ToString()));
            }
        }

        private void buttonClearText_Click(object sender, EventArgs e)
        {
            label2.Text = "No alarm";
        }

    }
}
