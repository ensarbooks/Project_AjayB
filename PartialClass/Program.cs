using System;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In Partial Class we can create N number of classes with same CLass name and can access all classes fields with a single object

            //object
            PartialClass product = new PartialClass();

            var id = product.ProductId; // class-1
            var name = product.ProductName; // class-2
            var cost = product.ProductCost;  //class-3

            Console.WriteLine("Class-1 Prodcut Id: " + id);
            Console.WriteLine("Class-2 Product Name: " + name);
            Console.WriteLine("Class-3 Product Cost : " + cost);

            
            

            
        }
    }
}
