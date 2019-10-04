using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace means folder,directory or packages
namespace ConsoleApplicationSampleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student studentOne = new Student(); //studentOne class type variable
            studentOne.SetId(100);
            studentOne.SetName("Bruce");
            studentOne.SetCgpa(3.56);

            studentOne.ShowInformation();

            //Console.WriteLine("{0}",studentOne.GetId());

            Student studentTwo = studentOne;
            //studentTwo = studentOne;
            studentTwo = new Student();
            studentTwo.SetId(200);
            studentTwo.ShowInformation();

            studentOne.ShowInformation();

            Student studentThree = new Student(200, "Clerk", 3.28);
            studentThree.ShowInformation();

        }
    }
}
