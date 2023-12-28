using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    public abstract class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }


        //Method
        public abstract string GetTotalEmployees(); // In Abstarct Method It doesn't contain Method Body.
    }
}
