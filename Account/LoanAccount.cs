using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class LoanAccount : Account
    {
        
        private int interest;
        public int Interest
        {
            get { return this.interest; }
        }
        
       
        public LoanAccount(double balance) : base()
        {
            interest = 10;
            this.balance = balance;
            accountType = "Loan Account";

        }
    }
}
