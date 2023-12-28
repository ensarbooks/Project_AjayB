using Fields;
using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    public class Product
    {

        public string Name;
        public int Model;
        public string version;
        public bool Sunroof;
        public double cost;
        public double tax;
        

        public void GetTax()
        {
            
            if (cost <= 2000000)
            {
                tax = cost * 12.5 / 100;
;           }
            else
            {
                tax = cost * 10 / 100;
            }

        }

    }
}
