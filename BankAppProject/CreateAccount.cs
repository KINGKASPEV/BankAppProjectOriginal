using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    internal class CreateAccount
    {
        public static void CreateCustomerAccount()
        {
            Console.WriteLine("Enter your Firstname: ");
            string firstname  = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter your Lastname: ");
            string lastname = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter your Phone Number: ");
            string phoneNumber = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter your Email: ");
            string email = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Enter your Password: ");
            string password = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What type of account do you want?\nPress S for Savings and C for Current: ");
            string acctype = Console.ReadLine();
            Console.Clear();
            string accounttype = " ";

            if (acctype == "S")
            {
                accounttype = "SAVINGS";
            }
            if (acctype == "S")
            {
                accounttype = "SAVINGS";
            }

            Customer customer = new Customer(firstname, lastname, phoneNumber, email, accounttype, password);
            string accountNumber = AccountNoGenerator.GenerateNewAccountNumber();

            ListOfCustomers.AddCustomer(accountNumber, customer);
            Console.WriteLine("Account created successfully. Your account number is :" + accountNumber);
        }
    }
}
