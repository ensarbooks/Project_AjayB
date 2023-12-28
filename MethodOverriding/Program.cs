using System;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating Object for Employee
            var employee = new Employee(); // Parent Class
            var manager = new Manager(); // Child Class

            var childEmployees = manager.GetTotalEmployees();


            
            Console.WriteLine("Child Class: " + childEmployees);
        }
    }
}
