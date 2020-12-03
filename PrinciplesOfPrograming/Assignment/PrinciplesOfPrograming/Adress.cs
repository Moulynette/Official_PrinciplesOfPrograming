using System;
using System.Collections.Generic;
using System.Text;

namespace PrinciplesOfPrograming
{
    public class Adress
    {
        string number;
        string street;
        string city;
        string country;

        public Adress(string a, string b, string c, string d)
        {
            this.number = a;
            this.street = b;
            this.city = c;
            this.country = d;

        }
        public string Number
        {
            get
            {
                return number;
            }
        }

        public string Street
        {
            get
            {
                return number;
            }
        }

        public string City
        {
            get
            {
                return number;
            }
        }

        public string Country
        {
            get
            {
                return number;
            }
        }

        public override string ToString()
        {
            return (" is living at " + this.number + " " + this.street + " " + this.city + " " + this.country);
        }




    }
}
