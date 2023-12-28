using Fields;
using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating objects
            Product car1 = new Product();
            Product car2 = new Product();
            Product car3 = new Product();


            //Intialising Fields
            //Car1
            car1.Name = "Hyundai i20";
            car1.cost = 950000;
            car1.version = "Top End";
            car1.Sunroof = false;
            car1.Model = 2019;
            //Car2
            car2.Name = "Hyundai Verna";
            car2.cost = 1500000;
            car2.version = "Middle";
            car2.Sunroof = false;
            car2.Model = 2022;
            //Car3
            car3.Name = "Mahindra XUV 300";
            car3.cost = 2300000;
            car3.version = "Top End";
            car3.Sunroof = true;
            car3.Model = 2023;

            //Invoking Tax Method and assigning value for tax
            car1.GetTax(); 
            car2.GetTax();
            car3.GetTax();

            var car1Tax = car1.tax;
            var car2Tax = car2.tax;
            var car3Tax = car3.tax;

            Console.WriteLine("Car1 Tax: " + car1Tax );
            Console.WriteLine("Car2 Tax: " + car2Tax);
            Console.WriteLine("Car3 Tax: " + car3Tax);





        }
    }
}
