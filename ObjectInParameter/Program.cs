using System;

namespace Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating objects
            Product car = new Product();
            Product byke = new Product();
            Product bus = new Product();


            //Intialising fields values with methods

            //Car
            car.SetCost(1500000);
            car.CaliculateTax(10); //Assigning value for tax 
            //car.SetTax(car.cost);
            car.SetQuantityInStock(20);


            //byke
            byke.SetCost(1000000);
            byke.CaliculateTax(15); //Assigning value for tax 
            //byke.SetTax(byke.cost);
            byke.SetQuantityInStock(20);

            //Car3
            bus.SetCost(3500000);
            bus.CaliculateTax(); //Invoking CaliculateTax Method and assigning default value which is in parameter
           // bus.SetTax(bus.cost);
            bus.SetQuantityInStock(20);

            
            //Invoking Get method and assigining into variables

            //Car
            var carTax = car.GetTax();

            //Byke
            var bykeTax = byke.GetTax();

            //Bus
            var busTax = bus.GetTax();


            //Object reference in parameter
            var totalQtyInStock = Product.GetTotalQuanity(car, bus, byke);



            Console.WriteLine("Total Quantity in Stock: " + totalQtyInStock);
            Console.WriteLine("Car Tax: " + carTax);
            Console.WriteLine("Byke Tax: " + bykeTax);
            Console.WriteLine("Bus Tax: " + busTax);


        }
    }
}
