using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanInfoApp
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            OurDate dateOfBirth1 = new OurDate();
            dateOfBirth1.date = 10;
            dateOfBirth1.month = 02;
            dateOfBirth1.year = 1990;
            dateOfBirth1.PrintDateOfBirth();

            OurDate dateOfBirth2 = new OurDate();
            dateOfBirth2.date = 10;
            dateOfBirth2.month = 05;
            dateOfBirth2.year = 1997;
            dateOfBirth2.PrintDateOfBirth();

            OurDate dateOfBirth3 = new OurDate();
            dateOfBirth3.date = 18;
            dateOfBirth3.month = 07;
            dateOfBirth3.year = 1998;
            dateOfBirth3.PrintDateOfBirth();

            Human humanOne = new Human();
            humanOne.SetId(100);
            humanOne.SetName("Iron Man");
            humanOne.SetDateOfBirth(dateOfBirth1);
            humanOne.SetBph(113);
            humanOne.SetBpl(85);
            humanOne.SetGender("Male");
            humanOne.SetHeartRate(80);

            humanOne.ShowInformation();



            Human humanTwo = new Human(200, "thor", dateOfBirth2, 90, 50, "Male", 60);
            humanTwo.ShowInformation();

            Human humanThree = new Human(200, "Wonder", dateOfBirth2, 90, 50, "Female", 60);
            humanThree.ShowInformation();

            Human humanFour = new Human(200, "Wonder", dateOfBirth3, 90, 50, "Female", 60);
            humanFour.ShowInformation();
        }
    }
}
