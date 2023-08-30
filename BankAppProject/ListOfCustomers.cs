using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    internal class ListOfCustomers
    {
        public string Email { get; private set; }

        public static Dictionary<string, Customer> customerList = new Dictionary<string, Customer>();
        private static HashSet<string> usedEmails = new HashSet<string>();
        public static void AddCustomer(Customer customer)
        {
            customerList.Add(customer.Email, customer);
            usedEmails.Add(customer.Email);
        }

        public static bool IsEmailUsed(string email)
        {
            return usedEmails.Contains(email);
        }
    }
}
