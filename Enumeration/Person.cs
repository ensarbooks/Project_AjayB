using System;
using System.Collections.Generic;
using System.Text;

namespace Enumeration
{
    public class Person
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public AgeGroupEnum AgeGroup { get; set; } // Here AgeGroupEnum is an Enumeration where it contains set of Constants with values

    }
}
