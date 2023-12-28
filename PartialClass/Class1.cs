using System;
using System.Collections.Generic;
using System.Text;

namespace PartialClass
{
    public partial class PartialClass
    {
        public int ProductId { get; set; } = 1;

        // Method declaration
        partial void GetProductTax();
            //  Partail Method cannot have Access Modifier and Method Defintion (Body). By default it is private
         // Method body has to imlement in other partial class
        

    }
}
