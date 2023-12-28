using System;

namespace Fields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Instance Fields
            //To Access Instance Fields we need to create an object first. Otherwise it will not accessible

            i20 car1 = new i20();
            MahindraXUV700 car2 = new MahindraXUV700();
            Verna car3 = new Verna();
            
            //Car1
            var name = car1.Name;
            var model = car1.Model;
            var version = car1.version;
            var sunRoof = car1.Sunroof;

            Console.WriteLine("Car:1 Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Version: " + version);
            Console.WriteLine("Does it has Sunroof: " + sunRoof);


            //Car2
            name = car2.Name;
            model = car2.Model;
            version = car2.version;
            sunRoof = car2.Sunroof;

            Console.WriteLine("Car:2 Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Version: " + version);
            Console.WriteLine("Does it has Sunroof: " + sunRoof);


            //Car3
            name = car3.Name;
            model = car3.Model;
            version = car3.version;
            sunRoof = car3.Sunroof;

            Console.WriteLine("Car:3 Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Version: " + version);
            Console.WriteLine("Does it has Sunroof: " + sunRoof);



            //Static Fields
            //To access Static fields we dont need to create an object. We can directly access static field in the class.
            var bankname = Bank.BankName;
            Console.WriteLine("Name of the Bank: " + bankname);


            //Constant Fields
            //To access Constant we don't need to create an object
            var collegeName = College.CollegeName; //Static field
            var address = College.Address; //Constant Field

            Console.WriteLine(collegeName);
            Console.WriteLine(address);


            //Local field
            const int pincode = 524002; // We cannot change this value in another constants.
            Console.WriteLine("Pincode: " + pincode);

            //Readonly FIeld

            //To access an Readonly Field we must need to create an object
            //Readonly Field once Intialised and the value cannot be changed.

            Restraunt restraunt = new Restraunt();

            var restrauntname = restraunt.RestrauuntName;
            Console.WriteLine("Name of the Restraunt: " + restrauntname);   
        }
    }
}
