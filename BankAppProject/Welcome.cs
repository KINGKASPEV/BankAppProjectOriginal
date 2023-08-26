using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    internal class Welcome
    {
        public void welcomeCustomer()
        {
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<<WELCOME TO .NET BANKING SYSTEM>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Press 1 to create Account\nPress 2 to Login");
            Console.WriteLine("Press 3 to deposit\nPress 4 to withdraw");
            Console.WriteLine("Press 5 to transfer\nPress 6 to print account statement");
            Console.WriteLine("Press 7 to check balance\nPress 8 to exit");

           string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    Functions.CreateUserAccount();
                break;
                case "2":
                    Functions.LoginCustomer();
                    break;
            }
        }
    }
}
