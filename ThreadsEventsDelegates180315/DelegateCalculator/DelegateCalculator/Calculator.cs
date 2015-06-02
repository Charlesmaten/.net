using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DelegateCalculator
{
    public class Calculator
    {
        // delegate
        public delegate double Calculate(double x, double y);

        // Add to the delegate
        public static double Add(double a, double b)
        {
            return a + b;
        }

        // Sub to the delegate
        public static double Sub(double a, double b)
        {
            return a - b;
        }

        // Mul to the delegate
        public static double Mul(double a, double b)
        {
            return a * b;
        }

        // Div to the delegate
        public static double Div(double z, double w)
        {
            return z / w;
        }
    }
}