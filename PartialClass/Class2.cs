using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class PartialClass
    {
        public string ProductName { get; set; } = "Furniture";

        //Creating Method Body and Method Definition for partial class-1

        public void CallGetProductTax()
        {
            GetProductTax();
        }
    } 
}
