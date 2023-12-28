using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHiding
{
    public class Manager : Employee 
    {
        public string DepartmentName { get; set; }

        //Creating a Method with same name of parent class
        public new string  GetTotalEmployees() // Adding New keyword will hides Parent class method
        {
            return "Total No. of Employees: " + 50;
        }
        public double GetTotalSalesValue()
        {
            return 24000;
        }
    }
}
