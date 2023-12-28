using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Manager : Employee 
    {
        public string DepartmentName { get; set; }


        public double GetTotalSalesValue()
        {
            return 24000;
        }
    }
}
