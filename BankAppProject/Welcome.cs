using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    internal class Welcome
    {
        public void WelcomeCustomer()
        {
            while (true)
            {
                Console.WriteLine("****************************************************");
                Console.WriteLine("         WELCOME TO DEROYALS BANKING SYSTEM               ");
                Console.WriteLine("****************************************************");
                Console.WriteLine("We're here to help you manage your finances.");
                Console.WriteLine("Choose an option from the menu below:");
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.WriteLine("----------------------------------------------------");
                //Console.Clear();

                string input = Console.ReadLine()?.Trim().ToLower();    
                Console.WriteLine();

                switch (input)
                {
                    case "1":
                        Functions.CreateUserAccount();
                        break;
                    case "2":
                        Functions.LoginCustomer();
                        HandleLoggedInUser();
                        break;
                    case "3":
                        Console.WriteLine("Thank you for using our banking system. Have a great day!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void HandleLoggedInUser()
        {
            if (Logged.loggedAccount != null)
            {
                while (true)
                {
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Welcome, " + ListOfCustomers.customerList[Logged.loggedAccount].GetFirstname());
                    Console.WriteLine("----------------------------------------------------");
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Transfer");
                    Console.WriteLine("4. Check Balance");
                    Console.WriteLine("5. Print Account Statement");
                    Console.WriteLine("6. Logout");
                    Console.WriteLine("----------------------------------------------------");
                    //Console.Clear();

                    string input = Console.ReadLine();
                    Console.WriteLine();

                    switch (input)
                    {
                        case "1":
                            Functions.UserDeposit(double.Parse(input));
                            break;
                        case "2":
                            Functions.UserWithdrwal(double.Parse(input));
                            break;
                        case "3":
                            Functions.UserTransfer();
                            break;
                        case "4":
                            Functions.UserBalance();
                            break;
                        case "5":
                            Functions.StatementOfAccount();
                            break;
                        case "6":
                            Functions.UserLogout();
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid option.");
                            break;
                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("You are not logged in.");
            }
        }
    }
}
