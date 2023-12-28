using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Salesman : Employee
    {
        public string Region { get; set; }
        public override string GetTotalEmployees()
        {
            return "Total No. of Employees: " + 1000;
        }
        public double GetSalesforCurrentMonth()
        {
            return 1000;
        }
    }
}
