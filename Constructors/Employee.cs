using System;
using System.Collections.Generic;
using System.Text;

namespace InstanceConstructors
{
    public class Employee
    {
        public int EmpId;
        public string EmpName;
        public string Job;



        public Employee(int empId, string empName, string job)
        {
            this.EmpId = empId;
            this.EmpName = empName;
            this.Job = job;
        }
    }
}
