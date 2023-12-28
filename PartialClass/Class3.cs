using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace PartialClass
{
    public partial class PartialClass
    {
        public int ProductCost { get; set; } = 50000;

        // Calling Get tax method

        
        partial void GetProductTax()
        {
            var tax = ProductCost * 10 / 100;

            Console.WriteLine(tax);

        }
    }
}
