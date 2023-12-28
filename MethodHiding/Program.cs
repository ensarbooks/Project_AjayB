using System;

namespace MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Object for Employee
            var employee = new Employee(); // Parent Class
            var manager = new Manager(); // Child Class

            var parentEmployees = employee.GetTotalEmployees();
            var childEmployees = manager.GetTotalEmployees();
            
            
            Console.WriteLine("Parent method count: " + parentEmployees);
            Console.WriteLine("Child method count: " + childEmployees);
           
        }
    }
}
