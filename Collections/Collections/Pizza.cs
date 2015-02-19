using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections;

namespace Collections
{
    public class Pizza
    {
        //Instance variables
        string pizzaname;
        double pizzaprice;
        ArrayList ingredients;

        //Construstor

        public Pizza(string name, double price)
        {
            pizzaname = name;
            pizzaprice = price;
            ingredients = new ArrayList();
        }
        // add ingredient

        public void AddIngredient(string item){
            ingredients.Add(item);
           
        }
        //Tostring
        public override string ToString()
        {
            string answer = "The pizza " + pizzaname + " costs " + pizzaprice + " kr and contains ;";
            for (int i = 0; i < ingredients.Count; i++)
            {
                answer += ingredients[i] + " ";
            }
            return answer;
        }
    }
}