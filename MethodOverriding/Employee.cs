using System;
using System.Collections.Generic;
using System.Text;

namespace MethodOverriding
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }
        
        //Creating a Method in parent class
        public virtual string GetTotalEmployees() // Adding Virtual keyword to parent method in order to override in Child method
        {
            return "Total No. of Employees: " + 100;
        }
    }
}
