using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorInheritance
{
    public class Manager : Employee 
    {
        public string DepartmentName { get; set; }

        public Manager(int empId, string empName, string location, string departmentName) : base(empId, empName, location)
        {
            DepartmentName = departmentName;
        }
        public double GetTotalSalesValue()
        {
            return 24000;
        }
    }
}
