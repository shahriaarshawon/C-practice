using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class CurrentBalance : Accounts
    {
        private double amount;

        internal double Amount
        {
            get { return this.amount; }
            set
            {
                if (value >= 0)
                    this.amount = value;
                else
                    this.amount = -1;
            }
        }

        public void Deposite(double amount)
        {
            if (amount >= 0 && amount <= 100000000000)
            {
                Console.WriteLine("{0}", " Deposited ");
            }
            else
            {
                Console.WriteLine("{0}", " Not Applicable ");
            }
        }

        public void WithDraw(double amount)
        {
            if (amount >= 500 && amount <= 1000000)
            {
                Console.WriteLine("{0}", " WithDraw Succeed ");
            }
            else
            {
                Console.WriteLine("{0}", " Not Applicable ");
            }
        }


        internal CurrentBalance(int id, string name, double balance, double amount)
            : base(id, name, balance)
        {
            this.Amount = amount;
        }

        internal override void ShowDetails()
        {
            
            //Console.WriteLine("Id: {0}", this.Id);
            //Console.WriteLine("Name: {0}", this.Name);
            
            Console.WriteLine("Deposite: {0}", this.Amount);
            Console.WriteLine("WithDraw: {0}", this.Amount);

        }
    }
}
