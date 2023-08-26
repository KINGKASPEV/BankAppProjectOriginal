using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    internal class Functions
    {
        public static void LoginCustomer() 
        {
            Login.LoginUser();
        }
        public static void CreateUserAccount()
        {
            CreateAccount.CreateCustomerAccount();
        }
    }
}
