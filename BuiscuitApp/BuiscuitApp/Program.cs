using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuiscuitApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Buiscuit buiscuitOne = new Buiscuit();
            buiscuitOne.SetName("Cookies");
            buiscuitOne.SetCompany("Pran");
            buiscuitOne.SetUnitPrice(10);
            //buiscuitOne.SetProductionDate(10);
            //buiscuitOne.SetExpiredate(10);
            buiscuitOne.ShowInformation();


            Buiscuit buiscuitTwo = new Buiscuit("Choco Milk", "Pran", 50);
            buiscuitTwo.ShowInformation();
        }
    }
}
