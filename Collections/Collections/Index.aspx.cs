using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Collections
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int[] numbers = new int[3];
            int[] morenumbers = { 1, 2, 3, 4 };
            int[,] manynumbers = new int[2, 3];
            Pizza p1 = new Pizza("Good", 50.5);
            Pizza p2 = new Pizza("Medium", 45);
            Pizza p3 = new Pizza("Bad", 37.75);
            ArrayList menu = new ArrayList();





            numbers[0] = 2;
            numbers[1] = 0;
            numbers[2] = 3;
            PrintIntarray(numbers);
            ListBox1.Items.Add("Number of elements = " + numbers.Length);
            ListBox1.Items.Add("Numbers sorted: ");
            Array.Sort(numbers);
            PrintIntarray(numbers);
            ListBox1.Items.Add("Numbers reversed ;");
            Array.Reverse(numbers);
            PrintIntarray(numbers);
            ListBox1.Items.Add("Numbers cleared :");
            Array.Clear(numbers, 0, numbers.Length);
            PrintIntarray(numbers);
            ListBox1.Items.Add("");

            PrintIntarray(morenumbers);
            ListBox1.Items.Add("");

            manynumbers[0, 0] = 1;
            manynumbers[0, 1] = 2;
            manynumbers[0, 2] = 3;
            manynumbers[1, 0] = 4;
            manynumbers[1, 1] = 5;
            manynumbers[1, 2] = 6;
            PrintIntarray(manynumbers);
            ListBox1.Items.Add("");

            p1.AddIngredient("cheese");
            p1.AddIngredient("tomato");
            p1.AddIngredient("Ham");
            p1.AddIngredient("Peperroni");

            p2.AddIngredient("cheese");
            p2.AddIngredient("tomato");
            p2.AddIngredient("Pineapple");

            p3.AddIngredient("cheese");
            p3.AddIngredient("cabbage");

            ListBox1.Items.Add(p1.ToString());
            ListBox1.Items.Add(p2.ToString());
            ListBox1.Items.Add(p3.ToString());

            ListBox1.Items.Add("");


            



 
 
 
 

        }

        private void PrintIntarray(int[] x)
        {
            string result = "";
            for (int n = 0; n < x.Length; n++)
            {
                result += x[n] + " ";
            }
            ListBox1.Items.Add(result);
        }

        private void PrintIntarray(int[,] x)
        {
            string result;
            for (int n = 0; n < x.GetLength(0); n++)
            {
                result = "";
                for (int m = 0; m < x.GetLength(1); m++)
                {
                    result += x[n, m] + " ";
                }
                ListBox1.Items.Add(result);
            }
        }

    }
}