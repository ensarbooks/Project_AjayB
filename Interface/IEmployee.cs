using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal interface IEmployee
    {
        //Interface can contains only methods and Auto Implemented properties
        //Interface is by default public
        
        //Auto Implemented properties
         int EmpId { get; set; }
         string EmpName { get; set; }
         string Location { get; set; }

        //Method
        // Interface method doesn't contain Body same like Abstract Method
        string GetTotalNoOfEmployees();
    }
}
