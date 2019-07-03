using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class CheckingAccount : Account
    {
        private double minBalance;
        private double maxBalance;


        
        public double MinBalance
        { get { return this.minBalance; } }

        public double MaxBalance
        { get { return this.maxBalance; } }


        

        public CheckingAccount(double balance) 
        {
            this.minBalance = 500;
            this.maxBalance = 1000000;
            this.balance = balance;
            accountType = "Checking Account";
        }

        
    }
}

    

