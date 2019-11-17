using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
   
    internal class Accounts
    {

        private int id;
        private string name;
        private double balance;
        

        internal int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        internal string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        internal double Balance
        {
            get { return this.balance; }
            set
            {
                if (value >= 0 && value <= 10000000000000)
                    this.balance = value;
                else
                    this.balance = -1;
            }
        }

        internal Accounts()
        {
            //Console.WriteLine("Default of Accounts");
        }
        

        internal Accounts(int id, string name, double balance)
        {
            this.Id = id;
            this.Name = name;
            this.Balance = balance;
        }

       

        internal virtual void ShowDetails()
        {
            
            Console.WriteLine("Id: {0}", this.Id);
            Console.WriteLine("Name: {0}", this.Name);
            Console.WriteLine("Balance: {0}", this.Balance);

        }

    }
}
