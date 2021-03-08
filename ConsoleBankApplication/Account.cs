using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankApplication
{
    public class Account
    {
        protected int accountNumber;
        protected double balance;
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Previous Balance:	" + balance);
                Console.WriteLine("Withdraw Amount:	" + amount);
                this.balance = this.balance - amount;
                Console.WriteLine("Current Balance:	" + balance);
            }
            else
            {
                Console.WriteLine("Can Not Withdraw");
            }   
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Previous Balance: " + balance);
                Console.WriteLine("Deposit Amount: " + amount);
                this.balance = this.balance + amount;
                Console.WriteLine("Current Balance: " + balance);
            }
            else
            {
                Console.WriteLine("Can Not Deposit");
            }
        }
        public void Transfer(double amount, Account receiver)
        {
            if (amount > 0 && amount <= balance)
            {
                Console.WriteLine("Previous Balance:	" + this.balance);
                Console.WriteLine("Transfer Amount:	" + amount);
                this.balance = this.balance - amount;
                receiver.balance = receiver.balance + amount;
                Console.WriteLine("Current Balance:	" + this.balance);
            }
            else
            {
                Console.WriteLine("Can Not Transfer");
            }
        }

        public void ShowAccountInformation()
        { 
            Console.WriteLine("Account No:{0}\nBalance:{1}", this.accountNumber, this.balance);
        }

    }
}
