﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CS2Webprogramming
{
    [Serializable]
    // Inherits from person
    public class Rider : Person
    {

        private int number;
        private string horse;
        private string nationality;
        // Base fortæller hvilken dele denne klasse aver fra person klassen
        public Rider(int id, string name, int phonenumber, string password, string address, int number, string horse, string nationality) : base(id, name, phonenumber, password, address)
        {
            this.number = number;
            this.horse = horse;
            this.nationality = nationality;
        }

        public int Number
        {
            get { return number; }
        }
        public string Horse
        {
            get { return horse; }
        }
        public string Nationality
        {
            get { return nationality; }
        }

        public override string ToString()
        {
            //return "Rider number is: " + Number + " with the horse: " + Horse + " and has the nationality: " + nationality;
            return "Rider number is " + Number + " - Rider name is " + Name + " - And is riding on the horse " + Horse;
        }
    }
}