using CustomerClass;
using System;

namespace Classes___Objects
{
    public class Program
    {
        // We are accessed another project, so we have added CustomerClass project reference in Console application
        static void Main(string[] args)
        {
            CustomerInfo referenceObject1 = new CustomerInfo();
            CustomerInfo referenceObject2 = new CustomerInfo();


            var name = referenceObject1.Name;
            var age = referenceObject1.Age;

            var height = referenceObject2.Height;

            Console.WriteLine("My name is: "+ name) ;
            Console.WriteLine("My Age is: "+ age);
            Console.WriteLine("My Age is " + height) ;


        }
    }
}
