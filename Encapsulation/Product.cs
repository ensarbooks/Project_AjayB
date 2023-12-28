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


        public Product()
        {
            DateOfPurchase = System.DateTime.Now.ToShortDateString();

        }

        public void SetProductId(int value)
        {
            ProductId = value;
            
        }

        public int GetProductId()
        {
            return ProductId;
        }
        public void SetProductName(string value)
        {
            ProductName = value;

        }

        public string GetProductName()
        {
            return ProductName;
        }

        public void SetCost(double value)
        {
            cost = value;

        }

        public double GetCost()
        {
            return cost;
        }

        public void SetTax(double value)
        {
            tax = value;

        }

        public double GetTax()
        {
            return tax;
        }


        public void CaliculateTax()
        {

            if (cost <= 2000000)
            {
                tax = cost * 12.5 / 100;
                ;
            }
            else
            {
                tax = cost * 10 / 100;
            }

        }

        public void SetQuantityInStock(int value)
        {
            QuantityInStock = value;

        }

        public int GetQuantityInStock()
        {
            return QuantityInStock;
        }
        public void SetTotalNoProducts(int value)
        {
            TotalNoProducts = value;

        }

        public int GetTotalNoProducts()
        {
            return TotalNoProducts;
        }

        public string GetCategoryName(string value)
        {
            return CategoryName;
        }
        public string GetDateOfPurchase(string value)
        {
            return DateOfPurchase;
        }
    }
}
