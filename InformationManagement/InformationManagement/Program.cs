using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            OurDateType date1 = new OurDateType(10, "March", 2000);
            Student s = new Student(100, "Bruce",3.25, date1);
            s.Id = 1000;//s.id = 1000;//s.SetId(1000);
            //Console.WriteLine("{0}", s.Id);
            s.Name = "Clerk";
            s.Cgpa = 2.87;
            s.DateOfBirth= date1 ;

            s.ShowInformation();
            
        }
    }
}
