using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Object for Employee
            var employee = new Employee(); // Parent Class
            var manager = new Manager(); // Child Class
            var salesMan = new Salesman(); // Child class

            //Initialising fileds for  Employee
            employee.EmpName = "Ajay Reddy";
            employee.EmpId = 1;
            employee.Location = "Hyderabad";

            //Initialising fields for Manager
            manager.DepartmentName = "Sales"; // Manager class field
            manager.EmpName = "K. mahesh Kumar"; // Employee class field
            employee.EmpId = 2; // Employee class field
            employee.Location = "Nellore"; // Employee class field
            var totalSales = manager.GetTotalSalesValue();

            //Initialising fields for Sales Man
            salesMan.EmpName = "K. Hima Bindu"; // Employee class field
            salesMan.EmpId = 3; // Employee class field
            salesMan.Location = "Vizag"; // Employee class field
            var MonthlySales = salesMan.GetSalesforCurrentMonth();
            salesMan.Region = "North"; // Sales Man class field

            Console.WriteLine("Employee details");
            Console.WriteLine("Name: " + employee.EmpName);
            Console.WriteLine("ID: " + employee.EmpId);
            Console.WriteLine("Location: " + employee.Location);

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




        }
    }
}
