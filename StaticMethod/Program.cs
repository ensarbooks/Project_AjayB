using Encapsulation;
using System;

namespace StaticMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We can access static method without an object.

            //Set 
            Product.SetTotalNoProducts(1542);

            //Get 
           var totalProducts = Product.GetTotalNoProducts();


            Console.WriteLine("Total No. of Products: " + totalProducts);



            //Pass Object Reference as Arguments


        }
    }
}
