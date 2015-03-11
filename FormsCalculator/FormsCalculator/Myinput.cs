using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCalculator
{
    public partial class Myinput : Form
    {
        private int number;

        //Number property (only read)
        public int Number
        {
            get { return number; }
            //set { number = value; }
        }

        public Myinput()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(50, 100);
            textBox1.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                number = Convert.ToInt32(textBox1.Text);
                //Only closes Gut; object is stil alive
                this.Close();
            }
            catch (FormatException fe)
            {
                number = 0;
                label1.Text = "Not an integer";
            }
        }
    }
}
