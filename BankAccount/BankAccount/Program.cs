using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2019,10,01);
            Console.WriteLine(d.ToString("d"));
            Accounts a1 = new Accounts(100, "Bruce", 100000);
            a1.Id = 101;
            a1.Name = "Clerk";
            a1.Balance = 10000;

            Accounts a2 = new Accounts(100, "Bruce", 100000);
            a2.Id = 102;
            a2.Name = "Stark";
            a2.Balance = 20000;
            

            a1.ShowDetails();
            a2.ShowDetails();

            /*Accounts[3] accounts = new Accounts[2];
            accounts[0] = new Accounts();
            accounts[1] = new CurrentBalance();
            accounts[2] = new SavingsAccount(100, "Bruce", 100000);*/

            
           

        }
    }
}