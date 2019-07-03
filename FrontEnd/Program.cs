using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using System.IO;

namespace FrontEnd
{
    class Program
    {
        static void Main(string[] args)
        {

            Account client = new Account();

            CheckingAccount checking = new CheckingAccount(0);
            
            
            LoanAccount loan = new LoanAccount(0);
            

            
            string streamcheckingaccount = ("Account Number: " + checking.accountNumber);
            
            string loanaccount = ("Account Number: " + loan.accountNumber);
            string streamclientinfo = (client.ClientInfo());
            string checkingaccounttype = (checking.AccountType);
            
            string loanaccounttype = (loan.AccountType);

            using (StreamWriter checkingsummary = new StreamWriter("CheckingSummary.txt", true))
            {
                checkingsummary.WriteLine(checkingaccounttype);
                checkingsummary.WriteLine(streamclientinfo);
                checkingsummary.WriteLine(streamcheckingaccount);

            }
            
            using (StreamWriter loansummary = new StreamWriter("LoanSummary.txt", true))
            {
                loansummary.WriteLine(loanaccounttype);
                loansummary.WriteLine(streamclientinfo);
                loansummary.WriteLine(streamcheckingaccount);
            }

            bool test = false;

            do
            {
                
                string checkingDepositPara = ($"Transaction: +${checking.Deposit} at {DateTime.Now.ToString()} Current Balance: ${checking.Bal}");
                string checkingWithdrawalPara = ($"Transaction: -${checking.Withdrawal} at {DateTime.Now.ToString()} Current Balance: ${checking.Bal}");
               
                string loanDepositPara = ($"Transaction: +${loan.Deposit} at {DateTime.Now.ToString()} Current Balance: ${loan.Bal}");
                string loanWithdrawalPara = ($"Transaction: -${loan.Withdrawal} at {DateTime.Now.ToString()} Current Balance: ${loan.Bal}");

                
                using (StreamWriter checkingAccountStreamSummary = new StreamWriter("CheckingSummary.txt", true))
                {
                    if (checking.Deposit > 0)
                    {
                        checkingAccountStreamSummary.WriteLine(checkingDepositPara);
                        checking.Deposit = 0;
                    }
                    if (checking.Withdrawal > 0)
                    {
                        checkingAccountStreamSummary.WriteLine(checkingWithdrawalPara);
                        checking.Withdrawal = 0;
                    }
                }
                
                
                using (StreamWriter loanAccountStreamSummary = new StreamWriter("SavingsSummary.txt", true))
                {
                    if (loan.Deposit > 0)
                    {
                        loanAccountStreamSummary.WriteLine(loanDepositPara);
                        loan.Deposit = 0;
                    }
                    if (loan.Withdrawal > 0)
                    {
                        loanAccountStreamSummary.WriteLine(loanWithdrawalPara);
                        loan.Withdrawal = 0;
                    }
                }
                

                Console.WriteLine("Tap Enter to Display Banking Menu");
                Console.ReadLine();

                client.DisplayMenu();
                string userchoice = Console.ReadLine();

                switch (userchoice.ToUpper())
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(client.ClientInfo());
                        break;
                    case "2":
                        Console.Clear();
                        checking.Balance();
                        Console.WriteLine("Checking Account Balance: $" + checking.Bal);
                        break;
                   
                    case "3":
                        Console.Clear();
                        loan.Balance();
                        Console.WriteLine("Loan Account Balance: $" + loan.Bal);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Deposit Amount: ");
                        checking.Deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: $" + checking.Deposit);
                        checking.DepositBalance(checking.Deposit);
                        break;
                   
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Loan Amount:");
                        loan.Deposit = double.Parse(Console.ReadLine());
                        Console.WriteLine("You deposited: $" + loan.Deposit);
                        loan.DepositBalance(loan.Deposit);
                        break;
                    case "6":
                        Console.Clear();
                        Console.WriteLine("Withdrawal Amount:");
                        checking.Withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: $" + checking.Withdrawal);
                        checking.WithBalance(checking.Withdrawal);
                        break;
                   
                    case "7":
                        Console.Clear();
                        Console.WriteLine("How Much To Withdraw?");
                        loan.Withdrawal = double.Parse(Console.ReadLine());
                        Console.WriteLine("You withdrew: $" + loan.Withdrawal);
                        loan.WithBalance(loan.Withdrawal);
                        break;
                    case "8":
                        Console.Clear();
                        Console.WriteLine("Please Come Back Again");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        test = false;
                        break;
                }
            } while (!test);
        }
    }
}

