using InstanceConstructors;
using System;

namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating Objects
            Employee emp1 = new Employee(1, "Ajay reddy", "Software Engineer");
            Employee emp2 = new Employee(2, "Rakesh Kumar", "Software Engineer");

            Console.WriteLine("ID: " + emp1.EmpId + ", Name: " + emp1.EmpName + ", Job: " + emp1.Job);
            Console.WriteLine("ID: " + emp2.EmpId + ", Name: " + emp2.EmpName + ", Job: " + emp2.Job);
            

        }
    }
}
