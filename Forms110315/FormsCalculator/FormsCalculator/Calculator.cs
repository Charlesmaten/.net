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
    public partial class Calculator : Form
    {
        private int number, total;
        Result res;

        public Calculator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            Location = new Point(300, 100);
            total = 0;
            res = new Result();
            res.Tb.Text = "0";
            res.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyInput inputdialog = new MyInput();
            // blocking further execution
            inputdialog.ShowDialog(this);
            number = inputdialog.Number;
            textBox1.Text = number.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            total += number;
            res.Visible = true;
            res.Tb.Text = total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            total -= number;
            res.Visible = true;
            res.Tb.Text = total.ToString();
        }
    }
}
