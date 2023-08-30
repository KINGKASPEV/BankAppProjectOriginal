using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankAppProject
{
    internal class CreateAccount
    {
        //private const string V = "S";
        public static void CreateCustomerAccount()
        {
            string accountNumber= AccountNoGenerator.GenerateNewAccountNumber();

            string firstname = GetValidName("Enter your Firstname: ");
            string lastname = GetValidName("Enter your Lastname: ");
            Console.Clear();

            string phoneNumber = GetValidPhoneNumber();
            string note = "";

            string email = GetValidEmail();

            string password = GetValidPassword();

            Console.WriteLine("What type of account do you want?\nPress S for Savings and C for Current: ");
            string acctype = Console.ReadLine();
            string accounttype = " ";

            if (acctype == "S")
            {
                accounttype = "SAVINGS";
            }
            else if (acctype == "C")
            {
                accounttype = "CURRENT";
            }
            else
            {
                Console.WriteLine("invalid account type. Please select S for Savings or C for Current.");
                return;
            }
            Customer customer;
            if (accounttype == "SAVINGS")
            {
                //double initialBalance = 1000;
                customer = new Customer(firstname, lastname, phoneNumber, email, accounttype, accountNumber, password, note);
            }
            else if (accounttype == "CURRENT")
            {
                customer = new Customer(firstname, lastname, phoneNumber, email, accounttype,accountNumber, password, note);
            }
            else
            {
                Console.WriteLine("Invalid account type. Please select S for Savings or  C for Current.");
                return;
            }

              //accountNumber = AccountNoGenerator.GenerateNewAccountNumber();
        
            ListOfCustomers.AddCustomer(accountNumber, customer);
            Console.WriteLine("Account created successfully. Your account number is :" + accountNumber);
            string GetValidEmail()
            {
                string email1;
                while (true)
                {
                    Console.WriteLine("Enter your Email: ");
                    email1 = Console.ReadLine();

                    if (IsValidEmail(email1))
                    {
                        return email1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid email format. Please enter a valid email.");
                    }
                }
            }

             bool IsValidEmail(string email1)
            {
                // Use regular expression pattern to validate email format
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                return Regex.IsMatch(email1, pattern);
            }
             string GetValidPassword()
            {
                string password1;
                while (true)
                {
                    Console.WriteLine("Enter your Password: ");
                    password1 = Console.ReadLine();

                    if (IsValidPassword(password1))
                    {
                        return password1;
                    }
                    else
                    {
                        Console.WriteLine("Invalid password format. Please enter a password with at least 6 characters including at least one special character (@, #, $, %, ^, &, !).");
                    }
                }
            }

             bool IsValidPassword(string password1)
            {
                // Use regular expression pattern to validate password format
                string pattern = @"^(?=.*[A-Za-z0-9])(?=.*[@#$%^&!]).{6,}$";
                return Regex.IsMatch(password1, pattern);
            }
             string GetValidName(string prompt)
            {
                string name;
                while (true)
                {
                    Console.WriteLine(prompt);
                    name = Console.ReadLine();

                    if (IsValidName(name))
                    {
                        return name;
                    }
                    else
                    {
                        Console.WriteLine("Invalid name format. Name should not start with a digit or a lowercase letter.");
                    }
                }
            }

             bool IsValidName(string name)
            {
                // Use regular expression pattern to validate name format
                string pattern = @"^[A-Z][A-Za-z]*$";
                return Regex.IsMatch(name, pattern);
            }
             string GetValidPhoneNumber()
            {
                //string phoneNumber1;
                while (true)
                {
                    Console.WriteLine("Enter your Phone Number: ");
                    phoneNumber = Console.ReadLine();

                    if (IsValidPhoneNumber(phoneNumber))
                    {
                        return phoneNumber;
                    }
                    else
                    {
                        Console.WriteLine("Invalid phone number format. Phone number should not include alphabetic characters.");
                    }
                }
            }

             bool IsValidPhoneNumber(string phoneNumber1)
            {
                // Use regular expression pattern to validate phone number format
                string pattern = @"^[0-9]+$";
                return Regex.IsMatch(phoneNumber, pattern);
            }
        }
    }
}
