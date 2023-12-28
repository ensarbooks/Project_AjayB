using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Creating Objects
            //var employee = new Employee(); // Parent Class - We cannot create an Object for Interface
            var manager = new Manager(); // Child Class
            var salesMan = new Salesman(); // Child class


            //Initialising fields for Manager
            manager.EmpName = "K. mahesh Kumar"; // Employee class field
            manager.EmpId = 2; // Employee class field
            manager.Location = "Nellore"; // Employee class field

            //Initialising fields for Sales Man
            salesMan.EmpName = "K. Hima Bindu"; // Employee class field
            salesMan.EmpId = 3; // Employee class field
            salesMan.Location = "Vizag"; // Employee class field

            //Calling child class method's
            var managerEmployes = manager.GetTotalNoOfEmployees();
            var salesEmployes = salesMan.GetTotalNoOfEmployees();

            Console.WriteLine("Manager details");
            Console.WriteLine("Name: " + manager.EmpName);
            Console.WriteLine("ID: " + manager.EmpId);
            Console.WriteLine("Location: " + manager.Location);


            Console.WriteLine("SalesMan details");
            Console.WriteLine("Name: " + salesMan.EmpName);
            Console.WriteLine("ID: " + salesMan.EmpId);
            Console.WriteLine("Location: " + salesMan.Location);


            Console.WriteLine("Manager Employes: " + managerEmployes);
            Console.WriteLine("Sales Employes: " + salesEmployes);
        }
    }
}
