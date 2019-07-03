using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Account
    {
        
        public string firstName;
        private string lastName;

        public double accountNumber;
        public string accountType;

        protected double balance;
        protected double deposit;
        protected double withdrawal;

       
        public string AccountType
        { get { return this.accountType; } }

        public double Withdrawal
        {
            get { return this.withdrawal; }
            set { this.withdrawal = value; }
        }
        public double Deposit
        {
            get { return this.deposit; }
            set { this.deposit = value; }
        }
        public double AccountNumber
        { get { return this.accountNumber; } }

        public double Bal
        { get { return this.balance; } }

        
        public Account()
        {
            firstName = "Armel";
            lastName = "Nikiema";
        }

        public virtual double Balance()
        {
            balance = balance + deposit - withdrawal;
            
            return balance;
        }
        
        public  double DepositBalance(double input)
        {
            deposit = input;
         
            balance = balance + deposit;
            return balance;
        }

        
        public virtual double WithBalance(double input)
        {
            withdrawal = input;

            balance = balance - withdrawal;
            return balance;
        }

        
        public  void DisplayMenu()
        {
            Console.WriteLine("Bank Application: " + firstName + " " + lastName);
            Console.WriteLine("Your Account Number:" + accountNumber);
            Console.WriteLine("Action Menu: ");
            Console.WriteLine("1.View Client");
            Console.WriteLine("2.View Account Balance:");
            Console.WriteLine("3.Loan Balance");
            Console.WriteLine("4.Deposit");
            Console.WriteLine("5.Loan");
            Console.WriteLine("6.Deposit" );
            Console.WriteLine("7.Withdraw");
            Console.WriteLine("8.Exit");
        }
        
        public string ClientInfo()
        {
            string clientinfo = ("Account Holder: " + firstName + " " + lastName);
            return clientinfo;
        }
    }
}


