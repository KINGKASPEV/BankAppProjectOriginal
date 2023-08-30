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
        public static void UserDeposit(double amount)
        {
            Transactions transactions = new Transactions();
            transactions.Deposit(amount);
        }
        public static void UserWithdrwal(double amount)
        {
            Transactions transactions = new Transactions();
            transactions.Withdraw(amount);
        }
        public static void UserTransfer()
        {
            Transactions transactions = new Transactions();
            transactions.Transfer();
        }
        public static void UserBalance()
        {
            Transactions transactions = new Transactions();
            transactions.CheckBalance();
        }
        public static void StatementOfAccount()
        {
            Transactions transactions = new Transactions();
            transactions.GetStatementOfAccount();
        }
        public static void UserNote()
        {
            Transactions transactions = new Transactions();
            transactions.GetNote();
        }
        public static void UserLogout()
        {
            Transactions transactions = new Transactions();
            transactions.Logout();
        }
    }
}

