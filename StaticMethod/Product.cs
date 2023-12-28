using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    internal class Product
    {
        private int ProductId;
        private string ProductName;
        public double cost;
        private double tax;
        private int QuantityInStock;
        private static int TotalNoProducts;
        private const string CategoryName = "Electronics";
        private readonly string DateOfPurchase;

        //We Can also Access private fields in other class through Public methods


        
        public static void  SetTotalNoProducts(int value)
        {
            TotalNoProducts = value;

        }

        public static int GetTotalNoProducts()
        {
            return TotalNoProducts;
        }

       
    }
}
