using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class Form1 : Form
    {
        private double amount, percentage, tax, total;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                amount = Convert.ToDouble(textBox1.Text);
                percentage = Convert.ToDouble(numericUpDown1.Value);
                tax = amount * percentage / 100;
                total = amount + tax;
                label3.Text = "Calculated tax : " + percentage.ToString("F") + "% of" + amount.ToString("F") + " is " + tax.ToString("F"); 
                label4.Text = "Total amount : " + total.ToString("F");
            }
            catch (Exception ex)
            {
                label3.Text = "Invalid amount";
                label4.Text = "Total amount";
                textBox1.Focus();
            }
        }
    }
}
