using System;
using System.Collections.Generic;
using System.Text;

namespace StaticConstructors
{
    public class Employee
    {
        //Instance Fields
        public int EmpId;
        public string EmpName;
        public string Job;

        //Static Fields

        public static string CompanyName;

        public Employee(int empId, string empName, string job)
        {
            EmpId = empId;
            EmpName = empName;
            Job = job;
        }

        public Employee()
        {
           
        }

        static Employee()
        {
            CompanyName = "Ensar Solutions";
        }
    }
}
