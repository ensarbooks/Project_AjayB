using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInheritance
{
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Location { get; set; }

        public Employee(int empId, string empName, string location)
        {
            EmpId = empId;
            EmpName = empName;
            Location = location;
        }
    }
}
