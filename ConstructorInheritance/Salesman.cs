using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInheritance
{
    public class Salesman : Employee
    {
        public string Region { get; set; }

        public Salesman(int empId, string empName, string location, string region) : base(empId, empName, location)
        {
            Region = region;
        }
        public double GetSalesforCurrentMonth()
        {
            return 1000;
        }
    }
}
