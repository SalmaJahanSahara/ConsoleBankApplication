using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankApplication
{
    class SavingsAccount:Account
    {
        private double interestRate;

        public double InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }
        public void showInformationSA()
        {
            Console.WriteLine("Account No:{0}\nBalance:{1}\nInterestRate:{2}", this.accountNumber, this.balance, this.interestRate);
            Console.WriteLine();
        }
    }
}
