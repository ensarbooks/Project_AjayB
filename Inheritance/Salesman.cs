using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Salesman : Employee
    {
        public string Region { get; set; }

        public double GetSalesforCurrentMonth()
        {
            return 1000;
        }
    }
}
