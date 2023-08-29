using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BankAppProject
{
    internal class Customer
    {
        private string firstname { get; set; }
        private string lastname { get; set; }
        private string phoneNumber { get;set; }
        private string email { get; set; }
        private string accountNumber { get; set; }
        public double balance { get; set; }
        private string accountType { get; set; }
        private string password { get; set; }
        private string note { get; set; }
              
        

        public  Customer(string fname, string lname, string phone, string emil, string accountType, string password, string note)
        {
            this.firstname = fname;
            this.lastname = lname;
            this.phoneNumber = phone;
            this.email = emil;
            this.accountType = accountType;
            this.password = password;
            this.balance = 0;
            this.note = note;
        }
        public string GetFirstname()
        {
            return firstname;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            balance -= amount;
        }

        public string GetLastname() 
        {
            return lastname;
        }

        public string PhoneNumber()
        {
            return phoneNumber;
        }
        public string Email()
        {
            return email;
        }
        public string GetAccountType()
        {
            return accountType;
        }
        public void Balance()
        {
            Console.WriteLine("Current balance is " + balance);
        }
        public string GetPassword()
        {
            return password;
        }
        public string GetAccountNumber()
        {
            return accountNumber;
        }
        public string GetNote()
        {
            Console.WriteLine("Please drop a note");
            note = Console.ReadLine();
            return note;
        }
    }
}
