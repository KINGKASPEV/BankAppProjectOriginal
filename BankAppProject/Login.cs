using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    internal class Login
    {
        public static void LoginUser()
        {
            Console.WriteLine("Enter your Account Number: ");
            string accountNo = Console.ReadLine();

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            if (accountNo == null || password == null) 
            {
                Console.WriteLine("All fields are required. Try again");
                return;
                //LoginUser();
            }
            else
            {
                var getCustomerList = ListOfCustomers.customerList;
                bool found = false;
                foreach (var item in getCustomerList)
                {
                    if(item.Key==accountNo)
                    {
                        Customer customer = item.Value;
                        string passwd=customer.GetPassword();

                        if(password==passwd)
                        {
                            found = true;
                        }
                    }
                }
                if (found) 
                {
                    Logged.loggedAccount = accountNo;

                }
                else
                {
                    Console.WriteLine("Invalid login Details. Try again");
                    LoginUser();
                }
            }
        }
    }
}
