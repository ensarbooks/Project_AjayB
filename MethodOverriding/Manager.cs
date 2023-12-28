using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class Manager : Employee 
    {
        public string DepartmentName { get; set; }

        //Creating a Method with same name of parent class
        public override string  GetTotalEmployees() // Adding override keyword to extend parent class method to child method
        {
            Console.WriteLine("Parent class:  "+ base.GetTotalEmployees());
            return "Total No. of Employees: " + 50;
        }
       
    }
}
