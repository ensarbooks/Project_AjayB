using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public class Manager : Employee 
    {
        public string DepartmentName { get; set; }

        public override string GetTotalEmployees()
        {
            return "Total No. of Employees: " + 500;
        }
        public double GetTotalSalesValue()
        {
            return 24000;
        }
    }
}
