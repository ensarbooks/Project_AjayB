using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Salesman : IEmployee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }


        public string GetTotalNoOfEmployees()
        {
            return "Total No. of Employees: " + 500;
        }
    }
}
