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
        // The delegate the subscribers must use
        public delegate void FireEventHandler(object sender, FireEventArgs fireinfo);

        // event instance of the delegate
        public event FireEventHandler fireEvent;

        // constructor
        public FireStation()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(50, 50);
            textBox1.BackColor = Color.Yellow;
            textBox1.Text = "";
            button1.Enabled = false;
            AlarmBox a1 = new AlarmBox(this);
            a1.Show();
            AlarmBox a2 = new AlarmBox(this);
            a2.Show();
            AlarmBox a3 = new AlarmBox(this);
            a3.Show();
            listBox1.Items.Add("Fire station ready");
        }

        // raise event
        public void RaiseFireAlarm(int location, string room, int ferocity)
        {
            listBox1.Items.Add("Alarm from " + location + " : " + room + ", ferocity " + ferocity);
            if (ferocity == 3)
            {
                textBox1.BackColor = Color.Red;
                textBox1.Text = "Alarm";
                button1.Enabled = true;
            }
            FireEventArgs fea = new FireEventArgs(location, room, ferocity);
            fireEvent(this, fea);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
            textBox1.Text = "";
            button1.Enabled = false;
        }
    }
}
