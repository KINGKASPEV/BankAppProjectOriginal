using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    internal class Transactions
    {
        string accountNumber = Logged.loggedAccount;
        Dictionary<string, Customer> customerList = ListOfCustomers.customerList;

        public void Deposit(double amount)
        {
            if (accountNumber == "" || accountNumber == null)
            {
                Console.WriteLine("Please login first");
                Functions.LoginCustomer();
            }
            else
            {
                Console.WriteLine("Enter the amount you want to deposit");
                amount = Convert.ToDouble(Console.ReadLine());
                if (amount > 0)
                {
                    foreach (var item in customerList)
                    {
                        if (item.Key == accountNumber)
                        {
                            Customer customer = item.Value;
                            customer.Deposit(amount);
                            Console.WriteLine("Deposit Successfully.");
                            break;
                        }
                    }
                }
            }
        }
        public void Withdraw(double amount)
        {
            if (accountNumber == "" || accountNumber == null)
            {
                Console.WriteLine("Please login first");
                Functions.LoginCustomer();
            }
            else
            {
                Console.WriteLine("Enter the amount you want to withdraw");
                amount = Convert.ToDouble(Console.ReadLine());
                if (amount > 0)
                {
                    foreach (var item in customerList)
                    {
                        if (item.Key == accountNumber)
                        {
                            Customer customer = item.Value;
                            if (customer.balance >= amount)
                            {
                                customer.Withdraw(amount);
                                Console.WriteLine("Withdrawal Successful.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance.");
                            }
                            break;
                        }
                    }
                }
            }
        }
        public void Transfer() 
        {
            Console.WriteLine("Enter recipient's account number: ");
            string recipientAccountNumber = Console.ReadLine();

            if (accountNumber == "" || accountNumber == null)
            {
                Console.WriteLine("Please login first");
                Functions.LoginCustomer();
            }
            else
            {
                Console.WriteLine("Enter the amount you want to transfer: ");
                double amount = Convert.ToDouble(Console.ReadLine());

                if (amount > 0)
                {
                    foreach (var item in customerList)
                    {
                        if (item.Key == accountNumber)
                        {
                            Customer senderCustomer = item.Value;
                            if (senderCustomer.balance >= amount)
                            {
                                Customer recipientCustomer;
                                if (customerList.TryGetValue(recipientAccountNumber, out recipientCustomer))
                                {
                                    senderCustomer.Withdraw(amount);
                                    recipientCustomer.Deposit(amount);
                                    Console.WriteLine("Transfer Successful.");
                                }
                                else
                                {
                                    Console.WriteLine("Recipient's account not found.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Insufficient balance.");
                            }
                            break;
                        }
                    }
                }
            }

        }
        public void CheckBalance()
        {
            if (accountNumber == "" || accountNumber == null)
            {
                Console.WriteLine("Please login first");
                Functions.LoginCustomer();
            }
            else
            {
                foreach (var item in customerList)
                {
                    if (item.Key == accountNumber)
                    {
                        Customer customer = item.Value;
                        Console.WriteLine($"Your balance is: {customer.balance}");
                        break;
                    }
                }
            }
        }
        public void GetStatementOfAccount()
        {
            if (accountNumber == "" || accountNumber == null)
            {
                Console.WriteLine("Please login first");
                Functions.LoginCustomer();
            }
            else
            {
                Console.WriteLine("||===================||===============================||==========================||=====================||==========||");
                Console.WriteLine("|| FULL NAME         || ACCOUNT NUMBER                || ACCOUNT TYPE             || AMOUNT BAL          || NOTE     ||");
                Console.WriteLine("||===================||===============================||==========================||=====================||==========||");

                foreach (var item in customerList)
                {
                    if (item.Key == accountNumber)
                    {
                        Customer customer = item.Value;
                        Console.WriteLine($"|| {customer.GetFirstname()} {customer.GetLastname()} || {customer.GetAccountNumber()} || {customer.GetAccountType()} || {customer.balance.ToString("N2")} || ... ||");
                        Console.WriteLine("||==============================================================================================================||");
                        break;
                    }
                }
            }
        }
    }
}
