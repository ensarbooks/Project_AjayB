using System;

namespace NullableTypes
{
    public class Program
    {

        static void Main(string[] args)
        {
            //Creating Objects

            Person p1 = new Person() { NoOfPersons = null }; // Since we have added "?" to int. Nof OfPersons has accepted null value
            Person p2 = new Person() { NoOfPersons = 2 };
            Console.WriteLine(p2.NoOfPersons);

            int? totalPersons = p2.NoOfPersons; // Also we cannot store an nullable int to non-nullable int.

            //We can also handle null in another type

            if (p2.NoOfPersons != null)
            {
                Console.WriteLine("Cannot Print Null value");
            }

            // We can also Simplify the above statement
            Console.WriteLine(p2.NoOfPersons.HasValue ? p2.NoOfPersons.Value : 0); // It means if p2.NoOfPersonas has value then print p2.NoOfPersons.Value else p2.NoOfPersonas 0;
            // We can also simplify the above statement using Null Coalescing operator
            //Null Coalescing operator

            Console.WriteLine(p2.NoOfPersons ?? 0); // It also means if p2.NoOfPersonas has value then print p2.NoOfPersons.Value else p2.NoOfPersonas 0;


            
        }
    }
}
