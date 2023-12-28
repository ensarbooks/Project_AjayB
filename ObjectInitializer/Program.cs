using System;

namespace ObjectInitializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object Intitialiazer is used, when we want to initialize only certain fields which has no constructor.

            var Employee = new Employee()
            {
                EmpId = 101,
                Job = "Software Engineer"
            };

            Console.Write("Emplyee Id: " + Employee.EmpId + " Job: " + Employee.Job);
        }
    }
}
