using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankApplication
{
    class Bank
    {
        private string bankName;
        private Customer[] customers;

        public Bank(string name, int size)
        {
            this.bankName = name;
            customers = new Customer[size];
        }
        public string BankName
        {
            set { this.bankName = value; }
            get { return this.bankName; }
        }
        public Customer[] Customers //returning the array
        {
            set { this.customers = value; }
            get { return this.customers; }
        }
    }
}
