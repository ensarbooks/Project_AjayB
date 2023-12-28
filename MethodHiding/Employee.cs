using System;
using System.Collections.Generic;
using System.Text;

namespace MethodHiding
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }
        
        //Creating a Method in parent class
        public string GetTotalEmployees()
        {
            return "Total No. of Employees: " + 100;
        }
    }
}
