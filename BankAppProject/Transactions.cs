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
        public void Withdraw()
        {

        }
        public void Transfer() 
        {
            
        }
        public void CheckBalance()
        {

        }
        public void GetStatementOfAccount()
        {

        }
    }
}
