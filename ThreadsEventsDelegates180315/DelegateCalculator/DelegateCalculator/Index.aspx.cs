using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DelegateCalculator
{
    public partial class Index : System.Web.UI.Page
    {
        Calculator.Calculate add = new Calculator.Calculate(Calculator.Add);
        Calculator.Calculate sub = new Calculator.Calculate(Calculator.Sub);
        Calculator.Calculate mul = new Calculator.Calculate(Calculator.Mul);
        Calculator.Calculate div = new Calculator.Calculate(Calculator.Div);

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox3.Text = add(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text)).ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox3.Text = sub(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text)).ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            TextBox3.Text = mul(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text)).ToString();
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            TextBox3.Text = div(Convert.ToDouble(TextBox1.Text), Convert.ToDouble(TextBox2.Text)).ToString();
        }
    }
}