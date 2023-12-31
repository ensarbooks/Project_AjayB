using NullPropagationOperator;
using System;

namespace NullPropagationOperator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() { NoOfPersons = null };

            Console.WriteLine((p1.NoOfPersons == null)? null :p1.NoOfPersons );
            // We can simplify the above statement with Null Propagation oeprator "?."

            Console.WriteLine(p1?.NoOfPersons); // To avoid Null Exception we are handling null value with "?" operator.

        }
    }
}
