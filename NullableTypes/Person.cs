using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes
{
    public class Person
    {
        // Nullable means the data type which will contains a value must store Null(Empty) value. 
        // Structures and Enumerations (Value type) are Non Nullable Types. Classes and Interfaces (Reference Type) are Nullable Types.
        //Examples - int = Structure, String = Class


        public int? NoOfPersons { get; set; } // To handle Null we should place "?" after datatype then it will Nullable datatype.
    }
}
