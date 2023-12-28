using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Manager : IEmployee 
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }
        
        // Implementing Parent Interface Method
        // Instead of consuming fields/methods from Parent class. Here the child class is implementing Parent's Interface.
        public  string GetTotalNoOfEmployees()
        {
            return "Total No. of Employees: " + 1000;
        }
        
    }
}
