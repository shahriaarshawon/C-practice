using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationStruct
{
    //Structure is not a part of a class( its a value type )
    //Structure or class should be write in the scope of namspace.
    //there is no semicolon ' ; ' after structure.
    //naming of any clss, structure, method is Pascal Case.
    //initialization is not a mandatory job, but whenever we are assigning dynamic allocation initialisation must; so that use Constructor in structure

    struct OurAddress
    {
        public short houseNo; //by default it is private access modifier
        public byte roadNo;
        public string district;

        public void PrintAddress()
        {
            Console.WriteLine("House No: {0}", this.houseNo);
            Console.WriteLine("Road No: {0}", this.roadNo);
            Console.WriteLine("District: {0}", this.district);

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            OurAddress addressOne; //addressOne is variable name, fix memory allocation
            addressOne.houseNo = 10;
            addressOne.roadNo = 20;
            addressOne.district = "DHAKA";
            addressOne.PrintAddress();

            //there is no relation for memory allocation 

            OurAddress addressTwo = new OurAddress(); //"new" keyword use means its dynamic memory allocation, its work at runtime
            addressTwo.houseNo = 5;
            addressTwo.roadNo = 31;
            addressTwo.district = "Sylhet";
            addressTwo.PrintAddress();
        }
    }
}
