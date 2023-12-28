using System;

namespace AbstractClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For Abstract class is that we cannot create Objects to access Fields.
            //Creating Objects
            //var employee = new Employee(); // Parent Class - We cannot create an Object for Abstract class
            var manager = new Manager(); // Child Class
            var salesMan = new Salesman(); // Child class

            
            //Initialising fields for Manager
            manager.DepartmentName = "Sales"; // Manager class field
            manager.EmpName = "K. mahesh Kumar"; // Employee class field
            manager.EmpId = 2; // Employee class field
            manager.Location = "Nellore"; // Employee class field
            var totalSales = manager.GetTotalSalesValue(); 

            //Initialising fields for Sales Man
            salesMan.EmpName = "K. Hima Bindu"; // Employee class field
            salesMan.EmpId = 3; // Employee class field
            salesMan.Location = "Vizag"; // Employee class field
            var MonthlySales = salesMan.GetSalesforCurrentMonth(); 
            salesMan.Region = "North"; // Sales Man class field

            //Calling Child Abstract method's
            var managerEmployes = manager.GetTotalEmployees();
            var salesEmployes = salesMan.GetTotalEmployees();
            
            Console.WriteLine("Manager details");
            Console.WriteLine("Name: " + manager.EmpName);
            Console.WriteLine("ID: " + manager.EmpId);
            Console.WriteLine("Location: " + manager.Location);
            Console.WriteLine("Department: " + manager.DepartmentName);


            Console.WriteLine("SalesMan details");
            Console.WriteLine("Name: " + salesMan.EmpName);
            Console.WriteLine("ID: " + salesMan.EmpId);
            Console.WriteLine("Location: " + salesMan.Location);
            Console.WriteLine("Region: " + salesMan.Region);


            Console.WriteLine("Manager Employes: " + managerEmployes);
            Console.WriteLine("Sales Employes: " + salesEmployes);
        }
    }
}
