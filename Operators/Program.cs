using System;
using System.Runtime.Intrinsics.X86;

namespace Operators
{
    internal class Program
    {
        static void Main()
        {
            //Arithmetical operators

            decimal a = 10M;
            decimal b = 20M;
            decimal c = a + b;
            decimal d = a * b;
            decimal e = a - b;
            decimal f = a / b;
            decimal g = a % b;

            //Assignment operators

            a += 20M;
            b -= 10M;
            c /= 49M;
            d *= 23M;
            e %= 34;

            //Incremental operator
            a = 10;

            Console.WriteLine(++a); //Result = 11
            Console.WriteLine(a++); //Result = 11
            Console.WriteLine(a); //Result = 12 
            Console.WriteLine(--a); // result = 11
            Console.WriteLine(a--); // Result = 11
            Console.WriteLine(a);  // Result = 10 

            //Assignment Operator 

            var z = a == 10; // True
            z = a != 10; //False
            z = a >= 10; //True
            z = a > 10; //False
            z = a < 10; // False

            //Logical opeprators
            z = (a == 10) && (a >= 10); //True 
            z = ( a >= 10) && (a > 10); //False
            z = (a >= 10) || (a > 10); //True
            z = (a == 10 ) ^ (a == 10); //False
            z = !(z); // True
            Console.Write(z);

            

            
        }
    }
}
