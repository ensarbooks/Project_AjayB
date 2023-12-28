using System;

namespace Encapsulation
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
            car.SetProductName("Hyundai i20") ;
            car.SetCost(950000) ;
            car.SetTotalNoProducts(15);
            car.CaliculateTax(); //Invoking CaliculateTax Method and assigning value for tax
            car.SetTax(car.cost);

            //byke
            byke.SetProductName("Royal Enfield Classic 350");
            byke.SetCost(265000);
            byke.SetTotalNoProducts(30);
            byke.CaliculateTax(); //Invoking CaliculateTax Method and assigning value for tax
            byke.SetTax(byke.cost);

            //Car3
            bus.SetProductName("APSRTC");
            bus.SetCost(3600000);
            bus.SetTotalNoProducts(50);
            bus.CaliculateTax(); //Invoking CaliculateTax Method and assigning value for tax
            byke.SetTax(byke.cost);


            //Invoking Get method and assigining into variables

            //Car
            var carName = car.GetProductName();
            var carCost = car.GetCost();
            var carTotalNoProducts = car.GetTotalNoProducts();
            var carTax = car.GetTax();
            //Byke
            var bykeName = byke.GetProductName();
            var bykeCost = byke.GetCost();
            var bykeTotalNoProducts = byke.GetTotalNoProducts();
            var bykeTax = byke.GetTax();
            //Bus
            var busName = bus.GetProductName();
            var busCost = bus.GetCost();
            var busTotalNoProducts = bus.GetTotalNoProducts();
            var busTax = bus.GetTax();

            Console.WriteLine("-----Product: Car------");
            Console.WriteLine("Name: " + carName);
            Console.WriteLine("Cost: " + carCost);
            Console.WriteLine("Total No. of Products: " + carTotalNoProducts);
            Console.WriteLine("Tax: " + carTax);
            Console.WriteLine("        ");

            Console.WriteLine("-----Product: Byke------");
            Console.WriteLine("Name: " + bykeName);
            Console.WriteLine("Cost: " + bykeCost);
            Console.WriteLine("Total No. of Products: " + bykeTotalNoProducts);
            Console.WriteLine("Tax: " + bykeTax);
            Console.WriteLine("        ");

            Console.WriteLine("-----Product: Bus------");
            Console.WriteLine("Name: " + busName);
            Console.WriteLine("Cost: " + busCost);
            Console.WriteLine("Total No. of Products: " + busTotalNoProducts);
            Console.WriteLine("Tax: " + busTax);


            //Note: Since Total No of products is Statuc t


        }
    }
}
