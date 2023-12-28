using System;

namespace ConstantFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To access Constant we don't need to create an object

            var collegeName = College.CollegeName; //Static field
            var address = College.Address; //Constant Field
                       
            Console.WriteLine(collegeName);
            Console.WriteLine(address);

            //Local field

            const int pincode = 524002; // We cannot change this value in another constants.
            Console.WriteLine("Pincode: " + pincode);

        }
    }
}
