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
    public partial class FireStation : Form
    {
        public delegate void FireEventHandler(object sender, FireEventArgs fire)

        public event FireErrorEventHandler fireEvent;

        public FireStation(){
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(200, 200);
            textBox1.BackColor = Color.Yellow;
            textBox1.Text = "";
            button1.Enabled = false;

            listBox1.Items.Add("Fire station ready");
        }

        //Raise event
        public void RaiseFireAlarm(int location, string room, int ferocity)
        {
            listBox1.Items.Add("Alarm from ") + location + " : " + room + ", ferocity" + ferocity;
            if(ferocity == 3)
            {
                textBox1.BackColor = Color.Red;
                textBox1.Text = "Alarm";
                button1.Enabled = true;
            }
            FireEventArgs fea = new FireEventArgs(location, room, ferocity);
            fireEvent(this, fea);
        }


        public FireStation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
