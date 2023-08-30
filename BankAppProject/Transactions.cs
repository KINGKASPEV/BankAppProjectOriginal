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
        private string note;

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
                if (accountNumber == Logged.loggedAccount)
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
                                if (customer.GetAccountType() == "SAVINGS")
                                {
                                    if (customer.balance - amount < 1000)
                                    {
                                        Console.WriteLine("Insufficient balance. You cannot withdraw below 1000 Naira for a Savings account.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Pleas provide a reason for withdrawal: ");
                                        string reason = Console.ReadLine();

                                        customer.Withdraw(amount);
                                        customer.GetNote(reason);
                                        Console.WriteLine("Withdrawal Successful.");
                                    }
                                }
                                else if (customer.GetAccountType() == "CURRENT")
                                {
                                    Console.WriteLine("Pleas provide a reason for withdrawal: ");
                                    string reason = Console.ReadLine();

                                    customer.Withdraw(amount);
                                    customer.GetNote(reason);
                                    Console.WriteLine("Withdrawal Successful.");
                                }
                                else
                                {
                                    Console.WriteLine("Invalid account type.");
                                }
                                break;
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You are not logged into this account.");
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
                                    Console.WriteLine("Please provide a reason for the transfer:");
                                    string reason = Console.ReadLine();

                                    senderCustomer.Withdraw(amount);
                                    recipientCustomer.Deposit(amount);
                                    senderCustomer.GetNote(reason);
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
                        Console.WriteLine($"|| {customer.GetFirstname()} {customer.GetLastname(), -14} || {customer.GetAccountNumber(),-29} || {customer.GetAccountType(),-24} || {customer.balance.ToString("N2"), -19} || {GetNote(), -9} ||");
                        Console.WriteLine("||===================================================================================================================||");
                        break;
                    }
                }
            }
        }

        public string GetNote()
        {
            //Console.WriteLine("Please drop a note");
            //string note 
            return note;
        }
        public void Logout()
        {
            if (accountNumber == "" || accountNumber == null)
            {
                Console.WriteLine("You are not logged in.");
            }
            else
            {
                accountNumber = ""; // Simulate logout by clearing accountNumber
                Console.WriteLine("Logged out successfully.");
            }
        }
    }
}
