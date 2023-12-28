using System;

namespace ConstructorInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Object for Employee
            var employee = new Employee(1, "Ajay Reddy", "Hyderabad"); // Parent Class
            var manager = new Manager(2, "K. Mahesh kumar", "Hyderabad", "Sales"); // Child Class
            var salesMan = new Salesman(3, "K. Hima Bindu", "Nellore", "North"); // Child class

            var totalSales = manager.GetTotalSalesValue();
            var MonthlySales = salesMan.GetSalesforCurrentMonth();
         

            Console.WriteLine("Employee details");
            Console.WriteLine("Name: " + employee.EmpName);
            Console.WriteLine("ID: " + employee.EmpId);
            Console.WriteLine("Location: " + employee.Location);

            Console.WriteLine("Manager details");
            Console.WriteLine("Name: " + manager.EmpName);
            Console.WriteLine("ID: " + manager.EmpId);
            Console.WriteLine("Location: " + manager.Location);
            Console.WriteLine("Department: " + manager.DepartmentName);
            Console.WriteLine("Total Sales: " + totalSales);


            Console.WriteLine("SalesMan details");
            Console.WriteLine("Name: " + salesMan.EmpName);
            Console.WriteLine("ID: " + salesMan.EmpId);
            Console.WriteLine("Location: " + salesMan.Location);
            Console.WriteLine("Region: " + salesMan.Region);
            Console.WriteLine("Monthly Sales: " + MonthlySales);

        }
    }
}
