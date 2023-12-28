using System;

namespace Structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Objects for a structure
            Vehicle car = new Vehicle(1, "Hyundai i20", "Car"); // We can create object with New keyword same like class
            Vehicle byke; // We can also create object without New keyword in structures. But we cannot Intialise fields

            var carName = car.VehicleName;
            var carDetails = car.GetVehicleDetails();

            Console.WriteLine("Car Name: " + carName);
            Console.WriteLine("Car Details: " + carDetails);


        }
    }
}
