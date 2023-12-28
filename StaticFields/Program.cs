using System;

namespace StaticFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To Access Instance Fields we need to create an object first. Otherwise it will not accessible
            //Object
            Bank bank = new Bank();
            //Fields
            var accountName = bank.Accountname;
            var accountNumber = bank.AccountNo;
            var ifscCode = bank.IfscCode;
            Console.WriteLine("Account Holder Name: " + accountName);
            Console.WriteLine("Account Number: " + accountNumber);
            Console.WriteLine("Ifsc Code: " + ifscCode);

            //To access Static fields we dont need to create an object. We can directly access static field in the class.

            var bankname = Bank.BankName;
            Console.WriteLine("Name of the Bank: " + bankname);




        }
    }
}
