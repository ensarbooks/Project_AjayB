using System;

namespace Enumeration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Object
            Person person = new Person();

            //Initialising values to fields
            person.Name = "Ajay Reddy";
            person.Gender = "Male";
            person.Age = 26;
            person.AgeGroup = AgeGroupEnum.adult;

            //Printing fields

            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Gender: " + person.Gender);
            Console.WriteLine("Age: " + person.Age);
            Console.WriteLine("Age Group string: " + person.AgeGroup);

            // Getting Strings & Values of Enum
            foreach (string s in Enum.GetNames(typeof(AgeGroupEnum))) 
                Console.WriteLine("String in AgeGroupEnum: " + s);

            foreach (int i in Enum.GetValues(typeof(AgeGroupEnum)))
                Console.WriteLine("Values in AgeGroupEnum: " + i);

            
        }
    }
}
