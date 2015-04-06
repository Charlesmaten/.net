using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireEventForm
{
    public partial class AlarmBox : Form
    {
        // class variable
        private static int autonumber = 1;

        // instance variables
        private int location;
        private FireStation fs;
        private string[] room = { "room", "office", "reception", "store room" };
        private string[] ferocity = { "ferocity", "1", "2", "3" };

        // constructor
        public AlarmBox(FireStation fs)
        {
            InitializeComponent();
            location = autonumber;
            StartPosition = FormStartPosition.Manual;
            Location = new Point(400, location * 150 - 100);
            comboBox1.DataSource = room;
            comboBox2.DataSource = ferocity;
            label1.Text = "No alarm";
            label2.Text = "No message";
            Text = "Alarm box " + location;
            autonumber++;
            this.fs = fs;
            fs.fireEvent += new FireStation.FireEventHandler(ExtinguishFire);
        }

        // ExtinguishFire must match the delegate FireEventHandler
        public void ExtinguishFire(object sender, FireEventArgs fireinfo)
        {
            if(fireinfo.location == location)
            { 
                if(fireinfo.ferocity == 1)
                {
                    label1.Text = "Use water on the fire in the " + fireinfo.room + " of ferocity " + fireinfo.ferocity;
                }
                else
                {
                    if (fireinfo.ferocity == 2)
                    {
                        label1.Text = "Use fire extinguisher on the fire in the " + fireinfo.room + " of ferocity " + fireinfo.ferocity;
                    }
                    else
                    {
                        label1.Text = "The fire brigade will handle the fire in the " + fireinfo.room + " of ferocity " + fireinfo.ferocity;
                    }
                }
            }
            else
            {
                label2.Text = "There is a fire at location " + fireinfo.location;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex == 0 || comboBox2.SelectedIndex == 0)
            {
                label1.Text = "Select both room and ferocity";
            }
            else
            {
                fs.RaiseFireAlarm(location, comboBox1.SelectedItem.ToString(), Convert.ToInt32(comboBox2.SelectedItem.ToString()));

               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "No alarm";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "No alarm";
        }

        private void AlarmBox_FormClosing(object sender, FormClosingEventArgs e)
        {
            // GUI can no tbe closed
            e.Cancel = true;
        }
    }
}
