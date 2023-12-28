using StaticConstructors;
using System;

namespace StaticConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Since we are callimng static field, no need to create an object

            var comapanyName = Employee.CompanyName;
            
            


            Console.Write(comapanyName);
        }
    }
}
