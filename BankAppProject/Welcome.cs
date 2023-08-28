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
            while (true)
            {
                Console.WriteLine("WELCOME TO MY BANKING SYSTEM");
                Console.WriteLine("Press 1 to create Account\nPress 2 to Login");
                Console.WriteLine("Press 3 to deposit\nPress 4 to withdraw");
                Console.WriteLine("Press 5 to transfer\nPress 6 to check balance");
                Console.WriteLine("Press 7 to print account statement\nPress 8 to exit");
                //Console.Clear();

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Functions.CreateUserAccount();
                        break;
                    case "2":
                        Functions.LoginCustomer();
                        break;
                    case "3":
                        Functions.UserDeposit(double.Parse(input)); 
                        break;
                    case "4":
                        Functions.UserWithdrwal(double.Parse(input));
                        break;
                    case "5":
                        Functions.UserTransfer();
                        break;
                    case "6":
                        Functions.UserBalance();
                        break;
                    case "7":
                        Functions.StatementOfAccount();
                        break;
                    case "8":
                        Console.WriteLine("Exiting the application...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }
            }
        }
    }
}
