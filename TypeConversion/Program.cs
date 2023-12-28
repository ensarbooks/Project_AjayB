using System;

namespace TypeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TryParse
            //Try Parse is the best method to convert string to Numberic Values since it avoids Null Exceptions
            var s = "500";

            var result = int.TryParse(s, out var n);
            if( result == true)
            {
                Console.WriteLine("The source value has successfully converted from string to Int");
                Console.WriteLine(n);
            }
            else
            {
                Console.WriteLine("The Source value is invalid");
            }
        }
    }
}
