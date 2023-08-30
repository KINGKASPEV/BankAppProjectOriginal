using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    internal class ListOfCustomers
    {
        public static Dictionary<string, Customer> customerList = new Dictionary<string, Customer>();
        private static HashSet<string> usedAccountNumbers = new HashSet<string>();
        public static void AddCustomer(string accountNo, Customer customer)
        {
            customerList.Add(accountNo, customer);
            usedAccountNumbers.Add(accountNo);
        }

        public static bool IsAccountNumberUsed(string accountNo)
        {
            return usedAccountNumbers.Contains(accountNo);
        }
    }
}
