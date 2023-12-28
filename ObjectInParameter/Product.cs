using System;
using System.Collections.Generic;
using System.Text;

namespace Arguments
{
    internal class Product
    {
        public int ProductId;
        public string ProductName;
        public double cost;
        public double tax;
        public int QuantityInStock;
        public static int TotalNoProducts;
        public const string CategoryName = "Electronics";
        public readonly string DateOfPurchase;

        //We Can also Access private fields in other class through Public methods


        public Product()
        {
            DateOfPurchase = System.DateTime.Now.ToShortDateString();

        }

       
        public void SetCost(double value)
        {
            cost = value;

        }

        public double GetCost()
        {
            return cost;
        }

        

        public double GetTax()
        {
            return tax;
        }


       

        public void SetQuantityInStock(int value)
        {
            QuantityInStock = value;

        }

        public int GetQuantityInStock()
        {
            return QuantityInStock;
        }

       
      

        //Object Reference In Parameter
        // Here we passed objects in Parameters
        public static int GetTotalQuanity(Product car, Product byke, Product bus)
        {
            var totalQty = car.GetQuantityInStock() + byke.GetQuantityInStock() + bus.GetQuantityInStock();

            return totalQty;
        }

        // Default Parameters
        public void CaliculateTax(double percentage = 5.5) // Assigning default value for an argument
        {

            if (cost <= 2000000)
            {
                tax = cost * 12.5 / 100;
                
            }
            else
            {
                tax = cost * percentage / 100;
            }

        }
    }
}
