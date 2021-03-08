using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankApplication
{
    class Tansaction
    {
        public void Withdraw(double amount);
        public void Deposit(double amount);
        public void Transfer(double amount, Account receiver);
    }
}
