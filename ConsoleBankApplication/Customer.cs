using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBankApplication
{
    class Customer
    {
        private string customerName;
        private string dateOfBirth;
        private Address address;
        private Account[] accounts;

        public Customer(string customerName, string dateOfBirth, Address address, int size)
        {
            this.customerName = customerName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            accounts = new Account[size];
        }

        public string CustomerName
        {
            set { this.customerName = value; }
            get { return this.customerName; }
        }
        public string DateOfBirth
        {
            set { this.dateOfBirth = value; }
            get { return this.dateOfBirth; }
        }
        public Address Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public Account[] Accounts //returning the array
        {
            set { this.accounts = value; }
            get { return this.accounts; }
        }
        public void PrintAccountDetails()
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    continue;
                }
                accounts[i].ShowAccountInformation();
            }
        }
        public void OpenAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }    
    }
}
